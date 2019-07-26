namespace OOPProject03_1
{
    partial class FormDetay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYasadiniz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtDakika = new System.Windows.Forms.TextBox();
            this.txtSaniye = new System.Windows.Forms.TextBox();
            this.txtMilisaniye = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Gün";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Toplam Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Toplam Dakika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Toplam Saniye";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam Milisaniye";
            // 
            // lblYasadiniz
            // 
            this.lblYasadiniz.AutoSize = true;
            this.lblYasadiniz.BackColor = System.Drawing.Color.Yellow;
            this.lblYasadiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasadiniz.Location = new System.Drawing.Point(270, 314);
            this.lblYasadiniz.Name = "lblYasadiniz";
            this.lblYasadiniz.Size = new System.Drawing.Size(181, 25);
            this.lblYasadiniz.TabIndex = 9;
            this.lblYasadiniz.Text = "****YAŞADINIZ****";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(203, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(203, 43);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(203, 69);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 12;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(203, 95);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 13;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(203, 121);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 20);
            this.txtGun.TabIndex = 14;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(203, 147);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(100, 20);
            this.txtSaat.TabIndex = 15;
            // 
            // txtDakika
            // 
            this.txtDakika.Location = new System.Drawing.Point(203, 173);
            this.txtDakika.Name = "txtDakika";
            this.txtDakika.Size = new System.Drawing.Size(100, 20);
            this.txtDakika.TabIndex = 16;
            // 
            // txtSaniye
            // 
            this.txtSaniye.Location = new System.Drawing.Point(203, 199);
            this.txtSaniye.Name = "txtSaniye";
            this.txtSaniye.Size = new System.Drawing.Size(100, 20);
            this.txtSaniye.TabIndex = 17;
            // 
            // txtMilisaniye
            // 
            this.txtMilisaniye.Location = new System.Drawing.Point(203, 228);
            this.txtMilisaniye.Name = "txtMilisaniye";
            this.txtMilisaniye.Size = new System.Drawing.Size(100, 20);
            this.txtMilisaniye.TabIndex = 18;
            // 
            // FormDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMilisaniye);
            this.Controls.Add(this.txtSaniye);
            this.Controls.Add(this.txtDakika);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblYasadiniz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetay";
            this.Text = "Seçilen Kişinin Yaşam Süresi Bİlgileri";
            this.Load += new System.EventHandler(this.FormDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYasadiniz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.TextBox txtDakika;
        private System.Windows.Forms.TextBox txtSaniye;
        private System.Windows.Forms.TextBox txtMilisaniye;
    }
}