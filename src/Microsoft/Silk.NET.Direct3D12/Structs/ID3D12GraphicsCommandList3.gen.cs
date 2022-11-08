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

namespace Silk.NET.Direct3D12
{
    [Guid("6fda83a7-b84c-4e38-9ac8-c7bd22016b3d")]
    [NativeName("Name", "ID3D12GraphicsCommandList3")]
    public unsafe partial struct ID3D12GraphicsCommandList3 : IComVtbl<ID3D12GraphicsCommandList3>, IComVtbl<ID3D12GraphicsCommandList2>, IComVtbl<ID3D12GraphicsCommandList1>, IComVtbl<ID3D12GraphicsCommandList>, IComVtbl<ID3D12CommandList>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6fda83a7-b84c-4e38-9ac8-c7bd22016b3d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12GraphicsCommandList2(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12GraphicsCommandList2>(ref val);

        public static implicit operator ID3D12GraphicsCommandList1(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12GraphicsCommandList1>(ref val);

        public static implicit operator ID3D12GraphicsCommandList(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12GraphicsCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12GraphicsCommandList3 val)
            => Unsafe.As<ID3D12GraphicsCommandList3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12GraphicsCommandList3
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CommandListType>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator, ref ID3D12PipelineState pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ref ID3D12CommandAllocator pAllocator, ID3D12PipelineState* pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator, ref ID3D12PipelineState pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineState);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState(ref ID3D12PipelineState pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineStatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, uint, void>)@this->LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, int, uint, void>)@this->LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)@this->LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D12Resource* pDstResource, ref ID3D12Resource pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ref ID3D12Resource pDstResource, ID3D12Resource* pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource(ref ID3D12Resource pDstResource, ref ID3D12Resource pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[20])(@this, PrimitiveTopology);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, Viewport* pViewports)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewports);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetViewports(uint NumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewportsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetScissorRects(uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendFactor([Count(Count = 4)] float* BlendFactor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, float*, void>)@this->LpVtbl[23])(@this, BlendFactor);
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetBlendFactor([Count(Count = 4)] ref float BlendFactor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, float*, void>)@this->LpVtbl[23])(@this, BlendFactorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetStencilRef(uint StencilRef)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void>)@this->LpVtbl[24])(@this, StencilRef);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPipelineState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineState);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineState(ref ID3D12PipelineState pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineStatePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteBundle(ref ID3D12GraphicsCommandList pCommandList)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12GraphicsCommandList* pCommandListPtr = &pCommandList)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandListPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ref ID3D12DescriptorHeap* ppDescriptorHeaps)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12DescriptorHeap** ppDescriptorHeapsPtr = &ppDescriptorHeaps)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignaturePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignaturePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)@this->LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)@this->LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)@this->LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer(IndexBufferView* pView)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pView);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetIndexBuffer(ref IndexBufferView pView)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IndexBufferView* pViewPtr = &pView)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pViewPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumViews, VertexBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViews);
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetVertexBuffers(uint StartSlot, uint NumViews, ref VertexBufferView pViews)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VertexBufferView* pViewsPtr = &pViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViews);
        }

        /// <summary>To be documented.</summary>
        public readonly void SOSetTargets(uint StartSlot, uint NumViews, ref StreamOutputBufferView pViews)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (StreamOutputBufferView* pViewsPtr = &pViews)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
            {
                fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pRectsPtr = &pRects)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegion);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, void>)@this->LpVtbl[58])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
                    fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthBounds(float Min, float Max)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, float, float, void>)@this->LpVtbl[62])(@this, Min, Max);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, ref SamplePosition pSamplePositions)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SamplePosition* pSamplePositionsPtr = &pSamplePositions)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<int>* pSrcRectPtr = &pSrcRect)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSrcRectPtr = &pSrcRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pSrcRectPtr = &pSrcRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pSrcRectPtr = &pSrcRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetViewInstanceMask(uint Mask)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void>)@this->LpVtbl[65])(@this, Mask);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParamsPtr, pModesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[67])(@this, pProtectedResourceSession);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession(ref ID3D12ProtectedResourceSession pProtectedResourceSession)
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[67])(@this, pProtectedResourceSessionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset<TI0, TI1>(ComPtr<TI0> pAllocator, ComPtr<TI1> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset<TI0>(ComPtr<TI0> pAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle, ref pInitialState);
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset<TI0>(ref ID3D12CommandAllocator pAllocator, ComPtr<TI0> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reset(ref pAllocator, (ID3D12PipelineState*) pInitialState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState<TI0>(ComPtr<TI0> pPipelineState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearState((ID3D12PipelineState*) pPipelineState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyBufferRegion<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyBufferRegion((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, NumBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyBufferRegion<TI0>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyBufferRegion((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, NumBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyBufferRegion<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, ulong NumBytes) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyBufferRegion(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, NumBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0, TI1>(ComPtr<TI0> pDstResource, ComPtr<TI1> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource((ID3D12Resource*) pDstResource.Handle, (ID3D12Resource*) pSrcResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0>(ComPtr<TI0> pDstResource, ref ID3D12Resource pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource((ID3D12Resource*) pDstResource.Handle, ref pSrcResource);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource<TI0>(ref ID3D12Resource pDstResource, ComPtr<TI0> pSrcResource) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyResource(ref pDstResource, (ID3D12Resource*) pSrcResource.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, pTileRegionStartCoordinate, ref pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0, TI1>(ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI1> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0>(ComPtr<TI0> pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles((ID3D12Resource*) pTiledResource.Handle, ref pTileRegionStartCoordinate, ref pTileRegionSize, ref pBuffer, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles<TI0>(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, ref pTileRegionStartCoordinate, pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles<TI0>(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ComPtr<TI0> pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CopyTiles(ref pTiledResource, ref pTileRegionStartCoordinate, ref pTileRegionSize, (ID3D12Resource*) pBuffer.Handle, BufferStartOffsetInBytes, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource((ID3D12Resource*) pDstResource.Handle, DstSubresource, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource((ID3D12Resource*) pDstResource.Handle, DstSubresource, ref pSrcResource, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource<TI0>(ref ID3D12Resource pDstResource, uint DstSubresource, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresource(ref pDstResource, DstSubresource, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, Format);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineState<TI0>(ComPtr<TI0> pPipelineState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetPipelineState((ID3D12PipelineState*) pPipelineState.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteBundle<TI0>(ComPtr<TI0> pCommandList) where TI0 : unmanaged, IComVtbl<ID3D12GraphicsCommandList>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteBundle((ID3D12GraphicsCommandList*) pCommandList.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDescriptorHeaps<TI0>(uint NumDescriptorHeaps, ref ComPtr<TI0> ppDescriptorHeaps) where TI0 : unmanaged, IComVtbl<ID3D12DescriptorHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetDescriptorHeaps(NumDescriptorHeaps, (ID3D12DescriptorHeap**) ppDescriptorHeaps.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootSignature<TI0>(ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetComputeRootSignature((ID3D12RootSignature*) pRootSignature.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootSignature<TI0>(ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetGraphicsRootSignature((ID3D12RootSignature*) pRootSignature.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, ref pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, ref pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, Values, NumRects, ref pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Box2D<int>* pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat<TI0>(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ComPtr<TI0> pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Box2D<int> pRects) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, (ID3D12Resource*) pResource.Handle, ref Values, NumRects, ref pRects);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource<TI0>(ComPtr<TI0> pResource, DiscardRegion* pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardResource((ID3D12Resource*) pResource.Handle, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource<TI0>(ComPtr<TI0> pResource, ref DiscardRegion pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardResource((ID3D12Resource*) pResource.Handle, ref pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->BeginQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EndQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0, TI1>(ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI1> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, ref pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0>(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI0> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData(ref pQueryHeap, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication<TI0>(ComPtr<TI0> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetPredication((ID3D12Resource*) pBuffer.Handle, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0, TI1, TI2>(ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ComPtr<TI1> pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI2> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0, TI1>(ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ComPtr<TI1> pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0, TI1>(ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI1> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0>(ComPtr<TI0> pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12CommandSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect((ID3D12CommandSignature*) pCommandSignature.Handle, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0, TI1>(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ComPtr<TI0> pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI1> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0>(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ComPtr<TI0> pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, (ID3D12Resource*) pArgumentBuffer.Handle, ArgumentBufferOffset, ref pCountBuffer, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect<TI0>(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ComPtr<TI0> pCountBuffer, ulong CountBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteIndirect(ref pCommandSignature, MaxCommandCount, ref pArgumentBuffer, ArgumentBufferOffset, (ID3D12Resource*) pCountBuffer.Handle, CountBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0, TI1, TI2>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT<TI0, TI1, TI2>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0, TI1>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT<TI0, TI1>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0, TI1, TI2>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT64<TI0, TI1, TI2>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI2> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI2>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ComPtr<TI1> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT64<TI0, TI1>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0>(ComPtr<TI0> pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64((ID3D12Resource*) pDstBuffer.Handle, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0, TI1>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT64<TI0, TI1>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI1> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ComPtr<TI0> pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, (ID3D12Resource*) pSrcBuffer.Handle, SrcOffset, Dependencies, ref ppDependentResources, ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly void AtomicCopyBufferUINT64<TI0>(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ComPtr<TI0> ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AtomicCopyBufferUINT64(ref pDstBuffer, DstOffset, ref pSrcBuffer, SrcOffset, Dependencies, (ID3D12Resource**) ppDependentResources.GetAddressOf(), ref pDependentSubresourceRanges);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI1> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresourceRegion<TI0, TI1>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI1> pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, ref pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, ref pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresourceRegion<TI0>(ComPtr<TI0> pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion((ID3D12Resource*) pDstResource.Handle, DstSubresource, DstX, DstY, ref pSrcResource, SrcSubresource, ref pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion<TI0>(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI0> pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresourceRegion<TI0>(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ComPtr<TI0> pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Box2D<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveSubresourceRegion(ref pDstResource, DstSubresource, DstX, DstY, (ID3D12Resource*) pSrcResource.Handle, SrcSubresource, ref pSrcRect, Format, ResolveMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession<TI0>(ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetProtectedResourceSession((ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GraphicsCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
