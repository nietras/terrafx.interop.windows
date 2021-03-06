// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    public unsafe partial struct IWICDevelopRaw
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, Guid*, void**, int>)(lpVtbl[0]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint>)(lpVtbl[1]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint>)(lpVtbl[2]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT *")] uint* puiWidth, [NativeTypeName("UINT *")] uint* puiHeight)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint*, uint*, int>)(lpVtbl[3]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, Guid*, int>)(lpVtbl[4]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution([NativeTypeName("double *")] double* pDpiX, [NativeTypeName("double *")] double* pDpiY)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, double*, int>)(lpVtbl[5]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IWICPalette*, int>)(lpVtbl[6]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, [NativeTypeName("UINT")] uint cbStride, [NativeTypeName("UINT")] uint cbBufferSize, [NativeTypeName("BYTE *")] byte* pbBuffer)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICRect*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader([NativeTypeName("IWICMetadataQueryReader **")] IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts([NativeTypeName("UINT")] uint cCount, [NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContexts, [NativeTypeName("UINT *")] uint* pcActualCount)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("IWICBitmapSource **")] IWICBitmapSource** ppIThumbnail)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo([NativeTypeName("WICRawCapabilitiesInfo *")] WICRawCapabilitiesInfo* pInfo)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICRawCapabilitiesInfo*, int>)(lpVtbl[11]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICRawParameterSet, int>)(lpVtbl[12]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet([NativeTypeName("IPropertyBag2 **")] IPropertyBag2** ppCurrentParameterSet)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IPropertyBag2**, int>)(lpVtbl[13]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[14]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation([NativeTypeName("double *")] double* pEV)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[15]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB([NativeTypeName("UINT")] uint Red, [NativeTypeName("UINT")] uint Green, [NativeTypeName("UINT")] uint Blue)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint, uint, uint, int>)(lpVtbl[16]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB([NativeTypeName("UINT *")] uint* pRed, [NativeTypeName("UINT *")] uint* pGreen, [NativeTypeName("UINT *")] uint* pBlue)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[17]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICNamedWhitePoint, int>)(lpVtbl[18]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint([NativeTypeName("WICNamedWhitePoint *")] WICNamedWhitePoint* pWhitePoint)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICNamedWhitePoint*, int>)(lpVtbl[19]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin([NativeTypeName("UINT")] uint WhitePointKelvin)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint, int>)(lpVtbl[20]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin([NativeTypeName("UINT *")] uint* pWhitePointKelvin)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint*, int>)(lpVtbl[21]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo([NativeTypeName("UINT *")] uint* pMinKelvinTemp, [NativeTypeName("UINT *")] uint* pMaxKelvinTemp, [NativeTypeName("UINT *")] uint* pKelvinTempStepValue)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint*, uint*, uint*, int>)(lpVtbl[22]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[23]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContrast([NativeTypeName("double *")] double* pContrast)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[24]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[25]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGamma([NativeTypeName("double *")] double* pGamma)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[26]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[27]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharpness([NativeTypeName("double *")] double* pSharpness)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[28]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[29]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSaturation([NativeTypeName("double *")] double* pSaturation)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[30]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[31]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTint([NativeTypeName("double *")] double* pTint)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[32]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[33]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction([NativeTypeName("double *")] double* pNoiseReduction)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[34]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* pColorContext)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IWICColorContext*, int>)(lpVtbl[35]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve([NativeTypeName("UINT")] uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint, WICRawToneCurve*, int>)(lpVtbl[36]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve([NativeTypeName("UINT")] uint cbToneCurveBufferSize, [NativeTypeName("WICRawToneCurve *")] WICRawToneCurve* pToneCurve, [NativeTypeName("UINT *")] uint* pcbActualToneCurveBufferSize)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, uint, WICRawToneCurve*, uint*, int>)(lpVtbl[37]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double, int>)(lpVtbl[38]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("double *")] double* pRotation)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, double*, int>)(lpVtbl[39]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICRawRenderMode, int>)(lpVtbl[40]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode([NativeTypeName("WICRawRenderMode *")] WICRawRenderMode* pRenderMode)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, WICRawRenderMode*, int>)(lpVtbl[41]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback([NativeTypeName("IWICDevelopRawNotificationCallback *")] IWICDevelopRawNotificationCallback* pCallback)
        {
            return ((delegate* stdcall<IWICDevelopRaw*, IWICDevelopRawNotificationCallback*, int>)(lpVtbl[42]))((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
        }
    }
}
