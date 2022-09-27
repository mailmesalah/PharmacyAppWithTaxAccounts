using ServerServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfServerApp.General;

namespace WpfServerApp.Services
{
    class BarcodeService : IBarcode
    {
        public static Dictionary<string, string> NextCharacter = new Dictionary<string, string>();
        private static int noOfCharacters = 5;
        private static readonly object @barcodeLock = new object();
        
        public int NoOfCharacters
        {
            get { return noOfCharacters; }
            set { noOfCharacters = value; }
        }

        public List<string> ReadBarcodes(int limit)
        {
            List<string> barcodes = new List<string>();
            for(int i =1;i<= limit; ++i)
            {
                barcodes.Add(ReadNextBarcode());
            }

            return barcodes;
        }

        public string ReadNextBarcode()
        {
            string barcode = new String('0',NoOfCharacters);
            try
            {
                using (var dataB = new Database9004Entities())
                {
                    var val = dataB.barcode_generator.FirstOrDefault();
                    lock (@barcodeLock)
                    {
                        if (val == null)
                        {

                            barcode_generator bn = dataB.barcode_generator.Create();
                            bn.barcode = barcode;

                            dataB.barcode_generator.Add(bn);                            

                        }
                        else
                        {
                            barcode = val.barcode;
                            val.barcode = getNextBarcode(barcode);
                        }
                        dataB.SaveChanges();
                    }
                }
            }
            catch
            {

            }
            return barcode;
        }

        private string getNextBarcode(string barcode)
        {
            string nextBarcode = "";
            
            for (int i = 0; i < barcode.Length; ++i)
            {

                if (barcode.ElementAt(i) == 'Z')
                {
                    nextBarcode += NextCharacter[barcode.ElementAt(i).ToString()];
                }
                else
                {
                    nextBarcode += NextCharacter[barcode.ElementAt(i).ToString()];
                    if (i != barcode.Length - 1)
                    {
                        nextBarcode += barcode.Substring(i+1,barcode.Length-(i+1));
                    }
                    
                    break;
                }
                
            }

            return nextBarcode;
        }
        public void initialiseBarcodeService()
        {
            //Numbers
            NextCharacter["0"] = "1";
            NextCharacter["1"] = "2";
            NextCharacter["2"] = "3";
            NextCharacter["3"] = "4";
            NextCharacter["4"] = "5";
            NextCharacter["5"] = "6";
            NextCharacter["6"] = "7";
            NextCharacter["7"] = "8";
            NextCharacter["8"] = "9";
            NextCharacter["9"] = "a";
            //Small letters
            NextCharacter["a"] = "b";
            NextCharacter["b"] = "c";
            NextCharacter["c"] = "d";
            NextCharacter["d"] = "e";
            NextCharacter["e"] = "f";
            NextCharacter["f"] = "g";
            NextCharacter["g"] = "h";
            NextCharacter["h"] = "i";
            NextCharacter["i"] = "j";
            NextCharacter["j"] = "k";
            NextCharacter["k"] = "l";
            NextCharacter["l"] = "m";
            NextCharacter["m"] = "n";
            NextCharacter["n"] = "o";
            NextCharacter["o"] = "p";
            NextCharacter["p"] = "q";
            NextCharacter["q"] = "r";
            NextCharacter["r"] = "s";
            NextCharacter["s"] = "t";
            NextCharacter["t"] = "u";
            NextCharacter["u"] = "v";
            NextCharacter["v"] = "w";
            NextCharacter["w"] = "x";
            NextCharacter["x"] = "y";
            NextCharacter["y"] = "z";
            NextCharacter["z"] = "A";
            //Big letters
            NextCharacter["A"] = "B";
            NextCharacter["B"] = "C";
            NextCharacter["C"] = "D";
            NextCharacter["D"] = "E";
            NextCharacter["E"] = "F";
            NextCharacter["F"] = "G";
            NextCharacter["G"] = "H";
            NextCharacter["H"] = "I";
            NextCharacter["I"] = "J";
            NextCharacter["J"] = "K";
            NextCharacter["K"] = "L";
            NextCharacter["L"] = "M";
            NextCharacter["M"] = "N";
            NextCharacter["N"] = "O";
            NextCharacter["O"] = "P";
            NextCharacter["P"] = "Q";
            NextCharacter["Q"] = "R";
            NextCharacter["R"] = "S";
            NextCharacter["S"] = "T";
            NextCharacter["T"] = "U";
            NextCharacter["U"] = "V";
            NextCharacter["V"] = "W";
            NextCharacter["W"] = "X";
            NextCharacter["X"] = "Y";
            NextCharacter["Y"] = "Z";
            NextCharacter["Z"] = "0";            
        }

