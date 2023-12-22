using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgrenciBL
    {
        //öğretmen tablosu için => tc kimlik ad soyad
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogr.Ad),
                                  new SqlParameter("@Soyad",ogr.Soyad),
                                  new SqlParameter("@Numara",ogr.Numara)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogrenci (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                //{
                //    //cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }


    }
}