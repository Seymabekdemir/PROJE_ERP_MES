using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace ERP_MES
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        //Kaydet butonuna tıklandığında çalışacak metot
        private void btnSiparisOluştur_Click(object sender, EventArgs e)
        {
            if (comboBoxDurumu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sipariş durumu seçiniz.");
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("INSERT INTO Siparisler (SiparisNo,SiparisAcıklaması," +
                    "SiparisOT,SiparisTuru,SiparisDurumu,SiparisSTT,SiparisMiktarı,Olusturan,CihazId) VALUES " +
                    "(@no,@aciklama, @ot,@tur,@durum, @stt,@miktar,@olusturan,@id)", baglanti);

                //şimdi parametreleri tanımlıcam
                sqlKomut.Parameters.AddWithValue("@no", textBoxSiparisNo.Text);
                sqlKomut.Parameters.AddWithValue("@aciklama", textBoxSiparisAcıklamasi.Text);
                sqlKomut.Parameters.AddWithValue("@ot", dateTimePickerSiparisOT.Value);
                sqlKomut.Parameters.AddWithValue("@tur", comboBoxSiparisTuru.SelectedItem.ToString());
                sqlKomut.Parameters.AddWithValue("@durum", comboBoxDurumu.SelectedItem.ToString());
                sqlKomut.Parameters.AddWithValue("@stt", dateTimePickerSiparisSTT.Value);
                sqlKomut.Parameters.AddWithValue("@miktar", numericUpDownSiparisMiktarı.Value);
                sqlKomut.Parameters.AddWithValue("@olusturan", textBoxSiparisinSahibi.Text);
                sqlKomut.Parameters.AddWithValue("@id", comboBoxCihazId.SelectedValue);
                // ExecuteNonQuery metodu ile sorguyu çalıştırıyorum
                sqlKomut.ExecuteNonQuery();
                MessageBox.Show("Sipariş başarıyla oluşturuldu :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası oluştu işleminiz gerçekleştirilemedi: " + ex.Message);
            }
            finally
            {
                //veritabanı bağlantısını kapatıyorum
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=MESDb;Trusted_Connection=True;";
            string query = "SELECT CihazId FROM Cihazlar;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxCihazId.DataSource = dt;
                comboBoxCihazId.DisplayMember = "CihazId";  // Ekranda gözükecek sütun
                comboBoxCihazId.ValueMember = "CihazId";    // Arka planda tutulacak değer
            }

        }

        private void comboBoxSiparisTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCihazId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCihazId.SelectedIndex <= 0)
            {
                textBoxSiparisNo.Text = "";
                return;
            }
            string cihazId = comboBoxCihazId.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MESDb;Trusted_Connection=True;"))
            {
                conn.Open();
                string query = "SELECT MAX(SiparisNo) FROM Siparisler WHERE CihazId = @cihazId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cihazId", cihazId);

                object result = cmd.ExecuteScalar();

                string yeniSiparisNo;

                if (result != DBNull.Value && result != null)
                {
                    string maxSiparisNo = result.ToString();
                    string[] parcalar = maxSiparisNo.Split('.');

                    if (parcalar.Length == 2 && parcalar[0] == cihazId)
                    {
                        int sayi = int.Parse(parcalar[1]);
                        yeniSiparisNo = cihazId + "." + (sayi + 1);
                    }
                    else
                    {
                        yeniSiparisNo = cihazId + ".1";
                    }
                }
                else
                {
                    yeniSiparisNo = cihazId + ".1";
                }

                textBoxSiparisNo.Text = yeniSiparisNo;
            }
        }
    }
}