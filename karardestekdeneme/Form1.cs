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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depo1;
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            label1.Visible = false;



            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                depo1 = depo1 + 3;
                label1.Text = depo1.ToString();

                Form2 frm2 = new Form2();
                frm2.depo2 = depo1;
                frm2.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo1 = depo1 + 2;
                label1.Text = depo1.ToString();


                Form6 frm6 = new Form6();
                frm6.depo6 = depo1;
                frm6.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo1 = depo1 + 1;
                label1.Text = depo1.ToString();


                Form6 frm6 = new Form6();
                frm6.depo6 = depo1;
                frm6.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }

        }
    }
}
        
