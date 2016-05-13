using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKU.Arsiv.App
{
    public partial class FrmMain : Form
    {
        public string Dosya { get; set; }
        public List<System.Data.DataTable> Liste { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            Dosya = "";
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void mnuNewFile_Click(object sender, EventArgs e)
        {
        }


        private void BtnSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Kutu=new OpenFileDialog() { Title="Dosya Seç",Filter="Excel Dosyası |*.xlsx"})
            {
                DialogResult Sonuc = Kutu.ShowDialog();
                if (Sonuc==DialogResult.OK)
                {
                    txtYol.Text = Kutu.FileName;
                    Dosya= Kutu.FileName;
                    using (KKU.Arsiv.Excel.Istemci ExcelIstemci=new Excel.Istemci())
                    {
                        ExcelIstemci.TablolariOlustur(Dosya);
                        Liste = ExcelIstemci.Liste;

                        if (Liste.Count>0)
                        {
                            grdListe.DataSource = Liste[0];
                            
                        }
                        DrpSayfaListesi.DataSource = Liste.Select(x => x.TableName).ToList();
                    }
                }
            }
        }

        private void DrpSayfaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdListe.DataSource = Liste[DrpSayfaListesi.SelectedIndex];
        }
    }
}
