﻿using System;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-R3D59GR9;Initial Catalog=KARARDESTEK;Integrated Security=True");
        public int depo15;
        private void Form15_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select soru_tanimi from sorular where soru_id=15", baglanti);
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
                depo15 = depo15 + 1;
                label1.Text = depo15.ToString();

                Form16 frm16 = new Form16();
                frm16.depo16 = depo15;
                frm16.Show();
                this.Hide();


            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                depo15 = depo15 + 2;
                label1.Text = depo15.ToString();


                Form16 frm16 = new Form16();
                frm16.depo16 = depo15;
                frm16.Show();
                this.Hide();

            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                depo15 = depo15 + 3;
                label1.Text = depo15.ToString();


                Form16 frm16 = new Form16();
                frm16.depo16 = depo15;
                frm16.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Lütfen bir seçeneği işaretleyiniz.");
            }
        }
    }
}
