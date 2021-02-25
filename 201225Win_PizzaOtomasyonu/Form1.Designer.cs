namespace _201225Win_PizzaOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listPizzalar = new System.Windows.Forms.ListBox();
            this.rdbIncekenar = new System.Windows.Forms.RadioButton();
            this.rdbKalinKenar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamtutar = new System.Windows.Forms.Label();
            this.btnSiparisOnay = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Otomasyonu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ebat";
            // 
            // cmbEbat
            // 
            this.cmbEbat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(33, 110);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(268, 24);
            this.cmbEbat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pizzalar";
            // 
            // listPizzalar
            // 
            this.listPizzalar.FormattingEnabled = true;
            this.listPizzalar.ItemHeight = 16;
            this.listPizzalar.Location = new System.Drawing.Point(33, 178);
            this.listPizzalar.Name = "listPizzalar";
            this.listPizzalar.Size = new System.Drawing.Size(268, 84);
            this.listPizzalar.TabIndex = 3;
            // 
            // rdbIncekenar
            // 
            this.rdbIncekenar.AutoSize = true;
            this.rdbIncekenar.Checked = true;
            this.rdbIncekenar.Location = new System.Drawing.Point(33, 277);
            this.rdbIncekenar.Name = "rdbIncekenar";
            this.rdbIncekenar.Size = new System.Drawing.Size(97, 21);
            this.rdbIncekenar.TabIndex = 4;
            this.rdbIncekenar.TabStop = true;
            this.rdbIncekenar.Text = "İnce Kenar";
            this.rdbIncekenar.UseVisualStyleBackColor = true;
            // 
            // rdbKalinKenar
            // 
            this.rdbKalinKenar.AutoSize = true;
            this.rdbKalinKenar.Location = new System.Drawing.Point(149, 277);
            this.rdbKalinKenar.Name = "rdbKalinKenar";
            this.rdbKalinKenar.Size = new System.Drawing.Size(100, 21);
            this.rdbKalinKenar.TabIndex = 4;
            this.rdbKalinKenar.Text = "Kalın kenar";
            this.rdbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "dana janbon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(5, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 21);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Mısır";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(109, 104);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 21);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Ton Balığı";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(5, 131);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 21);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Zeytin1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(110, 23);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 21);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Salam";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(110, 50);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(69, 21);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Sucuk";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(109, 77);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(74, 21);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Mantar";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(109, 131);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(70, 21);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "Peynir";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 104);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 21);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Ançuez";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(74, 504);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(69, 22);
            this.nudAdet.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(166, 503);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(316, 504);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(119, 22);
            this.txtTutar.TabIndex = 10;
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.HorizontalScrollbar = true;
            this.listSepet.ItemHeight = 16;
            this.listSepet.Location = new System.Drawing.Point(316, 110);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(726, 372);
            this.listSepet.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(791, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toplam Tutar";
            // 
            // lblToplamtutar
            // 
            this.lblToplamtutar.AutoSize = true;
            this.lblToplamtutar.Location = new System.Drawing.Point(907, 503);
            this.lblToplamtutar.Name = "lblToplamtutar";
            this.lblToplamtutar.Size = new System.Drawing.Size(0, 17);
            this.lblToplamtutar.TabIndex = 13;
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Location = new System.Drawing.Point(944, 547);
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Size = new System.Drawing.Size(75, 49);
            this.btnSiparisOnay.TabIndex = 14;
            this.btnSiparisOnay.Text = "Siparişi Onayla";
            this.btnSiparisOnay.UseVisualStyleBackColor = true;
            this.btnSiparisOnay.Click += new System.EventHandler(this.btnSiparisOnay_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(457, 503);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(137, 29);
            this.btnSepeteEkle.TabIndex = 15;
            this.btnSepeteEkle.Text = "Sepete ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 608);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSiparisOnay);
            this.Controls.Add(this.lblToplamtutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbKalinKenar);
            this.Controls.Add(this.rdbIncekenar);
            this.Controls.Add(this.listPizzalar);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPizzalar;
        private System.Windows.Forms.RadioButton rdbIncekenar;
        private System.Windows.Forms.RadioButton rdbKalinKenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamtutar;
        private System.Windows.Forms.Button btnSiparisOnay;
        private System.Windows.Forms.Button btnSepeteEkle;
    }
}

