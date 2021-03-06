// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SpeechLoadOption;

namespace TerraFX.Interop
{
    [Guid("B6D6F79F-2158-4E50-B5BC-9A9CCD852A09")]
    public unsafe partial struct ISpeechRecoGrammar
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, uint>)(lpVtbl[1]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, uint>)(lpVtbl[2]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, uint*, int>)(lpVtbl[3]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("VARIANT *")] VARIANT* Id)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, VARIANT*, int>)(lpVtbl[7]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Id);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RecoContext([NativeTypeName("ISpeechRecoContext **")] ISpeechRecoContext** RecoContext)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ISpeechRecoContext**, int>)(lpVtbl[8]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_State(SpeechGrammarState State)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, SpeechGrammarState, int>)(lpVtbl[9]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("SpeechGrammarState *")] SpeechGrammarState* State)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, SpeechGrammarState*, int>)(lpVtbl[10]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Rules([NativeTypeName("ISpeechGrammarRules **")] ISpeechGrammarRules** Rules)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ISpeechGrammarRules**, int>)(lpVtbl[11]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Rules);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset([NativeTypeName("SpeechLanguageId")] int NewLanguage = 0)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, int, int>)(lpVtbl[12]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdLoadFromFile([NativeTypeName("const BSTR")] ushort* FileName, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int>)(lpVtbl[13]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), FileName, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdLoadFromObject([NativeTypeName("const BSTR")] ushort* ClassId, [NativeTypeName("const BSTR")] ushort* GrammarName, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, ushort*, SpeechLoadOption, int>)(lpVtbl[14]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ClassId, GrammarName, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdLoadFromResource([NativeTypeName("long")] int hModule, VARIANT ResourceName, VARIANT ResourceType, [NativeTypeName("SpeechLanguageId")] int LanguageId, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, int, VARIANT, VARIANT, int, SpeechLoadOption, int>)(lpVtbl[15]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), hModule, ResourceName, ResourceType, LanguageId, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdLoadFromMemory(VARIANT GrammarData, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, VARIANT, SpeechLoadOption, int>)(lpVtbl[16]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), GrammarData, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdLoadFromProprietaryGrammar([NativeTypeName("const BSTR")] ushort* ProprietaryGuid, [NativeTypeName("const BSTR")] ushort* ProprietaryString, VARIANT ProprietaryData, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, ushort*, VARIANT, SpeechLoadOption, int>)(lpVtbl[17]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ProprietaryGuid, ProprietaryString, ProprietaryData, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdSetRuleState([NativeTypeName("const BSTR")] ushort* Name, SpeechRuleState State)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, SpeechRuleState, int>)(lpVtbl[18]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Name, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int CmdSetRuleIdState([NativeTypeName("long")] int RuleId, SpeechRuleState State)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, int, SpeechRuleState, int>)(lpVtbl[19]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RuleId, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int DictationLoad([NativeTypeName("const BSTR")] ushort* TopicName = null, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int>)(lpVtbl[20]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), TopicName, LoadOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int DictationUnload()
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, int>)(lpVtbl[21]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DictationSetState(SpeechRuleState State)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, SpeechRuleState, int>)(lpVtbl[22]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordSequenceData([NativeTypeName("const BSTR")] ushort* Text, [NativeTypeName("long")] int TextLength, [NativeTypeName("ISpeechTextSelectionInformation *")] ISpeechTextSelectionInformation* Info)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, int, ISpeechTextSelectionInformation*, int>)(lpVtbl[23]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Text, TextLength, Info);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextSelection([NativeTypeName("ISpeechTextSelectionInformation *")] ISpeechTextSelectionInformation* Info)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ISpeechTextSelectionInformation*, int>)(lpVtbl[24]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Info);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsPronounceable([NativeTypeName("const BSTR")] ushort* Word, [NativeTypeName("SpeechWordPronounceable *")] SpeechWordPronounceable* WordPronounceable)
        {
            return ((delegate* stdcall<ISpeechRecoGrammar*, ushort*, SpeechWordPronounceable*, int>)(lpVtbl[25]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Word, WordPronounceable);
        }
    }
}
