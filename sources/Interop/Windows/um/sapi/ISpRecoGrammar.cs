// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2177DB29-7F45-47D0-8554-067E91C80502")]
    public unsafe partial struct ISpRecoGrammar
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpRecoGrammar*, uint>)(lpVtbl[1]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpRecoGrammar*, uint>)(lpVtbl[2]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort, int>)(lpVtbl[3]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("BOOL")] int fCreateIfNotExist, [NativeTypeName("SPSTATEHANDLE *")] SPSTATEHANDLE__** phInitialState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, uint, uint, int, SPSTATEHANDLE__**, int>)(lpVtbl[4]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearRule([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPSTATEHANDLE__*, int>)(lpVtbl[5]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewState([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hState, [NativeTypeName("SPSTATEHANDLE *")] SPSTATEHANDLE__** phState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPSTATEHANDLE__*, SPSTATEHANDLE__**, int>)(lpVtbl[6]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState, phState);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWordTransition([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hFromState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int>)(lpVtbl[7]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRuleTransition([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hFromState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hToState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, float, SPPROPERTYINFO*, int>)(lpVtbl[8]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddResource([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPSTATEHANDLE__*, ushort*, ushort*, int>)(lpVtbl[9]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, uint, int>)(lpVtbl[10]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ulong*, int>)(lpVtbl[11]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pullGrammarId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecoContext([NativeTypeName("ISpRecoContext **")] ISpRecoContext** ppRecoCtxt)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ISpRecoContext**, int>)(lpVtbl[12]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ppRecoCtxt);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromFile([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[13]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszFileName, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromObject([NativeTypeName("const IID &")] Guid* rcid, [NativeTypeName("LPCWSTR")] ushort* pszGrammarName, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, Guid*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[14]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rcid, pszGrammarName, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceType, [NativeTypeName("WORD")] ushort wLanguage, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, IntPtr, ushort*, ushort*, ushort, SPLOADOPTIONS, int>)(lpVtbl[15]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hModule, pszResourceName, pszResourceType, wLanguage, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromMemory([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPBINARYGRAMMAR*, SPLOADOPTIONS, int>)(lpVtbl[16]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pGrammar, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromProprietaryGrammar([NativeTypeName("const GUID &")] Guid* rguidParam, [NativeTypeName("LPCWSTR")] ushort* pszStringParam, [NativeTypeName("const void *")] void* pvDataPrarm, [NativeTypeName("ULONG")] uint cbDataSize, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, Guid*, ushort*, void*, uint, SPLOADOPTIONS, int>)(lpVtbl[17]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rguidParam, pszStringParam, pvDataPrarm, cbDataSize, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRuleState([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("void *")] void* pReserved, SPRULESTATE NewState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, void*, SPRULESTATE, int>)(lpVtbl[18]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszName, pReserved, NewState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, uint, SPRULESTATE, int>)(lpVtbl[19]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ulRuleId, NewState);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadDictation([NativeTypeName("LPCWSTR")] ushort* pszTopicName, SPLOADOPTIONS Options)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[20]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszTopicName, Options);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnloadDictation()
        {
            return ((delegate* stdcall<ISpRecoGrammar*, int>)(lpVtbl[21]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDictationState(SPRULESTATE NewState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPRULESTATE, int>)(lpVtbl[22]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordSequenceData([NativeTypeName("const WCHAR *")] ushort* pText, [NativeTypeName("ULONG")] uint cchText, [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, uint, SPTEXTSELECTIONINFO*, int>)(lpVtbl[23]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pText, cchText, pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextSelection([NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPTEXTSELECTIONINFO*, int>)(lpVtbl[24]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPronounceable([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("SPWORDPRONOUNCEABLE *")] SPWORDPRONOUNCEABLE* pWordPronounceable)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, ushort*, SPWORDPRONOUNCEABLE*, int>)(lpVtbl[25]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszWord, pWordPronounceable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGrammarState(SPGRAMMARSTATE eGrammarState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPGRAMMARSTATE, int>)(lpVtbl[26]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), eGrammarState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCmd([NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, IStream*, ushort**, int>)(lpVtbl[27]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pStream, ppszCoMemErrorText);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGrammarState([NativeTypeName("SPGRAMMARSTATE *")] SPGRAMMARSTATE* peGrammarState)
        {
            return ((delegate* stdcall<ISpRecoGrammar*, SPGRAMMARSTATE*, int>)(lpVtbl[28]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), peGrammarState);
        }
    }
}
