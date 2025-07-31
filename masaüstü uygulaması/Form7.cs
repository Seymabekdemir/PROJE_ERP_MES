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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        private void txtAramaCihazSil_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();

        }

        private void dataGridViewCihazSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCihazSil.CellClick += dataGridViewCihazSil_CellClick;
        }
        public void dataGridViewCihazSil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCihazSil.Rows[e.RowIndex];
                // Seçilen satırdaki hücre değerlerini al
                string cihazId = row.Cells["CihazId"].Value.ToString();
                string cihazAdi = row.Cells["CihazAdı"].Value.ToString();
                string cihazAciklaması = row.Cells["CihazAçıklaması"].Value.ToString();
                string cihazTuru = row.Cells["CihazTuru"].Value.ToString();

                // İlgili hücreleri textboxlara yaz
                textBoxSilCihazId.Text = row.Cells["CihazId"].Value.ToString();
                textBoxSilCihazAdi.Text = row.Cells["CihazAdı"].Value.ToString();
                textBoxSilCihazTuru.Text = row.Cells["CihazTuru"].Value.ToString();
                textBoxSilCihazAciklamasi.Text = row.Cells["CihazAçıklaması"].Value.ToString();
            }

        }

        private void CihazAramaYap()
        {
            string filtre = txtAramaCihazSil.Text.Trim();

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


                dataGridViewCihazSil.DataSource = dataTable;
                dataGridViewCihazSil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCihazSil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewCihazSil.ReadOnly = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void textBoxSilCihazId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSilCihazAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSilCihazTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSilCihazAciklamasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // ID boşsa işlem yapma
            if (string.IsNullOrWhiteSpace(textBoxSilCihazId.Text))
            {
                MessageBox.Show("Lütfen silinecek cihazı seçiniz.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bu cihazı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    string query = "DELETE FROM Cihazlar WHERE CihazId = @id";
                    SqlCommand command = new SqlCommand(query, baglanti);
                    command.Parameters.AddWithValue("@id", textBoxSilCihazId.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    baglanti.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cihaz başarıyla silindi.");
                        CihazAramaYap(); // tabloyu güncelle
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }
        

        private void Form7_Load(object sender, EventArgs e)
        {
            CihazAramaYap();
        }
    }
}
