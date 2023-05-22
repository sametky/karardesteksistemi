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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depo14;
        private void Form14_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=14", baglanti);
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
                depo14 = depo14 + 1;
                label1.Text = depo14.ToString();

                Form15 frm15 = new Form15();
                frm15.depo15 = depo14;
                frm15.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo14 = depo14 + 2;
                label1.Text = depo14.ToString();


                Form15 frm15 = new Form15();
                frm15.depo15 = depo14;
                frm15.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo14 = depo14 + 3;
                label1.Text = depo14.ToString();


                Form15 frm15 = new Form15();
                frm15.depo15 = depo14;
                frm15.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
