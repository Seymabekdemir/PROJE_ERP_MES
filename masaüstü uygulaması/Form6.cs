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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        private void dataGridViewCihazGoruntule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCihazGoruntule.CellClick += dataGridViewCihazGoruntule_CellClick;
        }

        public void dataGridViewCihazGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCihazGoruntule.Rows[e.RowIndex];
                // Seçilen satırdaki hücre değerlerini al
                string cihazId = row.Cells["CihazId"].Value.ToString();
                string cihazAdi = row.Cells["CihazAdı"].Value.ToString();
                string cihazAciklaması = row.Cells["CihazAçıklaması"].Value.ToString();
                string cihazTuru = row.Cells["CihazTuru"].Value.ToString();

                // İlgili hücreleri textboxlara yaz
                textBoxGuncelleCihazId.Text = row.Cells["CihazId"].Value.ToString();
                textBoxGuncelleCihazAdi.Text = row.Cells["CihazAdı"].Value.ToString();
                textBoxGuncelleCihazTuru.Text = row.Cells["CihazTuru"].Value.ToString();
                textBoxGuncelleCihazAciklamasi.Text = row.Cells["CihazAçıklaması"].Value.ToString();
            }

        }
        private void CihazAramaYap()
        {
            string filtre = txtAramaCihazGoruntule.Text.Trim();

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {

                baglanti.Open();
                string query;

                if (string.IsNullOrEmpty(filtre))
                {
                    query = "SELECT * FROM Cihazlar";
                }
                else
                {
                    query = "SELECT * FROM Cihazlar WHERE CihazAdı LIKE @arama OR CihazTuru LIKE @arama";
                }
                SqlCommand command = new SqlCommand(query, baglanti);
                if (!string.IsNullOrEmpty(filtre))
                {
                    command.Parameters.AddWithValue("@arama", "%" + filtre + "%");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                dataGridViewCihazGoruntule.DataSource = dataTable;
                dataGridViewCihazGoruntule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCihazGoruntule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCihazGoruntule.ReadOnly = true;
            }
        }

        private void txtAramaCihazGoruntule_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGoruntuleCihazId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGoruntuleCihazAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGoruntuleCihazTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGoruntuleCihazAciklamasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {
                try
                {
                    baglanti.Open();
                    string query ="UPDATE Cihazlar SET CihazAdı = @ad, CihazAçıklaması = @aciklama, CihazTuru = @tur WHERE CihazId = @id";
                    SqlCommand command = new SqlCommand(query, baglanti);

                    command.Parameters.AddWithValue("@id", textBoxGuncelleCihazId.Text);
                    command.Parameters.AddWithValue("@ad", textBoxGuncelleCihazAdi.Text);
                    command.Parameters.AddWithValue("@tur", textBoxGuncelleCihazTuru.Text);
                    command.Parameters.AddWithValue("@aciklama", textBoxGuncelleCihazAciklamasi.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cihaz başarıyla güncellendi.");

                    CihazAramaYap(); // Güncelleme sonrası verileri tekrar yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
