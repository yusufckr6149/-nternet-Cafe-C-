using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace İnternet_Cafe
{
    internal class Veritabani
    {
        public static SqlConnection  Baglantı = new SqlConnection("Data Source=YUSUF;Initial Catalog=InternetCafe2;Integrated Security=True;Encrypt=False");
        public static DataTable SepetListele(DataGridView gridview)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tblsepet ", Baglantı);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            return tbl;
            

        }
        public static DataTable Listele(DataGridView gridview, string sorgu)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu , Baglantı);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            return tbl;


        }
        public static DataTable ComboyaBosMasaGetir(ComboBox combo)
        {
            Baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from TBLMasalar where durumu='BOŞ'", Baglantı);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            Baglantı.Close();
            return tbl;
        }
        public static void ESG(SqlCommand command, string sorgu)
        {
            //buraya nereden geliyor
            Baglantı.Open ();
            command.Connection = Baglantı;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            Baglantı.Close();

        }
        public static SqlDataReader ListviewdeKayitlariGoster(ListView list)
        {
            list.Items.Clear ();
            Baglantı.Open();
            SqlCommand cmd = new SqlCommand("select *from tblhareketler where tarih>=@Tarih",Baglantı);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());
                list.Items.Add(ekle);

            }
            Baglantı.Close();   
            return dr;

        }
    }
}
