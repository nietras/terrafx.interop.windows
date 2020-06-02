// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0742A90B-C387-483F-B946-30A7E4E61458")]
    public unsafe partial struct ID3D12InfoQueue
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return lpVtbl->SetMessageCountLimit((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
        }

        public void ClearStoredMessages()
        {
            lpVtbl->ClearStoredMessages((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("D3D12_MESSAGE *")] D3D12_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return lpVtbl->GetMessage((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            return lpVtbl->GetNumMessagesAllowedByStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            return lpVtbl->GetNumMessagesDeniedByStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            return lpVtbl->GetNumStoredMessages((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            return lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            return lpVtbl->GetNumMessagesDiscardedByMessageCountLimit((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            return lpVtbl->GetMessageCountLimit((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->AddStorageFilterEntries((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return lpVtbl->GetStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter()
        {
            lpVtbl->ClearStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter()
        {
            return lpVtbl->PushEmptyStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter()
        {
            return lpVtbl->PushCopyOfStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->PushStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopStorageFilter()
        {
            lpVtbl->PopStorageFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize()
        {
            return lpVtbl->GetStorageFilterStackSize((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->AddRetrievalFilterEntries((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return lpVtbl->GetRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter()
        {
            lpVtbl->ClearRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter()
        {
            return lpVtbl->PushEmptyRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter()
        {
            return lpVtbl->PushCopyOfRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->PushRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopRetrievalFilter()
        {
            lpVtbl->PopRetrievalFilter((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize()
        {
            return lpVtbl->GetRetrievalFilterStackSize((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage(D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return lpVtbl->AddMessage((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return lpVtbl->AddApplicationMessage((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnCategory((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnSeverity((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(D3D12_MESSAGE_ID ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnID((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category)
        {
            return lpVtbl->GetBreakOnCategory((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity)
        {
            return lpVtbl->GetBreakOnSeverity((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(D3D12_MESSAGE_ID ID)
        {
            return lpVtbl->GetBreakOnID((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("BOOL")] int bMute)
        {
            lpVtbl->SetMuteDebugOutput((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput()
        {
            return lpVtbl->GetMuteDebugOutput((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, uint> Release;

            [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong, int> SetMessageCountLimit;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, void> ClearStoredMessages;

            [NativeTypeName("HRESULT (UINT64, D3D12_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong, D3D12_MESSAGE*, nuint*, int> GetMessage;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetNumMessagesAllowedByStorageFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetNumMessagesDeniedByStorageFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetNumStoredMessages;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetNumStoredMessagesAllowedByRetrievalFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetNumMessagesDiscardedByMessageCountLimit;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, ulong> GetMessageCountLimit;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, void> ClearStorageFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int> PushEmptyStorageFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int> PushCopyOfStorageFilter;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int> PushStorageFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, void> PopStorageFilter;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, uint> GetStorageFilterStackSize;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, nuint*, int> GetRetrievalFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, void> ClearRetrievalFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int> PushEmptyRetrievalFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int> PushCopyOfRetrievalFilter;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, void> PopRetrievalFilter;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, uint> GetRetrievalFilterStackSize;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, sbyte*, int> AddMessage;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, sbyte*, int> AddApplicationMessage;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, int, int> SetBreakOnCategory;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, int, int> SetBreakOnSeverity;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_ID, int, int> SetBreakOnID;

            [NativeTypeName("BOOL (D3D12_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, int> GetBreakOnCategory;

            [NativeTypeName("BOOL (D3D12_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, int> GetBreakOnSeverity;

            [NativeTypeName("BOOL (D3D12_MESSAGE_ID) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_ID, int> GetBreakOnID;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int, void> SetMuteDebugOutput;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12InfoQueue*, int> GetMuteDebugOutput;
        }
    }
}
