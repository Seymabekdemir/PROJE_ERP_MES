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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CihazAramaYap()
        {
            string filtre = textBoxDetayCihazArama.Text.Trim();

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {

                baglanti.Open();
                string query;                    

                    if (string.IsNullOrEmpty(filtre))
                    {
                        query = @"SELECT s.SiparisNo, s.SiparisAcıklaması, s.SiparisOT, s.SiparisTuru, 
                             s.SiparisDurumu, s.SiparisSTT, s.SiparisMiktarı, s.Olusturan, 
                             s.CihazId, c.CihazAdı 
                      FROM Siparisler s
                      INNER JOIN Cihazlar c ON s.CihazId = c.CihazId";
                    }
                    else
                    {
                        query = @"SELECT s.SiparisNo, s.SiparisAcıklaması, s.SiparisOT, s.SiparisTuru, 
                             s.SiparisDurumu, s.SiparisSTT, s.SiparisMiktarı, s.Olusturan, 
                             s.CihazId, c.CihazAdı 
                      FROM Siparisler s
                      INNER JOIN Cihazlar c ON s.CihazId = c.CihazId
                      WHERE s.CihazId LIKE @arama OR s.Olusturan LIKE @arama OR c.CihazAdı LIKE @arama";
                    }

                    SqlCommand command = new SqlCommand(query, baglanti);
                if (!string.IsNullOrEmpty(filtre))
                {
                    command.Parameters.AddWithValue("@arama", "%" + filtre + "%");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                dataGridViewDetaySiparisTablosu.DataSource = dataTable;
                dataGridViewDetaySiparisTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDetaySiparisTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewDetaySiparisTablosu.ReadOnly = true;
            }
        }
        private void textBoxDetayCihazArama_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();    
        }

        private void dataGridViewDetaySiparisTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDetaySiparisTablosu.CellClick += dataGridViewDetaySiparisTablosu_CellClick;
        }

        public void dataGridViewDetaySiparisTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDetaySiparisTablosu.Rows[e.RowIndex];
                // Seçilen satırdaki hücre değerlerini al
                string SiparisNo = row.Cells["SiparisNo"].Value.ToString();
                string SiparisAcıklaması = row.Cells["SiparisAcıklaması"].Value.ToString();
                string SiparisOT = row.Cells["SiparisOT"].Value.ToString();
                string SiparisTuru = row.Cells["SiparisTuru"].Value.ToString();
                string SiparisDurumu = row.Cells["SiparisDurumu"].Value.ToString(); 
                string SiparisSTT = row.Cells["SiparisSTT"].Value.ToString();
                string SiparisMiktarı = row.Cells["SiparisMiktarı"].Value.ToString();
                string Olusturan = row.Cells["Olusturan"].Value.ToString();
                string CihazAdı = row.Cells["CihazAdı"].Value.ToString();

                // İlgili hücreleri textboxlara yaz
                textBoxDetaySiparisNO.Text = row.Cells["SiparisNo"].Value.ToString();
                textBoxDetaySiparisAciklaması.Text = row.Cells["SiparisAcıklaması"].Value.ToString();
                textBoxDetaySiparisOT.Text = row.Cells["SiparisOT"].Value.ToString();
                textBoxDetaySiparisTuru.Text = row.Cells["SiparisTuru"].Value.ToString();
                textBoxDetaySiparisSTT.Text = row.Cells["SiparisSTT"].Value.ToString();
                textBoxDetaySiparisMiktarı.Text = row.Cells["SiparisMiktarı"].Value.ToString();
                textBoxDetaySiparisVeren.Text = row.Cells["Olusturan"].Value.ToString();
                textBoxDetayCihazAdı.Text = row.Cells["CihazAdı"].Value.ToString();
            }

        }

        private void textBoxDetaySiparisOT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetaySiparisSTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetaySiparisTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetaySiparisMiktarı_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetaySiparisVeren_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetayCihazAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetaySiparisAciklaması_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
