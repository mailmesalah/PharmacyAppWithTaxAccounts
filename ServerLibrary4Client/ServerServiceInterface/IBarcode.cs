using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerServiceInterface
{
    [ServiceContract]
    public interface IBarcode
    {

        [OperationContract]
        CBarcodePrint ReadBarcodePrintSetting();

        [OperationContract]
        CBarcodeProperty ReadBarcodeProperty();

        [OperationContract]
        List<CBarcodeData> ReadBarcodeData();

        [OperationContract]
        bool UpdateBarcodePrintSetting(CBarcodePrint cbp);

        [OperationContract]
        bool UpdateBarcodeProperty(CBarcodeProperty cbp);

        [OperationContract]
        bool UpdateBarcodeData(List<CBarcodeData> cbd);

        [OperationContract]
        List<CBarcodeDetails> FindBarcodesBetweenDates(DateTime startDate, DateTime endDate, string productCode);
        
    }

    [DataContract]
    public class CBarcodeProperty
    {
        decimal bWidth;
        decimal bheight;
        int bLength;        
        
        [DataMember]
        public decimal BWidth
        {
            get { return bWidth; }
            set { bWidth = value; }
        }

        [DataMember]
        public decimal BHeight
        {
            get { return bheight; }
            set { bheight = value; }
        }

        [DataMember]
        public int BLength
        {
            get { return bLength; }
            set { bLength = value; }
        }
        
    }

    [DataContract]
    public class CBarcodeData
    {
        string itemName;
        int itemLength;
        decimal itemX;
        decimal itemY;
        string type;
        bool isNumeric;
        string format;
        string font;
        int fontSize;        
        string fontColor;
        bool isBold;
        bool isItalic;

        [DataMember]
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        [DataMember]
        public int ItemLength
        {
            get { return itemLength; }
            set { itemLength = value; }
        }

        [DataMember]
        public decimal ItemX
        {
            get { return itemX; }
            set { itemX = value; }
        }

        [DataMember]
        public decimal ItemY
        {
            get { return itemY; }
            set { itemY = value; }
        }

        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DataMember]
        public bool IsNumeric
        {
            get { return isNumeric; }
            set { isNumeric = value; }
        }

        [DataMember]
        public string Font
        {
            get { return font; }
            set { font = value; }
        }

        [DataMember]
        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        [DataMember]
        public int FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        [DataMember]
        public string FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        [DataMember]
        public bool IsBold
        {
            get { return isBold; }
            set { isBold = value; }
        }

        [DataMember]
        public bool IsItalic
        {
            get { return isItalic; }
            set { isItalic = value; }
        }
        
    }

    [DataContract]
    public class CBarcodePrint
    {
        decimal startX;
        decimal startY;
        decimal bWidth;
        decimal bheight;
        decimal vGap;
        decimal hGap;
        
        [DataMember]
        public decimal StartX
        {
            get { return startX; }
            set { startX = value; }
        }

        [DataMember]
        public decimal StartY
        {
            get { return startY; }
            set { startY = value; }
        }

        [DataMember]
        public decimal BWidth
        {
            get { return bWidth; }
            set { bWidth = value; }
        }

        [DataMember]
        public decimal BHeight
        {
            get { return bheight; }
            set { bheight = value; }
        }

        [DataMember]
        public decimal VGap
        {
            get { return vGap; }
            set { vGap = value; }
        }

        [DataMember]
        public decimal HGap
        {
            get { return hGap; }
            set { hGap = value; }
        }
        
    }

    [DataContract]
    public class CBarcodeDetails
    {
        bool select;
        string product;
        decimal quantity;
        decimal purchaseRate;
        decimal interstateRate;
        decimal wholesaleRate;
        decimal mrp;
        DateTime? expiryDate;
        string batch;
        string barcode;

        [DataMember]
        public bool Select
        {
            get { return select; }
            set { select = value; }
        }

        [DataMember]
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        [DataMember]
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public decimal PurchaseRate
        {
            get { return purchaseRate; }
            set { purchaseRate = value; }
        }

        [DataMember]
        public decimal InterstateRate
        {
            get { return interstateRate; }
            set { interstateRate = value; }
        }

        [DataMember]
        public decimal WholesaleRate
        {
            get { return wholesaleRate; }
            set { wholesaleRate = value; }
        }

        [DataMember]
        public decimal MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }

        [DataMember]
        public DateTime? ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
        [DataMember]

        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }

        [DataMember]
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
    }
}
