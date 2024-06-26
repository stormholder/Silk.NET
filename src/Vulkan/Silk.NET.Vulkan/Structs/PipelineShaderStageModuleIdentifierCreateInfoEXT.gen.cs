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
    [NativeName("Name", "VkPipelineShaderStageModuleIdentifierCreateInfoEXT")]
    public unsafe partial struct PipelineShaderStageModuleIdentifierCreateInfoEXT : IExtendsChain<PipelineShaderStageCreateInfo>
    {
        public PipelineShaderStageModuleIdentifierCreateInfoEXT
        (
            StructureType? sType = StructureType.PipelineShaderStageModuleIdentifierCreateInfoExt,
            void* pNext = null,
            uint? identifierSize = null,
            byte* pIdentifier = null
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

            if (identifierSize is not null)
            {
                IdentifierSize = identifierSize.Value;
            }

            if (pIdentifier is not null)
            {
                PIdentifier = pIdentifier;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "identifierSize")]
        public uint IdentifierSize;
/// <summary></summary>
        [NativeName("Type", "uint8_t*")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pIdentifier")]
        public byte* PIdentifier;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineShaderStageModuleIdentifierCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
