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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int depo2;
        SqlConnection baglanti=new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=2", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            label1.Visible=false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                depo2 = depo2+3;
                label1.Text = depo2.ToString();

                Form3 frm3 = new Form3();
                frm3.depo3=depo2;
                frm3.Show();
                this.Hide();


            }
            else if(checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo2 = depo2+2;
                label1.Text = depo2.ToString();

                Form3 frm3 = new Form3();
                frm3.depo3=depo2;
               frm3.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo2 = depo2+1;
                label1.Text = depo2.ToString();

                Form3 frm3 = new Form3();
                frm3.depo3 =depo2;
                frm3.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }

        }
    }
}
