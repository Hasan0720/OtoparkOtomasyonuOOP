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
using System.Data.Common;

namespace Otopark_Otomasyon_Sistem_OOP_Projesi
{
    public partial class frmAraçOtoparkKaydı : Form
    {
        public frmAraçOtoparkKaydı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True");

        private void frmAraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            BoşAraçlar();   
            Marka();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from araç_otopark_kaydı", baglanti);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araçdurumu WHERE durumu = 'BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == String.Empty || txtAd.Text == String.Empty || txtSoyad.Text == String.Empty || txtTelefon.Text == String.Empty || txtEmail.Text == String.Empty
              || txtPlaka.Text == String.Empty || comboMarka.Text == String.Empty || comboSeri.Text == String.Empty || txtRenk.Text == String.Empty || comboParkYeri.Text == String.Empty)
            {
                MessageBox.Show("Lütfen boş bıraktığınız alanları doldurunuz."); 
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into araç_otopark_kaydı(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@seri", comboSeri.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", comboParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update araçdurumu set durumu = 'DOLU' where parkyeri = '"+comboParkYeri.SelectedItem+"'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç kaydı başarıyla oluşturuldu.", "Kayıt");
            comboParkYeri.Items.Clear();
            BoşAraçlar();
            comboMarka.Items.Clear();
            Marka();
            comboSeri.Items.Clear();

            foreach (Control item in grupKişi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grupAraç.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grupAraç.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }
            
        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog(); 
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seribilgileri where marka = '" + comboMarka.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRenk_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 32 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void comboSeri_KeyPress(object sender, KeyPressEventArgs e)
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
