using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ERP_MES
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için SqlConnection nesnesi oluşturdum.
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            CihazAramaYap();    
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

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
                textBoxGoruntuleCihazId.Text = row.Cells["CihazId"].Value.ToString();
                textBoxGoruntuleCihazAdi.Text = row.Cells["CihazAdı"].Value.ToString();
                textBoxGoruntuleCihazTuru.Text = row.Cells["CihazTuru"].Value.ToString();
                textBoxGoruntuleCihazAciklamasi.Text = row.Cells["CihazAçıklaması"].Value.ToString();
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
    }
}
