using Kutuphane.Lib.Business;
using Kutuphane.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class YazarEkleForm : Form
    {
        public YazarEkleForm()
        {
            InitializeComponent();
        }
        private List<Kitap> Kitaplar;
        private void YazarEkleForm_Load(object sender, EventArgs e)
        {
            Kitaplar = Form1.states.Kitaplar;
            cmbTurler.DataSource = Enum.GetNames(typeof(Turler));

        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turler turler = (Turler)Enum.Parse(typeof(Turler), cmbTurler.SelectedItem.ToString());
            var kitaplari = Kitaplar
                .Where(x => x.turler == turler)
                .OrderByDescending(x => x.AtandiMi).ToList();
            chklbKitaplar.DataSource = kitaplari;

            for (int i = 0; i < kitaplari.Count; i++)
            {
                var ktp = kitaplari[i];
                if (ktp.AtandiMi)
                    chklbKitaplar.SetItemCheckState(i, CheckState.Checked);

            }
            lstYazarlar.DataSource = Form1.states.Yazarlar.
                Where(x => x.turler == turler).
                ToList();

        }

        private void btnKitapAta_Click(object sender, EventArgs e)
        {
            YazarBusiness yazarBusiness = new YazarBusiness();
            Yazar yzr = lstYazarlar.SelectedItem as Yazar;
            foreach ( object checkedItem in chklbKitaplar.CheckedItems)
            {
                Kitap ktp = checkedItem as Kitap;
                    if (ktp.AtandiMi) continue;
                yazarBusiness.AtamaYap(yzr, ktp);

                    

            }
        }
    }
}
