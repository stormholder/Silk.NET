// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkExportMetalBufferInfoEXT")]
    public unsafe partial struct ExportMetalBufferInfoEXT : IExtendsChain<ExportMetalObjectsInfoEXT>
    {
        public ExportMetalBufferInfoEXT
        (
            StructureType? sType = StructureType.ExportMetalBufferInfoExt,
            void* pNext = null,
            DeviceMemory? memory = null,
            nint? mtlBuffer = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (mtlBuffer is not null)
            {
                MtlBuffer = mtlBuffer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "MTLBuffer_id")]
        [NativeName("Type.Name", "MTLBuffer_id")]
        [NativeName("Name", "mtlBuffer")]
        public nint MtlBuffer;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExportMetalBufferInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
