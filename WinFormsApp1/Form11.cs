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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void CihazAramaYap()
        {
            string filtre = txtAramaSiparisGuncelle.Text.Trim();

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


                dataGridViewSiparisGuncelle.DataSource = dataTable;
                dataGridViewSiparisGuncelle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSiparisGuncelle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewSiparisGuncelle.ReadOnly = true;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            CihazAramaYap();

            // TÜR
            comboBoxGuncelleSiparisTuru.Items.Clear();
            comboBoxGuncelleSiparisTuru.Items.AddRange(new string[] { "Üretim Siparişi", "Bakım Siparişi", "Standart Sipariş", "Acil Sipariş", "Tekrar Sipariş", "Numune Siparişi", "Özel Üretim Siparişi" });

            // DURUM
            comboBoxGuncelleSiparisDurumu.Items.Clear();
            comboBoxGuncelleSiparisDurumu.Items.AddRange(new string[] { "Beklemede", "Onaylandı", "Hazırlanıyor", "Üretimde", "Paketlendi", "Kargoya Verildi", "Teslim Edildi", "Tamamlandı", "İptal Edildi" });

            // CihazId ve CihazAdı veritabanından çek
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CihazId, CihazAdı FROM Cihazlar", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxGuncelleCihazId.DataSource = dt;
                comboBoxGuncelleCihazId.DisplayMember = "CihazId";   // Kullanıcıya görünen
                comboBoxGuncelleCihazId.ValueMember = "CihazId";      // Arka planda dönen
                comboBoxGuncelleCihazId.SelectedIndex = -1;
            }

            // Bu alanlara kullanıcı müdahale edemesin
            textBoxGuncelleSiparisAdı.ReadOnly = true;
            textBoxGuncelleSiparisNo.ReadOnly = true;

        }





        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MESDb;Integrated Security=True;Encrypt=True"))
            {
                try
                {
                    baglanti.Open();
                    string query = "UPDATE Siparisler SET SiparisNo=@SiparisNo, SiparisAcıklaması = @SiparisAcıklaması," +
                        " SiparisOT = @SiparisOT, SiparisTuru = @SiparisTuru, SiparisDurumu = @SiparisDurumu, SiparisSTT = @SiparisSTT, " +
                        "SiparisMiktarı = @SiparisMiktarı, Olusturan = @Olusturan WHERE CihazId = @CihazId";
                    SqlCommand command = new SqlCommand(query, baglanti);
                    command.Parameters.AddWithValue("@SiparisNo", textBoxGuncelleSiparisNo.Text);
                    command.Parameters.AddWithValue("@SiparisAcıklaması", textBoxGuncelleSiparisAcıklaması.Text);
                    command.Parameters.AddWithValue("@SiparisOT", textBoxGuncelleSiparisOT.Text);
                    command.Parameters.AddWithValue("@SiparisTuru", comboBoxGuncelleSiparisTuru.Text);
                    command.Parameters.AddWithValue("@SiparisDurumu", comboBoxGuncelleSiparisDurumu.Text);
                    command.Parameters.AddWithValue("@SiparisSTT", textBoxGuncelleSiparisSTT.Text);
                    command.Parameters.AddWithValue("@SiparisMiktarı", textBoxGuncelleSiparisMiktarı.Text);
                    command.Parameters.AddWithValue("@Olusturan", textBoxGuncelleSiparisVeren.Text);
                    command.Parameters.AddWithValue("@CihazId", comboBoxGuncelleCihazId.SelectedValue);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSilCihazTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSiparisGuncelle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSiparisGuncelle.CellClick += dataGridViewSiparisGuncelleNew_CellClick;
        }

        public void dataGridViewSiparisGuncelleNew_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSiparisGuncelle.Rows[e.RowIndex];
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
                textBoxGuncelleSiparisNo.Text = row.Cells["SiparisNo"].Value.ToString();
                textBoxGuncelleSiparisAcıklaması.Text = row.Cells["SiparisAcıklaması"].Value.ToString();
                textBoxGuncelleSiparisOT.Text = row.Cells["SiparisOT"].Value.ToString();
                comboBoxGuncelleSiparisTuru.Text = row.Cells["SiparisTuru"].Value.ToString();
                textBoxGuncelleSiparisSTT.Text = row.Cells["SiparisSTT"].Value.ToString();
                textBoxGuncelleSiparisMiktarı.Text = row.Cells["SiparisMiktarı"].Value.ToString();
                textBoxGuncelleSiparisVeren.Text = row.Cells["Olusturan"].Value.ToString();
                textBoxGuncelleSiparisAdı.Text = row.Cells["CihazAdı"].Value.ToString();
                comboBoxGuncelleSiparisDurumu.Text = row.Cells["SiparisDurumu"].Value.ToString();
                comboBoxGuncelleCihazId.SelectedValue = row.Cells["CihazId"].Value;

            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAramaSiparisGuncelle_TextChanged(object sender, EventArgs e)
        {
            CihazAramaYap();
        }

        private void comboBoxGuncelleCihazId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGuncelleCihazId.SelectedValue == null)
                return;

            string cihazId = comboBoxGuncelleCihazId.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=MESDb;Trusted_Connection=True;"))
            {
                conn.Open();

                // Sadece cihaz adı getir
                SqlCommand cmdAd = new SqlCommand("SELECT CihazAdı FROM Cihazlar WHERE CihazId = @id", conn);
                cmdAd.Parameters.AddWithValue("@id", cihazId);
                string cihazAdi = cmdAd.ExecuteScalar()?.ToString() ?? "";
                textBoxGuncelleSiparisAdı.Text = cihazAdi;
            }
        }

    }

}



    
