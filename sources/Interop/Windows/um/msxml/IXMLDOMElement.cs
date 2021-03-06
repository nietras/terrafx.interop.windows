// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF86-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMElement
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDOMElement*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDOMElement*, uint>)(lpVtbl[1]))((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDOMElement*, uint>)(lpVtbl[2]))((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDOMElement*, uint*, int>)(lpVtbl[3]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDOMElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDOMElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDOMElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[7]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* stdcall<IXMLDOMElement*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* stdcall<IXMLDOMElement*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return ((delegate* stdcall<IXMLDOMElement*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* stdcall<IXMLDOMElement*, short*, int>)(lpVtbl[22]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return ((delegate* stdcall<IXMLDOMElement*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[25]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[26]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, int>)(lpVtbl[27]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* stdcall<IXMLDOMElement*, short*, int>)(lpVtbl[28]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return ((delegate* stdcall<IXMLDOMElement*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* stdcall<IXMLDOMElement*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMElement*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, int>)(lpVtbl[33]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[34]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* stdcall<IXMLDOMElement*, short*, int>)(lpVtbl[38]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[39]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[40]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[41]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_tagName([NativeTypeName("BSTR *")] ushort** tagName)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort**, int>)(lpVtbl[43]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), tagName);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, VARIANT*, int>)(lpVtbl[44]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* name, VARIANT value)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, VARIANT, int>)(lpVtbl[45]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, value);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* name)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, int>)(lpVtbl[46]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int getAttributeNode([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attributeNode)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, IXMLDOMAttribute**, int>)(lpVtbl[47]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), name, attributeNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int setAttributeNode([NativeTypeName("IXMLDOMAttribute *")] IXMLDOMAttribute* DOMAttribute, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attributeNode)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMAttribute*, IXMLDOMAttribute**, int>)(lpVtbl[48]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), DOMAttribute, attributeNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNode([NativeTypeName("IXMLDOMAttribute *")] IXMLDOMAttribute* DOMAttribute, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attributeNode)
        {
            return ((delegate* stdcall<IXMLDOMElement*, IXMLDOMAttribute*, IXMLDOMAttribute**, int>)(lpVtbl[49]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), DOMAttribute, attributeNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXMLDOMElement*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[50]))((IXMLDOMElement*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return ((delegate* stdcall<IXMLDOMElement*, int>)(lpVtbl[51]))((IXMLDOMElement*)Unsafe.AsPointer(ref this));
        }
    }
}
