using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKU.Arsiv.Excel
{
    public class Istemci : IDisposable
    {
        public List<System.Data.DataTable> Liste { get; set; }
        public Istemci()
        {
            Liste = new List<System.Data.DataTable>();
        }
        public void Dispose()
        {
            
        }

        public void TablolariOlustur(string File)
        {
            using (ClosedXML.Excel.XLWorkbook ExcelDosyasi = new ClosedXML.Excel.XLWorkbook(File))
            {
                foreach (var workSheet in ExcelDosyasi.Worksheets)
                {
                    DataTable dt = new DataTable(workSheet.Name);

                    bool firstRow = true;

                    foreach (IXLRow row in workSheet.Rows())
                    {
                        if (firstRow)
                        {
                            string Deger = "";
                            foreach (IXLCell cell in row.Cells())
                            {
                                Deger = cell.Value.ToString();
                                break;
                            }
                            if (Deger == "SIRA")
                            {

                                foreach (IXLCell cell in row.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                if (i<= dt.Columns.Count-1)
                                {
                                    string Deger = "";
                                    Deger = cell.Value.ToString();
                                    if ((Deger == "SIRA") | (Deger.Trim() == ""))
                                    {
                                        dt.Rows.Remove(dt.Rows[dt.Rows.Count - 1]);
                                        break;
                                    }
                                    //if (Deger=="38")
                                    //{
                                    //    break;
                                    //}
                                    dt.Rows[dt.Rows.Count - 1][i] = Deger;
                                    i++;
                                }
                            }
                        }
                    }
                    Liste.Add(dt);
                }
            }
        }
    }
}
