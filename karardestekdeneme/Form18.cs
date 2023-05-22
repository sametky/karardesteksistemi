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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depo18;
        private void Form18_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=18", baglanti);
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
                depo18 = depo18 + 1;
                label1.Text = depo18.ToString();

                Form19 frm19 = new Form19();
                frm19.depo19 = depo18;
                frm19.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo18 = depo18 + 2;
                label1.Text = depo18.ToString();


                Form19 frm19 = new Form19();
                frm19.depo19 = depo18;
                frm19.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo18 = depo18 + 3;
                label1.Text = depo18.ToString();


                Form19 frm19 = new Form19();
                frm19.depo19 = depo18;
                frm19.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
