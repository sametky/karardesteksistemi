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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int depo5;
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=5", baglan);
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
                depo5 = depo5 + 3;
                label1.Text = depo5.ToString();

                Form6 frm6 = new Form6();
                frm6.depo6 = depo5;

                frm6.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo5 = depo5 + 2;
                label1.Text = depo5.ToString();

                Form6 frm6 = new Form6();
                frm6.depo6 = depo5;
                frm6.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo5 = depo5 + 1;
                label1.Text = depo5.ToString();


                Form6 frm6 = new Form6();
                frm6.depo6 = depo5;
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
