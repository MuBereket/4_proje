namespace odev4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            yeniKayitToolStripMenuItem = new ToolStripMenuItem();
            ogrenciToolStripMenuItem = new ToolStripMenuItem();
            darsToolStripMenuItem = new ToolStripMenuItem();
            lIsteToolStripMenuItem = new ToolStripMenuItem();
            öğrencilerToolStripMenuItem = new ToolStripMenuItem();
            darslarToolStripMenuItem = new ToolStripMenuItem();
            grafikToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            ogrenciKayitToolStripMenuItem = new ToolStripMenuItem();
            kapatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(582, 688);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "Time";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ScrollBar;
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniKayitToolStripMenuItem, lIsteToolStripMenuItem, grafikToolStripMenuItem, hakkındaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(889, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniKayitToolStripMenuItem
            // 
            yeniKayitToolStripMenuItem.BackColor = Color.LightYellow;
            yeniKayitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciToolStripMenuItem, darsToolStripMenuItem });
            yeniKayitToolStripMenuItem.Name = "yeniKayitToolStripMenuItem";
            yeniKayitToolStripMenuItem.Size = new Size(97, 29);
            yeniKayitToolStripMenuItem.Text = "Yeni kayit";
            // 
            // ogrenciToolStripMenuItem
            // 
            ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            ogrenciToolStripMenuItem.Size = new Size(146, 30);
            ogrenciToolStripMenuItem.Text = "Öğrenci";
            ogrenciToolStripMenuItem.Click += ogrenciToolStripMenuItem_Click;
            // 
            // darsToolStripMenuItem
            // 
            darsToolStripMenuItem.Name = "darsToolStripMenuItem";
            darsToolStripMenuItem.Size = new Size(146, 30);
            darsToolStripMenuItem.Text = "Dars";
            darsToolStripMenuItem.Click += darsToolStripMenuItem_Click;
            // 
            // lIsteToolStripMenuItem
            // 
            lIsteToolStripMenuItem.BackColor = Color.LemonChiffon;
            lIsteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrencilerToolStripMenuItem, darslarToolStripMenuItem });
            lIsteToolStripMenuItem.Name = "lIsteToolStripMenuItem";
            lIsteToolStripMenuItem.Size = new Size(60, 29);
            lIsteToolStripMenuItem.Text = "LIste";
            // 
            // öğrencilerToolStripMenuItem
            // 
            öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            öğrencilerToolStripMenuItem.Size = new Size(165, 30);
            öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            öğrencilerToolStripMenuItem.Click += ogrencilerToolStripMenuItem_Click;
            // 
            // darslarToolStripMenuItem
            // 
            darslarToolStripMenuItem.Name = "darslarToolStripMenuItem";
            darslarToolStripMenuItem.Size = new Size(165, 30);
            darslarToolStripMenuItem.Text = "Darslar";
            darslarToolStripMenuItem.Click += darslarToolStripMenuItem_Click;
            // 
            // grafikToolStripMenuItem
            // 
            grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            grafikToolStripMenuItem.Size = new Size(70, 29);
            grafikToolStripMenuItem.Text = "Grafık";
            grafikToolStripMenuItem.Click += grafikToolStripMenuItem_Click;
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(98, 29);
            hakkındaToolStripMenuItem.Text = "Hakkında";
            hakkındaToolStripMenuItem.Click += hakkindaToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 688);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 2;
            label2.Text = "Oto ,ogr.sistem";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(36, 36);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(889, 43);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(40, 40);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(40, 40);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(40, 40);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(40, 40);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(40, 40);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(40, 40);
            toolStripButton6.Text = "toolStripButton6";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ogrenciKayitToolStripMenuItem, kapatToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(189, 94);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(188, 30);
            toolStripMenuItem1.Text = "Dars kayit";
            // 
            // ogrenciKayitToolStripMenuItem
            // 
            ogrenciKayitToolStripMenuItem.Name = "ogrenciKayitToolStripMenuItem";
            ogrenciKayitToolStripMenuItem.Size = new Size(188, 30);
            ogrenciKayitToolStripMenuItem.Text = "Ogrenci kayit";
            // 
            // kapatToolStripMenuItem
            // 
            kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            kapatToolStripMenuItem.Size = new Size(188, 30);
            kapatToolStripMenuItem.Text = "Kapat";
            kapatToolStripMenuItem.Click += kapatToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(889, 720);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "odev4 205260602 Muhammed Bereket";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniKayitToolStripMenuItem;
        private ToolStripMenuItem ogrenciToolStripMenuItem;
        private ToolStripMenuItem darsToolStripMenuItem;
        private ToolStripMenuItem lIsteToolStripMenuItem;
        private ToolStripMenuItem öğrencilerToolStripMenuItem;
        private ToolStripMenuItem darslarToolStripMenuItem;
        private ToolStripMenuItem grafikToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ogrenciKayitToolStripMenuItem;
        private ToolStripMenuItem kapatToolStripMenuItem;
    }
}