        public List<CBarcodeDetails> FindBarcodesBetweenDates(DateTime startDate, DateTime endDate, string productCode)
        {
            List<CBarcodeDetails> report = new List<CBarcodeDetails>();

            using (var dataB = new Database9004Entities())
            {
                string startD = startDate.Year + "-" + startDate.Month + "-" + startDate.Day;
                string endD = endDate.Year + "-" + endDate.Month + "-" + endDate.Day;

                string billTypeQuery = " && (bd.bill_type Not In ('SD','SL','SI','SW','PRI','PRW')) ";                
                string productCodeQuery = productCode.Trim().Equals("") ? "" : " && (bd.product_code='" + productCode.Trim() + "') ";
                
                string subQ = productCodeQuery + billTypeQuery;

                var resData = dataB.Database.SqlQuery<CBarcodeDetails>("Select  bd.barcode as Barcode, bd.quantity As Quantity, bd.expiry_date As ExpiryDate, bd.batch As Batch, bd.mrp As MRP, bd.wholesale_rate As WholesaleRate, bd.interstate_rate As InterstateRate, bd.purchase_rate As PurchaseRate, bd.product As Product From product_transactions bd Where(bd.bill_date_time >= '" + startD + "' && bd.bill_date_time <='" + endD + "') " + subQ + " Order By bd.bill_date_time");
                
                foreach (var item in resData)
                {
                    report.Add(item);
                }
            }

            return report;
        }

        public CBarcodePrint ReadBarcodePrintSetting()
        {
            CBarcodePrint cbp = null;

            using (var dataB = new Database9004Entities())
            {
                var bp = dataB.barcode_print.Select(c => c);

                if (bp.Count() > 0)
                {
                    cbp = new CBarcodePrint();

                    var bpfirst = bp.FirstOrDefault();

                    cbp.StartX = bpfirst.start_x;
                    cbp.StartY = bpfirst.start_y;
                    cbp.BWidth = bpfirst.b_width;
                    cbp.BHeight = bpfirst.b_height;
                    cbp.VGap = bpfirst.v_gap;
                    cbp.HGap = bpfirst.h_gap;                    
                }

            }

            return cbp;
        }

        public CBarcodeProperty ReadBarcodeProperty()
        {
            CBarcodeProperty cbp = null;

            using (var dataB = new Database9004Entities())
            {
                var bp = dataB.barcode_property.Select(c => c);

                if (bp.Count() > 0)
                {
                    cbp = new CBarcodeProperty();

                    var bpfirst = bp.FirstOrDefault();

                    cbp.BHeight = bpfirst.b_height;
                    cbp.BWidth = bpfirst.b_width;
                    cbp.BLength = bpfirst.b_length;                    
                }

            }

            return cbp;
        }

        public List<CBarcodeData> ReadBarcodeData()
        {
            List<CBarcodeData> bdList = new List<CBarcodeData>();

            using (var dataB = new Database9004Entities())
            {
                var bds = dataB.barcode_data.Select(c => c);

                if (bds.Count() > 0)
                {                    
                    foreach (var item in bds)
                    {
                        bdList.Add(new CBarcodeData() { ItemName= item.item_name, ItemX=item.item_x, ItemY = item.item_y, Type= item.type, ItemLength= item.item_length, Font= item.font, FontSize= item.font_size, FontColor= item.font_color, Format= item.format, IsBold= item.is_bold, IsItalic= item.is_italic, IsNumeric= item.is_numeric });
                    }
                }

            }

            return bdList;
        }

