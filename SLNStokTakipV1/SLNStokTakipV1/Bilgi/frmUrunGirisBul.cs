using SLNStokTakipV1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Bilgi
{
    public partial class frmUrunGirisBul : Form
    {
        STContext db = new STContext();
        public bool Secim;
        int secimID = -1;

        public frmUrunGirisBul()
        {
            InitializeComponent();
        }
        private void frmUrunGirisBul_Load(object sender, EventArgs e)
        {

        }
        private void frmUrunBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Listele()
        {
            Liste.DataSource = db.bgUrunGirisler
                               .Select(x => new { x.Id, x.UrunNo, x.BgKategori.KategoriAdi, x.UrunKodu, x.Lot, x.UrunAciklama, x.Afiyat }).ToList();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Bul();
        }
        void Bul()
        {
            var bul = (from x in db.bgUrunGirisler
                       where x.UrunKodu.Contains(txtUrunKodu.Text)
                       select new { x.Id, x.UrunNo, x.UrunKodu, x.UrunAciklama, x.BgKategori.KategoriAdi }
                                    ).ToList();
            Liste.DataSource = bul;
        }
        void UrunSec()
        {
            try
            {
                secimID = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                secimID = -1;
            }
            
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            UrunSec();
            if (Secim && secimID > 0)
            {
                frmAnaSayfa.AktarmaI = secimID;
                Close();
            }
        }
    }
}
