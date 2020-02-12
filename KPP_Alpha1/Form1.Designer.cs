namespace KPP_Alpha1
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriKPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.urediToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOdjelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pošiljateljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odspojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.izvozPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.urediToolStripMenuItem1,
            this.bazaPodatakaToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(934, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriKPPToolStripMenuItem,
            this.toolStripSeparator1,
            this.zatvoriToolStripMenuItem,
            this.izađiIzAplikacijeToolStripMenuItem,
            this.toolStripSeparator2});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // otvoriKPPToolStripMenuItem
            // 
            this.otvoriKPPToolStripMenuItem.Name = "otvoriKPPToolStripMenuItem";
            this.otvoriKPPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otvoriKPPToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.otvoriKPPToolStripMenuItem.Text = "Otvori KPP";
            this.otvoriKPPToolStripMenuItem.Click += new System.EventHandler(this.OtvoriKPPToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.ZatvoriToolStripMenuItem_Click);
            // 
            // izađiIzAplikacijeToolStripMenuItem
            // 
            this.izađiIzAplikacijeToolStripMenuItem.Name = "izađiIzAplikacijeToolStripMenuItem";
            this.izađiIzAplikacijeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izađiIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.izađiIzAplikacijeToolStripMenuItem.Text = "Izađi iz aplikacije";
            this.izađiIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.IzađiIzAplikacijeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // urediToolStripMenuItem1
            // 
            this.urediToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.dodajOdjelToolStripMenuItem,
            this.pošiljateljiToolStripMenuItem,
            this.mjestaToolStripMenuItem});
            this.urediToolStripMenuItem1.Name = "urediToolStripMenuItem1";
            this.urediToolStripMenuItem1.Size = new System.Drawing.Size(54, 23);
            this.urediToolStripMenuItem1.Text = "Uredi";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Visible = false;
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajKorisnikaToolStripMenuItem_Click);
            // 
            // dodajOdjelToolStripMenuItem
            // 
            this.dodajOdjelToolStripMenuItem.Name = "dodajOdjelToolStripMenuItem";
            this.dodajOdjelToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.dodajOdjelToolStripMenuItem.Text = "Dodaj odjel";
            this.dodajOdjelToolStripMenuItem.Click += new System.EventHandler(this.DodajOdjelToolStripMenuItem_Click);
            // 
            // pošiljateljiToolStripMenuItem
            // 
            this.pošiljateljiToolStripMenuItem.Name = "pošiljateljiToolStripMenuItem";
            this.pošiljateljiToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.pošiljateljiToolStripMenuItem.Text = "Dodaj pošiljatelja";
            this.pošiljateljiToolStripMenuItem.Click += new System.EventHandler(this.PošiljateljiToolStripMenuItem_Click);
            // 
            // mjestaToolStripMenuItem
            // 
            this.mjestaToolStripMenuItem.Name = "mjestaToolStripMenuItem";
            this.mjestaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.mjestaToolStripMenuItem.Text = "Dodaj mjesto";
            this.mjestaToolStripMenuItem.Click += new System.EventHandler(this.MjestaToolStripMenuItem_Click);
            // 
            // bazaPodatakaToolStripMenuItem
            // 
            this.bazaPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spojiToolStripMenuItem,
            this.odspojiToolStripMenuItem,
            this.toolStripSeparator3,
            this.izvozPodatakaToolStripMenuItem});
            this.bazaPodatakaToolStripMenuItem.Name = "bazaPodatakaToolStripMenuItem";
            this.bazaPodatakaToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.bazaPodatakaToolStripMenuItem.Text = "Baza podataka";
            // 
            // spojiToolStripMenuItem
            // 
            this.spojiToolStripMenuItem.Name = "spojiToolStripMenuItem";
            this.spojiToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.spojiToolStripMenuItem.Text = "Spoji";
            this.spojiToolStripMenuItem.Click += new System.EventHandler(this.SpojiToolStripMenuItem_Click_1);
            // 
            // odspojiToolStripMenuItem
            // 
            this.odspojiToolStripMenuItem.Enabled = false;
            this.odspojiToolStripMenuItem.Name = "odspojiToolStripMenuItem";
            this.odspojiToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.odspojiToolStripMenuItem.Text = "Odspoji";
            this.odspojiToolStripMenuItem.Click += new System.EventHandler(this.OdspojiToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // izvozPodatakaToolStripMenuItem
            // 
            this.izvozPodatakaToolStripMenuItem.Name = "izvozPodatakaToolStripMenuItem";
            this.izvozPodatakaToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.izvozPodatakaToolStripMenuItem.Text = "Izvoz podataka";
            this.izvozPodatakaToolStripMenuItem.Click += new System.EventHandler(this.IzvozPodatakaToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            this.oAplikacijiToolStripMenuItem.Click += new System.EventHandler(this.OAplikacijiToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "Knjiga primljenih pošiljki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriKPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOdjelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pošiljateljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odspojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem izvozPodatakaToolStripMenuItem;
    }
}

