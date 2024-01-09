using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using OkulApp.DAL;
using System.ComponentModel.Design;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        private Helper hlp;
        public OgrenciBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgrenciKaydet(Ogrenci ogr)
        {
            try
            {
               
                var p = new SqlParameter[] {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.Numara)
            };
                return hlp.ExecuteNonQuery("Insert into tblOgrenci values(@Ad,@Soyad,@Numara)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("Select OgrenciID,Ad,Soyad,Numara from tblOgrenci where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciID"]);
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();

                }
                dr.Close();
                return ogr;
            }
            catch (Exception ex)
            {

                throw new Exception("Hata: " + ex);
            }
        }
        public bool OgrenciSil(int Ogrenciid)
        {
            try
            {
            
                var p = new SqlParameter[] {
                   new SqlParameter("@Id", Ogrenciid)
                 };
                return hlp.ExecuteNonQuery("DELETE FROM tblOgrenci WHERE OgrenciID = @Id", p) > 0;
            }

            catch (Exception ex)
            {
                throw new Exception("UYARI! Hata: " + ex.Message, ex);
            }
        }
        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@OgrenciId",ogr.Ogrenciid)};

               
                return hlp.ExecuteNonQuery("Update tblOgrenci set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex);
            }
        }
    }
}

