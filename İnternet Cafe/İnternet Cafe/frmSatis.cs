using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternet_Cafe
{
    public partial class frmSatis : Form
    {
        
        public frmSatis()
        {
            InitializeComponent();

        }
        Button btn;
       

        private void SecileneGore(object sender, MouseEventArgs e)
        {
           btn = sender as Button;
            if (btn.BackColor==Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible=false;

            }
            if (btn.BackColor==Color.LightGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }
            
          

        }
        RadioButton radio;
        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'internetCafe2DataSet1.TBLSaatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLSaatUcretiTableAdapter1.Fill(this.internetCafe2DataSet1.TBLSaatUcreti);
            // TODO: Bu kod satırı 'internetCafe2DataSet.TBLSaatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLSaatUcretiTableAdapter.Fill(this.internetCafe2DataSet.TBLSaatUcreti);
            radioButtonSuresiz.Checked = true;
            Yenile();
            comboBosMasalar.Text = "";
            timer1.Start();


         
        }
        public void Yenile()
        {
            //anlatır mısın sesim geliyor mu ? yazar mısın anlamında tmm

            Veritabani.SepetListele(dataGridView1);
            Veritabani.ListviewdeKayitlariGoster(listView1);
            Veritabani.ComboyaBosMasaGetir(comboBosMasalar);




            foreach (Control item in pnlTables.Controls)
            {
                if (item is Button)
                {

                
                    if (item.Name != btnMasaAc.Name)
                    {
                        Console.WriteLine("btnmasa girdi");
                        Veritabani.Baglantı.Open();
                        SqlCommand komut = new SqlCommand("select *from TBLMasalar", Veritabani.Baglantı);
                        SqlDataReader dr = komut.ExecuteReader();
                       
                        while (dr.Read())
                        {
                            string durum = dr["Durumu"].ToString();
                            string masa = dr["Masalar"].ToString();
                            string ad = item.Tag.ToString();

                            if (masa != ad) continue;

                            if(durum == "BOŞ")
                            {
                                item.BackColor = Color.LightGreen;
                                Console.WriteLine("Yeşil girdi");
                            }
                            else if (durum == "DOLU")
                            {
                                item.BackColor = Color.OrangeRed;
                                Console.WriteLine("Kırmızı girdi");
                            }


                            //if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
                            //{
                            //    item.BackColor = Color.LightGreen;
                            //    Console.WriteLine("Yeşil girdi");
                            //}
                            //else if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            //{
                            //    item.BackColor = Color.OrangeRed;
                            //    Console.WriteLine("Kırmızı girdi");
                            //}



                        }
                        Veritabani.Baglantı.Close();
                    }
                }

            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (Kullanici.KullaniciID== 1)
            {
                string sqlsorgu = "insert into tblsepet(masaID,masa,acilisturu,baslangic,tarih) " + "values('" + comboBosMasalar.Text.Substring(5) + "','" + comboBosMasalar.Text + "'" +
                      ",'" + radio.Text + "',@Baslangic,@Bitis)";
                SqlCommand komut = new SqlCommand();


                komut.Parameters.AddWithValue("@Baslangic", DateTime.Now);
                komut.Parameters.AddWithValue("@Bitis", DateTime.Now);

                Veritabani.ESG(komut, sqlsorgu);
                MessageBox.Show(comboBosMasalar.Text.Substring(5) + " nolu masa açıldı..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Yenile();
                radioButtonSuresiz.Checked = true;
            }
            else
            {
                MessageBox.Show("Böyle bir Yetkiniz Bulunmuyor.!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void frmSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                if (comboSaatUcreti.Text != "")
                {
                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                    double saatfarki2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(comboSaatUcreti.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["BitisSaati"].Value = BitisTarihi;

                }
                if (comboSaatUcreti.Text == "")
                {
                    MessageBox.Show("önce saat ücreti belirtilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value != null)
                {
                    frmMasaKapat frm = new frmMasaKapat();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txtMasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_Masa"].Value.ToString();
                    frm.txtAcilisTuru.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    frm.txtBaslamaSaati.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                    frm.txtBitisSaati.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                    frm.txtSaatUcreti.Text = comboSaatUcreti.Text;
                    frm.txtSure.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                    frm.txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.txtTarih.Text = dataGridView1.CurrentRow.Cells["_Tarih"].Value.ToString();

                    frm.ShowDialog();

                }
                else if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value==null)
                {
                    MessageBox.Show("Önce Hesaplama Yapılmalıdır.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

            }
        }
        string istek = "";

        private void yöneticiÇağırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Yöneticiyi Çağırıyor";
            //Istekler();
                  
        }
        private void Istekler() 
        {
            var masaId = Convert.ToInt16(btn.Tag);
           

            string sql = $@"INSERT INTO tblhareketler (KullaniciID,MasaID,Masa,İstekTuru,Aciklama,Tarih)
           VALUES ({Kullanici.KullaniciID}, '{masaId}', '{btn.Text}','{istek}', 'Yapılmadı', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";

            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            Veritabani.ListviewdeKayitlariGoster(listView1);

           
        }

        private void süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            istek = "Süresiz masa Acma İsteği Gönderdi";
            Istekler();

        }

        private void masaDeğiştirmeİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Masa değiştirme İsteği Gönderdi";
            ////Istekler();

        }
        ToolStripMenuItem item;
        private void SureliIstekSecilirse(object sender, EventArgs e)
        {
            item = new ToolStripMenuItem();
            istek = item.Text+" dk süre ile masa açma isteği gönderdi.";
            //Istekler();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 29)
            {
                if (comboSaatUcreti.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime BitisTarihi = DateTime.Now;
                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure"].Value = saatfarki2.ToString("0.00");
                        double toplamtutar = saatfarki2 * double.Parse(comboSaatUcreti.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi; 
                    }

                }
                if (comboSaatUcreti.Text == "")
                {
                    MessageBox.Show("önce saat ücreti belirtilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void btnMasaDegistir_Click(object sender, EventArgs e)
        {
            int SepetID = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            int MasaID= int.Parse(dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString());
            string sql = "update tblsepet set MasaID='"+int.Parse(comboBosMasalar.Text.Substring(5))+"',Masa='"+comboBosMasalar.Text+"' where SepetID='"+SepetID+ "'";
            SqlCommand cmd= new SqlCommand();
            Veritabani.ESG(cmd,sql);
            ////////////////////////
            string sql2 = "update tblmasalar set durumu='BOŞ' where MasaID='"+MasaID+"' ";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sql2);
            /////////////////////////
            string sql3 = "update tblmasalar set durumu ='DOLU' where MasaID= '"+int.Parse(comboBosMasalar.Text.Substring(5))+"'";
            SqlCommand cmd3 = new SqlCommand();
            Veritabani.ESG(cmd3, sql3);
            Yenile();
            MessageBox.Show("MAsa Değiştirme İşlemi Başarılı", "Bilgi" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value!=null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double Acilisturu = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());

                        if (Acilisturu - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                        }
                    }

                }

            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            FrmSatıslarıListele frm = new FrmSatıslarıListele();
            frm.Enabled = true;
            frm.ShowDialog();
        }

     
    }

 }


