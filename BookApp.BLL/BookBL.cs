using DAL;
using System;
using System.Data.SqlClient;
using BookApp.Models;

namespace BookApp.BLL
{
    public class BookBL
    {
        public bool BookAdd(Book ktp)
        {
            try
            {
                if (ktp == null)
                {
                    throw new NullReferenceException("Kitap referansı null geldi.");
                }

                SqlParameter[] p = {
                    new SqlParameter("@KitapID", ktp.KitapId),
                    new SqlParameter("@KitapAdi", ktp.KitapAdi),
                    new SqlParameter("@KitapYazari", ktp.KitapYazari),
                    new SqlParameter("@Basimevi", ktp.Basimevi),
                    new SqlParameter("@BasimYili", ktp.BasimYili),
                    new SqlParameter("@Fiyati", ktp.Fiyati) };
                Helper hlp = new Helper();

                return hlp.ExecuteNonQuery("Insert into tblKitaplik values (@KitapAdi,@KitapYazari,@Basimevi,@BasimYili,@Fiyati)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
