using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OkulAppSube2BIL
{
    public partial class FrmOgretmenKyt : Form
    {
        public String Tc { get; set; }
        public FrmOgretmenKyt()
        {
            InitializeComponent();
            btnOgrSil.Enabled = false;
            btnOgrGuncelle.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtmn = new OgretmenBL();
                bool sonuc = ogrtmn.OgretmenKaydet(new Ogretmen
                {
                   Adi = txtAd.Text.Trim(),
                   Soyadi = txtSoyad.Text.Trim(),
                   Tc = txtTc.Text.Trim()
                }
                );
                if (sonuc)
                {
                    MessageBox.Show("Yeni kayıt eklendi!");
                }

            }
            catch (SqlException exception)
            {
                switch (exception.Number)
                {
                    case 2627:
                        MessageBox.Show($"{txtTc} Tcli öğretmen zaten kayıtlı.");
                        break;
                    default:
                        MessageBox.Show("veri tabanı hatası");
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void btnOgrBul_Click(object sender, EventArgs e)
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtTc.Text = string.Empty;

            try
            {
                OgrBul ogrBul = new OgrBul(this);
                ogrBul.ShowDialog();
            }
            catch (Exception ex)
            {
                throw new Exception("UYARI! Hata: " + ex.Message);
            }
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSil(txtTc.Text.Trim()) ? "Silme Başarılı" : "Başarısız!");
            }
            catch (Exception ex) 
            {
                throw new Exception("Hata: " + ex.Message); 
            }

        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new Ogretmen {Adi = txtAd.Text.Trim(), Soyadi = txtSoyad.Text.Trim(), Tc = txtTc.Text.Trim() }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");

            }
            catch (Exception ex) 
            { 
                throw new Exception("Hata: " + ex.Message); 
            }

        }
    }
}

