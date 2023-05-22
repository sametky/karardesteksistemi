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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int depo4;
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=4", baglan);
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
                depo4 = depo4+1;
                label1.Text = depo4.ToString();

                Form5 frm5 = new Form5();
                frm5.depo5 = depo4;
                frm5.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo4 = depo4+2;
                label1.Text = depo4.ToString();

                Form5 frm5 = new Form5();
                frm5.depo5 = depo4;
                frm5.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo4 = depo4+3;
                label1.Text = depo4.ToString();

                Form5 frm5 = new Form5();
                frm5.depo5 = depo4;
                frm5.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
