using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private Helper hlp;
        public OgretmenBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgretmenKaydet(Ogretmen ogretmen)
        {
            var p = new SqlParameter[]
            {
                    new SqlParameter("@Ad",ogretmen.Adi),
                    new SqlParameter("@Soyad",ogretmen.Soyadi),
                    new SqlParameter("@Tc",ogretmen.Tc)
            };
            return hlp.ExecuteNonQuery("Insert into tblOgretmen Values (@Ad,@Soyad,@Tc)", p) > 0;
        }
        public Ogretmen OgretmenBul(string Tc)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tc", Tc) };
                var dr = hlp.ExecuteReader("Select OgretmenId,Adi,Soyadi,Tc from tblOgretmen where Tc=@Tc", p);
                Ogretmen ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogretmen();
                    ogr.OgretmenId = dr["OgretmenId"].ToString();
                    ogr.Adi = dr["Adi"].ToString();
                    ogr.Soyadi = dr["Soyadi"].ToString();
                    ogr.Tc = dr["Tc"].ToString();
                }
                dr.Close();
                return ogr;
            }

            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex);
            }


        }
        public bool OgretmenSil(String Tc)
        {
            try
            {
                var p = new SqlParameter[] {
                   new SqlParameter("@Tc", Tc)
                };
                return hlp.ExecuteNonQuery("DELETE FROM tblOgretmen WHERE OgretmenTc = @Tc", p) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex.Message, ex);
            }
        }

        public bool OgretmenGuncelle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p =
                {
                new SqlParameter("@Ad",ogr.Adi),
                new SqlParameter("@Soyad", ogr.Soyadi),
                new SqlParameter("@Tc",ogr.Tc)
                };

                return hlp.ExecuteNonQuery("Update tblOgretmen set Adi=@Ad,Soyadi=@Soyad where Tc=@Tc", p) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex);
            }
        }
    }
}
