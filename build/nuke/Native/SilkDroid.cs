// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Git;
using Octokit;
using Octokit.Internal;
using static Nuke.Common.IO.CompressionTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.HttpTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.GitHub.GitHubTasks;

partial class Build {
    string AndroidHome
    {
        get
        {
            if (AndroidHomeValue is not null)
            {
                return AndroidHomeValue;
            }

            var utils = RootDirectory / "build" / "utilities";
            DotNet($"build \"{utils / "android_probe.proj"}\" /t:GetAndroidJar");
            AndroidHomeValue = (AbsolutePath) File.ReadAllText(utils / "android.jar.gen.txt") / ".." / ".." / "..";
            Logger.Info($"Android Home: {AndroidHomeValue}");
            return AndroidHomeValue;
        }
    }

    Target BuildLibSilkDroid => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    if (!Native)
                    {
                        Logger.Warn("Skipping gradlew build as the --native parameter has not been specified.");
                        return Enumerable.Empty<Output>();
                    }

                    var sdl = RootDirectory / "build" / "submodules" / "SDL";
                    var silkDroid = SourceDirectory / "Windowing" / "SilkDroid";
                    var xcopy = new (string, string)[]
                    {
                        (sdl / "android-project" / "app" / "src" / "main" / "java",
                            silkDroid / "app" / "src" / "main" / "java"),
                        (sdl, silkDroid / "app" / "jni" / "SDL2")
                    };

                    foreach (var (from, to) in xcopy)
                    {
                        if (!Directory.Exists(from))
                        {
                            ControlFlow.Fail
                                ($"\"{from}\" does not exist (did you forget to recursively clone the repo?)");
                        }

                        CopyDirectoryRecursively(from, to, DirectoryExistsPolicy.Merge, FileExistsPolicy.Overwrite);
                    }

                    var envVars = CreateEnvVarDictionary();
                    envVars["ANDROID_HOME"] = AndroidHome;

                    foreach (var ndk in Directory.GetDirectories((AbsolutePath) AndroidHome / "ndk")
                                 .OrderByDescending(x => Version.Parse(Path.GetFileName(x))))
                    {
                        envVars["ANDROID_NDK_HOME"] = ndk;
                    }

                    using var process = StartShell($".{Path.PathSeparator}gradlew build", silkDroid, envVars);
                    process.AssertZeroExitCode();
                    var ret = process.Output;
                    CopyFile
                    (
                        silkDroid / "app" / "build" / "outputs" / "aar" / "app-release.aar",
                        SourceDirectory / "Windowing" / "Silk.NET.Windowing.Sdl" / "Android" / "app-release.aar",
                        FileExistsPolicy.Overwrite
                    );
                    return ret;
                }
            )
    );
}