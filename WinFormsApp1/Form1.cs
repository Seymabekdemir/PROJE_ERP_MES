namespace ERP_MES;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    //ana menüdeki cihazlar butonuna tıklandığında Form2 açılacak
    private void button1_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.Show();
    }

    // burada da ana menüdeki siparişler butonuna tıklandığında Form3 açılacak
    private void button2_Click(object sender, EventArgs e)
    {
        Form3 form3 = new Form3();
        form3.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
