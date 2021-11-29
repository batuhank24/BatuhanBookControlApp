using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BatuhanKitaplık
{
    public partial class BookSearch : Form
    {
        SqlConnection cn = null;
        public BookSearch()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=.\; Integrated Security=true; Initial Catalog=KitapeviDB"))
            {
                using (SqlCommand cmd = new SqlCommand("Select KitapID,KitapAdi,Yazari,Basimevi,BasimYili,Fiyati from tblKitaplik where KitapID=@KitapID", cn))
                {
                    SqlParameter[] p = { new SqlParameter("@KitapID", txtKitapIDAra.Text.Trim()) };
                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        BookCElements bookce = (BookCElements)Application.OpenForms["BookCElements"];
                        bookce.txtKitapAdi.Text = dr["KitapAdi"].ToString();
                        bookce.txtYazari.Text = dr["Yazari"].ToString();
                        bookce.txtBasimEvi.Text = dr["Basimevi"].ToString();
                        bookce.txtBasimYili.Text = dr["BasimYili"].ToString();
                        bookce.txtFiyati.Text = dr["Fiyati"].ToString();
                        bookce.kitapid = Convert.ToInt32(dr["KitapID"]);
                        bookce.txtKitapID.Text = dr["KitapID"].ToString();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kitap bulunamadı.");
                    }
                    dr.Close();
                }
            }
        }
    }
}


