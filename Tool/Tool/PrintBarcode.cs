using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using DataMatrix.net;
using ZXing;
using ZXing.QrCode;

namespace Tool
{
    class PrintBarcode
    {
        public Bitmap BarCode_Code39(string sText, int picHeight, int picMargin)
        {//一維條碼 Code39
            BarcodeWriter writer = new BarcodeWriter  //dll裡面可以看到屬性
            {
                Format = BarcodeFormat.CODE_39,
                Options = new QrCodeEncodingOptions //設定大小
                {

                    Height = picHeight,
                    Margin = picMargin,
                    PureBarcode = true
                }
            };
            Bitmap bm = writer.Write(sText);
            return bm;
        }

        public Bitmap BarCode_DataMatrix(string sText, int ModuleSize, int MargeSize)
        {//二維條碼 DataMatrix
            DmtxImageEncoderOptions opt = new DmtxImageEncoderOptions()
            {
                ModuleSize = ModuleSize,
                MarginSize = MargeSize
            };
            DmtxImageEncoder encode = new DmtxImageEncoder();
            Bitmap bm = encode.EncodeImage(sText, opt);
            return bm;
        }

        public Bitmap BarCode_QRCode(string sText, int picHeight, int picMargin)
        {//二維條碼 DataMatrix
            BarcodeWriter writer = new BarcodeWriter  //dll裡面可以看到屬性
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions //設定大小
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Height = picHeight,
                    Width = picHeight,
                    Margin = picMargin,
                    PureBarcode = true
                }
            };
            Bitmap bm = writer.Write(sText);
            return bm;
        }
    }
}
