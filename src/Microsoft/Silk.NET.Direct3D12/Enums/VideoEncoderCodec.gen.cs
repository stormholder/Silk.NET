// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC")]
    public enum VideoEncoderCodec : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_H264")]
        VideoEncoderCodecH264 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_HEVC")]
        VideoEncoderCodecHevc = 0x1,
    }
}
