namespace Otopark_Otomasyon_Sistem_OOP_Projesi
{
    partial class frmAraçOtoparkKaydı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçOtoparkKaydı));
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grupKişi = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupAraç = new System.Windows.Forms.GroupBox();
            this.btnSeri = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupKişi.SuspendLayout();
            this.grupAraç.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(107, 78);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(183, 27);
            this.comboMarka.TabIndex = 0;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            this.comboMarka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboMarka_KeyPress);
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(107, 121);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(183, 27);
            this.comboSeri.TabIndex = 1;
            this.comboSeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboSeri_KeyPress);
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(107, 206);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(183, 27);
            this.comboParkYeri.TabIndex = 2;
            this.comboParkYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboParkYeri_KeyPress);
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(107, 164);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(183, 26);
            this.txtRenk.TabIndex = 3;
            this.txtRenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenk_KeyPress);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(107, 36);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(183, 26);
            this.txtPlaka.TabIndex = 4;
            this.txtPlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaka_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(99, 36);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(175, 26);
            this.txtTc.TabIndex = 5;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(99, 79);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(175, 26);
            this.txtAd.TabIndex = 6;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(99, 122);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(175, 26);
            this.txtSoyad.TabIndex = 7;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(99, 165);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(175, 26);
            this.txtTelefon.TabIndex = 8;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // grupKişi
            // 
            this.grupKişi.Controls.Add(this.label5);
            this.grupKişi.Controls.Add(this.label4);
            this.grupKişi.Controls.Add(this.label3);
            this.grupKişi.Controls.Add(this.label2);
            this.grupKişi.Controls.Add(this.label1);
            this.grupKişi.Controls.Add(this.txtTc);
            this.grupKişi.Controls.Add(this.txtAd);
            this.grupKişi.Controls.Add(this.txtEmail);
            this.grupKişi.Controls.Add(this.txtSoyad);
            this.grupKişi.Controls.Add(this.txtTelefon);
            this.grupKişi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupKişi.Location = new System.Drawing.Point(55, 59);
            this.grupKişi.Name = "grupKişi";
            this.grupKişi.Size = new System.Drawing.Size(296, 258);
            this.grupKişi.TabIndex = 10;
            this.grupKişi.TabStop = false;
            this.grupKişi.Text = "Kişi Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "E-mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC : ";
            // 
            // grupAraç
            // 
            this.grupAraç.Controls.Add(this.btnSeri);
            this.grupAraç.Controls.Add(this.btnMarka);
            this.grupAraç.Controls.Add(this.label10);
            this.grupAraç.Controls.Add(this.label9);
            this.grupAraç.Controls.Add(this.label8);
            this.grupAraç.Controls.Add(this.label7);
            this.grupAraç.Controls.Add(this.label6);
            this.grupAraç.Controls.Add(this.txtPlaka);
            this.grupAraç.Controls.Add(this.comboMarka);
            this.grupAraç.Controls.Add(this.comboSeri);
            this.grupAraç.Controls.Add(this.txtRenk);
            this.grupAraç.Controls.Add(this.comboParkYeri);
            this.grupAraç.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupAraç.Location = new System.Drawing.Point(404, 59);
            this.grupAraç.Name = "grupAraç";
            this.grupAraç.Size = new System.Drawing.Size(370, 258);
            this.grupAraç.TabIndex = 11;
            this.grupAraç.TabStop = false;
            this.grupAraç.Text = "Araç Bilgileri";
            // 
            // btnSeri
            // 
            this.btnSeri.Location = new System.Drawing.Point(308, 125);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(56, 23);
            this.btnSeri.TabIndex = 11;
            this.btnSeri.Text = "Ekle";
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(308, 81);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(56, 23);
            this.btnMarka.TabIndex = 10;
            this.btnMarka.Text = "Ekle";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Park Yeri : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renk : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Seri : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marka : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plaka : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(208, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(404, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 75);
            this.button2.TabIndex = 13;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(812, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 258);
            this.dataGridView1.TabIndex = 14;
            // 
            // frmAraçOtoparkKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1597, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grupAraç);
            this.Controls.Add(this.grupKişi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAraçOtoparkKaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Kaydı";
            this.Load += new System.EventHandler(this.frmAraçOtoparkKaydı_Load);
            this.grupKişi.ResumeLayout(false);
            this.grupKişi.PerformLayout();
            this.grupAraç.ResumeLayout(false);
            this.grupAraç.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboSeri;
        private System.Windows.Forms.ComboBox comboParkYeri;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grupKişi;
        private System.Windows.Forms.GroupBox grupAraç;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}