        public bool UpdateBarcodePrintSetting(CBarcodePrint oBarcodePrint)
        {
            bool returnValue = false;

            lock (Synchronizer.@lock)
            {
                using (var dataB = new Database9004Entities())
                {
                    var dataBTransaction = dataB.Database.BeginTransaction();
                    try
                    {
                        var bp = dataB.barcode_print.Select(c => c);
                        dataB.barcode_print.RemoveRange(bp);

                        barcode_print bpt = dataB.barcode_print.Create();
                        bpt.start_x = oBarcodePrint.StartX;
                        bpt.start_y = oBarcodePrint.StartY;
                        bpt.b_width = oBarcodePrint.BWidth;
                        bpt.b_height = oBarcodePrint.BHeight;
                        bpt.v_gap = oBarcodePrint.VGap;
                        bpt.h_gap = oBarcodePrint.HGap;
                        dataB.barcode_print.Add(bpt);
                        dataB.SaveChanges();
                        //Success
                        returnValue = true;

                        dataBTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dataBTransaction.Rollback();
                    }
                    finally
                    {

                    }
                }
            }
            return returnValue;
        }

        public bool UpdateBarcodeProperty(CBarcodeProperty oBarcodeProperty)
        {
            bool returnValue = false;

            lock (Synchronizer.@lock)
            {
                using (var dataB = new Database9004Entities())
                {
                    var dataBTransaction = dataB.Database.BeginTransaction();
                    try
                    {
                        var bp = dataB.barcode_property.Select(c => c);
                        dataB.barcode_property.RemoveRange(bp);

                        barcode_property bpt = dataB.barcode_property.Create();
                        bpt.b_width = oBarcodeProperty.BWidth;
                        bpt.b_height = oBarcodeProperty.BHeight;
                        bpt.b_length = oBarcodeProperty.BLength;
                        dataB.barcode_property.Add(bpt);
                        dataB.SaveChanges();
                        //Success
                        returnValue = true;

                        dataBTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dataBTransaction.Rollback();
                    }
                    finally
                    {

                    }
                }
            }
            return returnValue;
        }

        public bool UpdateBarcodeData(List<CBarcodeData> barcodeDataList)
        {
            bool returnValue = false;

            lock (Synchronizer.@lock)
            {
                using (var dataB = new Database9004Entities())
                {
                    var dataBTransaction = dataB.Database.BeginTransaction();
                    try
                    {
                        var cpp = dataB.barcode_data.Select(c => c);
                        dataB.barcode_data.RemoveRange(cpp);

                        for (int i = 0; i < barcodeDataList.Count; i++)
                        {
                            barcode_data bd = dataB.barcode_data.Create();
                            bd.item_name = barcodeDataList.ElementAt(i).ItemName;
                            bd.item_length = barcodeDataList.ElementAt(i).ItemLength;
                            bd.item_x = barcodeDataList.ElementAt(i).ItemX;
                            bd.item_y = barcodeDataList.ElementAt(i).ItemY;
                            bd.type = barcodeDataList.ElementAt(i).Type;
                            bd.font = barcodeDataList.ElementAt(i).Font;
                            bd.font_color = barcodeDataList.ElementAt(i).FontColor;
                            bd.font_size = barcodeDataList.ElementAt(i).FontSize;
                            bd.is_bold = barcodeDataList.ElementAt(i).IsBold;
                            bd.is_italic = barcodeDataList.ElementAt(i).IsItalic;
                            bd.is_numeric = barcodeDataList.ElementAt(i).IsNumeric;
                            bd.format = barcodeDataList.ElementAt(i).Format;

                            dataB.barcode_data.Add(bd);
                        }
                        dataB.SaveChanges();
                        //Success
                        returnValue = true;

                        dataBTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        dataBTransaction.Rollback();
                    }
                    finally
                    {

                    }
                }
            }
            return returnValue;
        }
    }
}
