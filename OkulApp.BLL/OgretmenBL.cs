using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Tc",ogrt.Tc),
                                  new SqlParameter("@Ad",ogrt.Ad),
                                  new SqlParameter("@Soyad",ogrt.Soyad),
                                  
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogretmen (Tc,Ad,Soyad) values (@Tc,@Ad,@Soyad)", p) > 0;
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

            }
        }
    }
}
