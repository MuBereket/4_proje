namespace odev4
{
    partial class Okayit
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
            Kaydit1 = new Button();
            Sinif1 = new ComboBox();
            Dars1 = new ComboBox();
            Soyad1 = new TextBox();
            Adi1 = new TextBox();
            Not1 = new TextBox();
            Numara1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Kaydit1
            // 
            Kaydit1.BackColor = Color.LightGreen;
            Kaydit1.Location = new Point(228, 277);
            Kaydit1.Name = "Kaydit1";
            Kaydit1.Size = new Size(165, 46);
            Kaydit1.TabIndex = 28;
            Kaydit1.Text = "Kaydet";
            Kaydit1.UseVisualStyleBackColor = false;
            Kaydit1.Click += Kaydit1_Click;
            // 
            // Sinif1
            // 
            Sinif1.Enabled = false;
            Sinif1.FormattingEnabled = true;
            Sinif1.Location = new Point(369, 184);
            Sinif1.Name = "Sinif1";
            Sinif1.Size = new Size(165, 33);
            Sinif1.TabIndex = 27;
            // 
            // Dars1
            // 
            Dars1.FormattingEnabled = true;
            Dars1.Location = new Point(369, 129);
            Dars1.Name = "Dars1";
            Dars1.Size = new Size(165, 33);
            Dars1.TabIndex = 26;
            Dars1.SelectedIndexChanged += Dars1_SelectedIndexChanged;
            // 
            // Soyad1
            // 
            Soyad1.Location = new Point(137, 240);
            Soyad1.Multiline = true;
            Soyad1.Name = "Soyad1";
            Soyad1.Size = new Size(165, 31);
            Soyad1.TabIndex = 25;
            // 
            // Adi1
            // 
            Adi1.Location = new Point(137, 184);
            Adi1.Multiline = true;
            Adi1.Name = "Adi1";
            Adi1.Size = new Size(165, 31);
            Adi1.TabIndex = 24;
            // 
            // Not1
            // 
            Not1.Location = new Point(369, 236);
            Not1.Multiline = true;
            Not1.Name = "Not1";
            Not1.Size = new Size(165, 31);
            Not1.TabIndex = 23;
            // 
            // Numara1
            // 
            Numara1.Location = new Point(137, 129);
            Numara1.Multiline = true;
            Numara1.Name = "Numara1";
            Numara1.Size = new Size(165, 31);
            Numara1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 242);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 21;
            label8.Text = "Not";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 129);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 20;
            label7.Text = "Dars";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 129);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 19;
            label6.Text = "Numara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 184);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 18;
            label5.Text = "Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 242);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 17;
            label4.Text = "Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 187);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 16;
            label3.Text = "Sınıf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSalmon;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 26);
            label2.Name = "label2";
            label2.Size = new Size(188, 37);
            label2.TabIndex = 15;
            label2.Text = "Öğrenci kayıt";
            // 
            // Okayit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(599, 356);
            Controls.Add(Kaydit1);
            Controls.Add(Sinif1);
            Controls.Add(Dars1);
            Controls.Add(Soyad1);
            Controls.Add(Adi1);
            Controls.Add(Not1);
            Controls.Add(Numara1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Location = new Point(500, 300);
            MaximizeBox = false;
            Name = "Okayit";
            Text = "Okayit";
            Load += Okayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Kaydit1;
        private ComboBox Sinif1;
        private ComboBox Dars1;
        private TextBox Soyad1;
        private TextBox Adi1;
        private TextBox Not1;
        private TextBox Numara1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}