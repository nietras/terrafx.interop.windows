// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B37BC9E-9ED6-44A3-93D3-18F022B79EC3")]
    public unsafe partial struct ISpRecoGrammar2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, uint>)(lpVtbl[1]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, uint>)(lpVtbl[2]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRules([NativeTypeName("SPRULE **")] SPRULE** ppCoMemRules, [NativeTypeName("UINT *")] uint* puNumRules)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, SPRULE**, uint*, int>)(lpVtbl[3]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), ppCoMemRules, puNumRules);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromFile2([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] ushort* pszSharingUri, [NativeTypeName("LPCWSTR")] ushort* pszBaseUri)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, ushort*, SPLOADOPTIONS, ushort*, ushort*, int>)(lpVtbl[4]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszFileName, Options, pszSharingUri, pszBaseUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromMemory2([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] ushort* pszSharingUri, [NativeTypeName("LPCWSTR")] ushort* pszBaseUri)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, SPBINARYGRAMMAR*, SPLOADOPTIONS, ushort*, ushort*, int>)(lpVtbl[5]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pGrammar, Options, pszSharingUri, pszBaseUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRulePriority([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, int nRulePriority)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, ushort*, uint, int, int>)(lpVtbl[6]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, nRulePriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRuleWeight([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, float flWeight)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, ushort*, uint, float, int>)(lpVtbl[7]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, flWeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDictationWeight(float flWeight)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, float, int>)(lpVtbl[8]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), flWeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGrammarLoader([NativeTypeName("ISpeechResourceLoader *")] ISpeechResourceLoader* pLoader)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, ISpeechResourceLoader*, int>)(lpVtbl[9]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSMLSecurityManager([NativeTypeName("IInternetSecurityManager *")] IInternetSecurityManager* pSMLSecurityManager)
        {
            return ((delegate* stdcall<ISpRecoGrammar2*, IInternetSecurityManager*, int>)(lpVtbl[10]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pSMLSecurityManager);
        }
    }
}
