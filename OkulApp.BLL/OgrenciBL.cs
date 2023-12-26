using System;
using System.Data.SqlClient;
using DAL;
using OkulApp.MODEL;

namespace OkulApp.BLL //Business Logic Layer
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@Ad", ogr.Ad),
                    new SqlParameter("@Soyad", ogr.Soyad),
                    new SqlParameter("@Numara", ogr.Numara)
                };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgrenci (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException )
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
