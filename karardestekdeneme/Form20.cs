using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace karardestekdeneme
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depo20;
        private void Form20_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=20", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            label1.Visible = false;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                depo20 = depo20 + 1;
                label1.Text = depo20.ToString();

                Form21 frm21 = new Form21();
                frm21.depo21 = depo20;
                frm21.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo20 = depo20 + 3;
                label1.Text = depo20.ToString();


                Form21 frm21 = new Form21();
                frm21.depo21 = depo20;
                frm21.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo20 = depo20 + 2;
                label1.Text = depo20.ToString();


                Form21 frm21 = new Form21();
                frm21.depo21 = depo20;
                frm21.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
