using SLNStokTakipV1.Fonksiyonlar;
using SLNStokTakipV1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLNStokTakipV1.Bilgi
{
    public partial class frmUrunGiris : Form
    {
        STContext db = new STContext();
        Formlar f = new Formlar();
        Mesajlar m = new Mesajlar();
        Numaralar n = new Numaralar();

        public frmUrunGiris()
        {
            InitializeComponent();
        }
        void YeniKaydet()
        {
            bgUrunGiris ug = new bgUrunGiris();
            ug.Afiyat = decimal.Parse(txtAlisFiyati.Text);
            ug.KategoriId = int.Parse(txtKategoriAdi.SelectedValue.ToString());
            ug.Lot = txtLot.Text;
            ug.UrunKodu = txtUrunKodu.Text;
            ug.UrunNo = int.Parse(txtUno.Text);
            ug.saveDate = DateTime.Now;
            ug.updateDate = DateTime.Now;
            ug.saveUser = -1;
            ug.saveUser = -1;

        }
        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            txtKategoriAdi.DataSource=db.bgKategoriler.ToList();
            txtKategoriAdi.DisplayMember = "KategoriAdi";
            txtKategoriAdi.ValueMember = "ıd";
            txtUrunKodu.Text = n.Uno();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.bgUrunGirisler.Remove(db.bgUrunGirisler.Find(int.Parse(txtUno.Text)));
            db.SaveChanges();
        }

        [DllImport("user32.dll")]

        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        protected override void OnLoad(EventArgs e)
        {
            var btnUno = new Button();
            btnUno.Size = new Size(25, txtUno.ClientSize.Height + 2);
            btnUno.Location = new Point(txtUno.ClientSize.Width - btnUno.Width, -1);
            btnUno.Cursor = Cursors.Default;
            txtUno.Controls.Add(btnUno);
            SendMessage(txtUno.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnUno.Width << 16));
            btnUno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnUno.Click += btnUno_Click;

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            int id = f.UBul(true);
            if (id > 0)
            {
                Uac(id);
            }
            frmAnaSayfa.AktarmaI = -1;
        }

        private void Uac(int id)
        {
            throw new NotImplementedException();
        }
    }
}
