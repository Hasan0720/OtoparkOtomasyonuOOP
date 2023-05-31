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
    public partial class frmAraçOtoparkÇıkışı : Form
    {
        public frmAraçOtoparkÇıkışı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True");

        private void frmAraçOtoparkÇıkışı_Load(object sender, EventArgs e)
        {
            DoluParkYerleri();
            Plakalar();
            timer1.Enabled = true;
        }

        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araç_otopark_kaydı", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboPlaka.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araçdurumu where durumu = 'DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araç_otopark_kaydı where plaka = '" + comboPlaka.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text = read["parkyeri"].ToString();
            }
            baglanti.Close();
        }

        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araç_otopark_kaydı where parkyeri = '" + comboParkYeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtRenk.Text = read["renk"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                lblGirişTarihi.Text = read["tarih"].ToString();
            }
            baglanti.Close();
            DateTime giriş, çıkış;
            giriş = DateTime.Parse(lblGirişTarihi.Text);
            çıkış = DateTime.Parse(lblÇıkışTarihi.Text);
            TimeSpan süreFarkı;
            süreFarkı = çıkış - giriş;
            lblSüre.Text = süreFarkı.TotalHours.ToString("0.00");
            lblToplamTutar.Text = (double.Parse(lblSüre.Text) * (4.5)).ToString("0.00  TL");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblÇıkışTarihi.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboParkYeri.Text == String.Empty || comboPlaka.Text == String.Empty)
            {
                MessageBox.Show("Lütfen boş bıraktığınız alanları doldurunuz.");
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from araç_otopark_kaydı where plaka = '" + txtPlaka.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update araçdurumu set durumu = 'BOŞ'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Seçmiş olduğunuz aracın otoparktan çıkışı yapılmıştır.");
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    comboPlaka.Text = "";
                    txtParkYeri.Text = "";
                    comboParkYeri.Text = "";
                }
            }
            comboPlaka.Items.Clear();
            comboParkYeri.Items.Clear();
            DoluParkYerleri();
            Plakalar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 32 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void comboParkYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 32 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
    }
}
