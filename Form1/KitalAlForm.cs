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
    public partial class KitalAlForm : Form
    {
        public KitalAlForm()
        {
            InitializeComponent();
        }

        private void KitalAlForm_Load(object sender, EventArgs e)
        {
            cmbKitaplar.DataSource = Enum.GetNames(typeof(Turler));
            lstUyeler.DataSource = Form1.states.Ogrenciler.
                OrderBy(x => x.Ad)
                .ThenBy(x => x.Soyad)
                .ToList();
        }
    }
}
