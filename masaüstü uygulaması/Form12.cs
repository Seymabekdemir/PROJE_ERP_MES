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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CihazAramaYap()
        {
            string filtre = txtAramaSiparisSil.Text.Trim();

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


                dataGridViewSiparisSil.DataSource = dataTable;
                dataGridViewSiparisSil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSiparisSil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewSiparisSil.ReadOnly = true;
            }
        }
        private void txtAramaSiparisSil_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void dataGridViewSiparisSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSiparisSil.CellClick += dataGridViewSiparisSilNew_CellClick;
        }

        public void dataGridViewSiparisSilNew_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSiparisSil.Rows[e.RowIndex];
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
                string CihazId = row.Cells["CihazId"].Value.ToString();

                // İlgili hücreleri textboxlara yaz
                textBoxSilSiparisNo.Text = row.Cells["SiparisNo"].Value.ToString();
                textBoxSilSiparisAcıklaması.Text = row.Cells["SiparisAcıklaması"].Value.ToString();
                textBoxSilSiparisOT.Text = row.Cells["SiparisOT"].Value.ToString();
                textBoxSilSiparisTuru.Text = row.Cells["SiparisTuru"].Value.ToString();
                textBoxSilSiparisSTT.Text = row.Cells["SiparisSTT"].Value.ToString();
                textBoxSilSiparisMiktarı.Text = row.Cells["SiparisMiktarı"].Value.ToString();
                textBoxSilSiparisVeren.Text = row.Cells["Olusturan"].Value.ToString();
                textBoxSilSiparisAdı.Text = row.Cells["CihazAdı"].Value.ToString();
                textBoxSilSiparisDurumu.Text = row.Cells["SiparisDurumu"].Value.ToString();
                textBoxSilCihazId.Text = row.Cells["CihazId"].Value.ToString();

            }

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void textBoxSilSiparisOT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSilSiparisMiktarı_TextChanged(object sender, EventArgs e)
        {

        }

        private void TumTextBoxlariTemizle()
        {
            textBoxSilSiparisNo.Clear();
            textBoxSilSiparisAcıklaması.Clear();
            textBoxSilSiparisOT.Clear();
            textBoxSilSiparisTuru.Clear();
            textBoxSilSiparisSTT.Clear();
            textBoxSilSiparisMiktarı.Clear();
            textBoxSilSiparisVeren.Clear();
            textBoxSilSiparisAdı.Clear();
            textBoxSilSiparisDurumu.Clear();
            textBoxSilCihazId.Clear();
        }

        private void btnSilSiparisBilgilerini_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSilSiparisNo.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz siparişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bu siparişi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
                {
                    try
                    {
                        baglanti.Open();
                        string query = "DELETE FROM Siparisler WHERE SiparisNo = @siparisNo";
                        SqlCommand komut = new SqlCommand(query, baglanti);
                        komut.Parameters.AddWithValue("@siparisNo", textBoxSilSiparisNo.Text.Trim());

                        int etkilenenSatir = komut.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CihazAramaYap(); // tabloyu güncelle
                            TumTextBoxlariTemizle();

                        }
                        else
                        {
                            MessageBox.Show("Sipariş silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}