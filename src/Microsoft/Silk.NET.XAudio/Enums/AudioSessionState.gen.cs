// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "_AudioSessionState")]
    public enum AudioSessionState : int
    {
        [NativeName("Name", "AudioSessionStateInactive")]
        AudioSessionStateInactive = 0x0,
        [NativeName("Name", "AudioSessionStateActive")]
        AudioSessionStateActive = 0x1,
        [NativeName("Name", "AudioSessionStateExpired")]
        AudioSessionStateExpired = 0x2,
    }
}