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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int depo3;
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=3", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            label1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                depo3 = depo3+3;
                label1.Text = depo3.ToString();

                Form4 frm4 = new Form4();
                frm4.depo4=depo3;
                frm4.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo3 = depo3+2;
                label1.Text = depo3.ToString();

                Form4 frm4 = new Form4();
                frm4.depo4 =depo3;
                frm4.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo3 = depo3+1;
                label1.Text = depo3.ToString();

                Form4 frm4 = new Form4();
                frm4.depo4=depo3;
                frm4.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
