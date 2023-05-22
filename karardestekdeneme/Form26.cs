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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depolama;

        private void Form26_Load(object sender, EventArgs e)
        {
            label3.Text = depolama.ToString();
            label3.Visible = false;
            if (label3.Text == "40")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=40", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "41")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=41", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "42")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=42", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "43")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=43", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "44")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=44", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "45")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=45", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "46")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=46", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "47")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=47", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "48")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=48", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "49")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=49", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "50")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=50", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();

            }
            else if (label3.Text == "51")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=51", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "52")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=52", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "53")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=53", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "54")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=54", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "55")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=55", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "56")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=56", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "57")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=57", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "58")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=58", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "59")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=59", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "60")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=60", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "61")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=61", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "62")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=62", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "63")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=63", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "64")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=64", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "65")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=65", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "66")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=66", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "67")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=67", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "68")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=68", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "69")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=69", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "70")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=70", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "71")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=71", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
            else if (label3.Text == "72")
            {
                bagla.Open();
                SqlCommand komut = new SqlCommand("select * from bilgisayarlar where pc_puan=72", bagla);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bagla.Close();
            }
        }

       
    }
}

