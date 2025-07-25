using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ERP_MES
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        //kaydet butonuna tıklandığında çalışacak metoT
        private void buttonCihazEkle_Click(object sender, EventArgs e)
        {
            //try-catch bloğu ile girilen verilerin veritabanına kaydedilmesini sağlıcam

            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("INSERT INTO Cihazlar (CihazId, CihazAdı, CihazAçıklaması, CihazTuru) VALUES (@id, @ad, @aciklama, @tur)", baglanti);
                //parametreleri tanımlıyorum

                sqlKomut.Parameters.AddWithValue("@id", textBoxCihazId.Text);
                sqlKomut.Parameters.AddWithValue("@ad", textBoxCihazAdi.Text);
                sqlKomut.Parameters.AddWithValue("@tur", textBoxCihazTuru.Text);
                sqlKomut.Parameters.AddWithValue("@aciklama", textBoxCihazAcıklaması.Text);

                sqlKomut.ExecuteNonQuery();
                MessageBox.Show("Cihaz başarıyla eklendi:)");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCihazAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
