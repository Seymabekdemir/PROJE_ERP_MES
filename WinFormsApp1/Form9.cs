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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            CihazAramaYap();
        }


        private void CihazAramaYap()
        {
            string filtre = textBoxAramaSiparis.Text.Trim();

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {

                baglanti.Open();
                string query;

                if (string.IsNullOrEmpty(filtre))
                {
                    query = "SELECT * FROM Siparisler";
                }
                else
                {
                    query = "SELECT * FROM Siparisler WHERE CihazId LIKE @arama OR Olusturan LIKE @arama";
                }
                SqlCommand command = new SqlCommand(query, baglanti);
                if (!string.IsNullOrEmpty(filtre))
                {
                    command.Parameters.AddWithValue("@arama", "%" + filtre + "%");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                dataGridViewSiparisDurumTakip.DataSource = dataTable;
                dataGridViewSiparisDurumTakip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSiparisDurumTakip.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewSiparisDurumTakip.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAramaSiparis_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void dataGridViewSiparisDurumTakip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSiparisDurumTakip.CellClick += dataGridViewSiparisDurumTakip_CellClick;
        }

        public void dataGridViewSiparisDurumTakip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSiparisDurumTakip.Rows[e.RowIndex];
                // Seçilen satırdaki hücre değerlerini al
                string SiparisOT = row.Cells["SiparisOT"].Value.ToString();
                string SiparisSTT = row.Cells["SiparisSTT"].Value.ToString();


                // İlgili hücreleri textboxlara yaz
                textBoxDurumOT.Text = row.Cells["SiparisOT"].Value.ToString();
                textBoxDurumSTT.Text = row.Cells["SiparisSTT"].Value.ToString();
                
            }

        
    }
    }
}
