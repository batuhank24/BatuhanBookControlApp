using BookApp.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using BookApp.BLL;


namespace BatuhanKitaplık
{
    public partial class BookCElements : Form
    {
        SqlConnection cn = null;
        public int kitapid = 0;

        public BookCElements()
        {
            InitializeComponent();
        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                BookBL bbl = new BookBL();
                bool sonuc = bbl.BookAdd(new Book(txtKitapAdi.Text.Trim(), txtYazari.Text.Trim(), txtBasimEvi.Text.Trim(), int.Parse(txtBasimYili.Text), float.Parse(txtFiyati.Text)));
                if (sonuc)
                {
                    MessageBox.Show("İşlem başarılı, kitap eklendi!");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız, lütfen tekrar deneyin.");
                }
            }
            catch (SqlException x)
            {
                switch (x.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu kitap daha önce kaydedilmiş.");
                        break;
                    case 1225:
                        MessageBox.Show("Veritabanıyla bağlantı kurulamadı. Lütfen bağlantıyı kontrol edip tekrar deneyiniz.");
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Sistem hatası oluştu." + x.Message);
            }
            catch (Exception x)
            {
                MessageBox.Show("Bir şey oldu." + x.Message);
            }
        }

        void CloseConnection()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            BookSearch bsr = new BookSearch();
            bsr.ShowDialog();
        }

        private void btn_KitapKaldir_Click(object sender, EventArgs e)
        {
            if (kitapid == 0)
            {
                MessageBox.Show("Önce kitap seçmelisiniz!");

            }
            else
            {
                DialogResult cvp = MessageBox.Show("Kitabı silmek istediğinizden emin misiniz?", "Kayıt silme onayı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblKitaplik where KitapID=@KitapID", cn))
                        {
                            SqlParameter[] p = {
                            new SqlParameter("@KitapID", kitapid) };

                            cmd.Parameters.AddRange(p); // Dizinin içerisindeki tüm elemanları ekler.
                            if (cn != null && cn.State != ConnectionState.Open)
                            {
                                cn.Open();
                            }
                            int sonuc = cmd.ExecuteNonQuery();
                            MessageBox.Show(sonuc > 0 ? "İşlem başarılı." : "İşlem başarısız!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt silme işlemi iptal edildi.");
                }

            }
        }

        private void btn_KitapGuncelle_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Update tblKitaplik set KitapAdi=@KitapAdi,Yazari=@Yazari,Basimevi=@Basimevi,BasimYili=@BasimYili,Fiyati=@Fiyati from tblKitaplik where KitapID=@kitapid", cn))
                {
                    SqlParameter[] p = {
                        new SqlParameter("@KitapAdi", txtKitapAdi.Text.Trim()),
                        new SqlParameter("@Yazari", txtYazari.Text.Trim()),
                        new SqlParameter("@Basimevi", txtBasimEvi.Text.Trim()),
                        new SqlParameter("@BasimYili", int.Parse(txtBasimYili.Text)),
                        new SqlParameter("@Fiyati", float.Parse(txtFiyati.Text)),
                        new SqlParameter("@kitapid", kitapid)

                        };

                    cmd.Parameters.AddRange(p);

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    int sonuc = cmd.ExecuteNonQuery();

                    MessageBox.Show(sonuc > 0 ? "Güncelleme işlemi başarılı." : "Güncelleme işlemi başarısız!");
                }
            }
        }

        private void btn_GoogleSearch_Click(object sender, EventArgs e)
        {
            KitaplikGSearch kgs = new KitaplikGSearch();
            kgs.ShowDialog();
        }
    }
}
