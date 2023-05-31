using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyon_Sistem_OOP_Projesi
{
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True");

        private void frmSeri_Load(object sender, EventArgs e)
        {
            Marka();
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == String.Empty || textBox1.Text == String.Empty)
            { 
                MessageBox.Show("Lütfen boş bıraktığınız alanları doldurunuz.");
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seribilgileri(marka,seri) values('"+comboBox1.Text+"','" + textBox1.Text + "') ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Markaya bağlı araç serisi eklendi.");
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Marka();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
    }
}
