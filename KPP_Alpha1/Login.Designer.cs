namespace KPP_Alpha1
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.lbl_korIme = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.txt_korIme = new System.Windows.Forms.TextBox();
            this.TXTlozinka = new System.Windows.Forms.TextBox();
            this.btn_prijava = new System.Windows.Forms.Button();
            this.btn_izlaz = new System.Windows.Forms.Button();
            this.LBLponoviLozinku = new System.Windows.Forms.Label();
            this.LBLnovaLozinka = new System.Windows.Forms.Label();
            this.BTN_lozinka = new System.Windows.Forms.Button();
            this.TXTponoviLozinku = new System.Windows.Forms.TextBox();
            this.BTNspremiLozinku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_korIme
            // 
            this.lbl_korIme.AutoSize = true;
            this.lbl_korIme.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_korIme.Location = new System.Drawing.Point(114, 31);
            this.lbl_korIme.Name = "lbl_korIme";
            this.lbl_korIme.Size = new System.Drawing.Size(100, 19);
            this.lbl_korIme.TabIndex = 0;
            this.lbl_korIme.Text = "Korisničko ime:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbl_lozinka.Location = new System.Drawing.Point(114, 86);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(58, 19);
            this.lbl_lozinka.TabIndex = 0;
            this.lbl_lozinka.Text = "Lozinka:";
            // 
            // txt_korIme
            // 
            this.txt_korIme.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_korIme.Location = new System.Drawing.Point(114, 54);
            this.txt_korIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_korIme.Name = "txt_korIme";
            this.txt_korIme.Size = new System.Drawing.Size(342, 26);
            this.txt_korIme.TabIndex = 1;
            // 
            // TXTlozinka
            // 
            this.TXTlozinka.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TXTlozinka.Location = new System.Drawing.Point(114, 110);
            this.TXTlozinka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTlozinka.Name = "TXTlozinka";
            this.TXTlozinka.PasswordChar = '*';
            this.TXTlozinka.Size = new System.Drawing.Size(342, 26);
            this.TXTlozinka.TabIndex = 2;
            this.TXTlozinka.UseSystemPasswordChar = true;
            this.TXTlozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // btn_prijava
            // 
            this.btn_prijava.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_prijava.Location = new System.Drawing.Point(216, 197);
            this.btn_prijava.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(137, 51);
            this.btn_prijava.TabIndex = 3;
            this.btn_prijava.Text = "Prijava";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.Btn_prijava_Click_1);
            // 
            // btn_izlaz
            // 
            this.btn_izlaz.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btn_izlaz.Location = new System.Drawing.Point(360, 197);
            this.btn_izlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_izlaz.Name = "btn_izlaz";
            this.btn_izlaz.Size = new System.Drawing.Size(95, 51);
            this.btn_izlaz.TabIndex = 4;
            this.btn_izlaz.Text = "Izlaz";
            this.btn_izlaz.UseVisualStyleBackColor = true;
            this.btn_izlaz.Click += new System.EventHandler(this.Btn_izlaz_Click_1);
            // 
            // LBLponoviLozinku
            // 
            this.LBLponoviLozinku.AutoSize = true;
            this.LBLponoviLozinku.Location = new System.Drawing.Point(114, 143);
            this.LBLponoviLozinku.Name = "LBLponoviLozinku";
            this.LBLponoviLozinku.Size = new System.Drawing.Size(135, 19);
            this.LBLponoviLozinku.TabIndex = 5;
            this.LBLponoviLozinku.Text = "Ponovi novu lozinku:";
            this.LBLponoviLozinku.Visible = false;
            // 
            // LBLnovaLozinka
            // 
            this.LBLnovaLozinka.AutoSize = true;
            this.LBLnovaLozinka.Location = new System.Drawing.Point(114, 87);
            this.LBLnovaLozinka.Name = "LBLnovaLozinka";
            this.LBLnovaLozinka.Size = new System.Drawing.Size(90, 19);
            this.LBLnovaLozinka.TabIndex = 6;
            this.LBLnovaLozinka.Text = "Nova lozinka:";
            this.LBLnovaLozinka.Visible = false;
            // 
            // BTN_lozinka
            // 
            this.BTN_lozinka.Location = new System.Drawing.Point(114, 197);
            this.BTN_lozinka.Name = "BTN_lozinka";
            this.BTN_lozinka.Size = new System.Drawing.Size(95, 51);
            this.BTN_lozinka.TabIndex = 7;
            this.BTN_lozinka.Text = "Promjeni lozinku";
            this.BTN_lozinka.UseVisualStyleBackColor = true;
            this.BTN_lozinka.Click += new System.EventHandler(this.BTN_lozinka_Click);
            // 
            // TXTponoviLozinku
            // 
            this.TXTponoviLozinku.Location = new System.Drawing.Point(113, 165);
            this.TXTponoviLozinku.Name = "TXTponoviLozinku";
            this.TXTponoviLozinku.Size = new System.Drawing.Size(342, 26);
            this.TXTponoviLozinku.TabIndex = 8;
            this.TXTponoviLozinku.UseSystemPasswordChar = true;
            this.TXTponoviLozinku.Visible = false;
            // 
            // BTNspremiLozinku
            // 
            this.BTNspremiLozinku.Location = new System.Drawing.Point(115, 197);
            this.BTNspremiLozinku.Name = "BTNspremiLozinku";
            this.BTNspremiLozinku.Size = new System.Drawing.Size(95, 51);
            this.BTNspremiLozinku.TabIndex = 9;
            this.BTNspremiLozinku.Text = "Spremi lozinku";
            this.BTNspremiLozinku.UseVisualStyleBackColor = true;
            this.BTNspremiLozinku.Visible = false;
            this.BTNspremiLozinku.Click += new System.EventHandler(this.BTNspremiLozinku_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(553, 292);
            this.Controls.Add(this.TXTponoviLozinku);
            this.Controls.Add(this.LBLponoviLozinku);
            this.Controls.Add(this.btn_izlaz);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.TXTlozinka);
            this.Controls.Add(this.txt_korIme);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_korIme);
            this.Controls.Add(this.LBLnovaLozinka);
            this.Controls.Add(this.BTN_lozinka);
            this.Controls.Add(this.BTNspremiLozinku);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_korIme;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.TextBox txt_korIme;
        private System.Windows.Forms.TextBox TXTlozinka;
        private System.Windows.Forms.Button btn_prijava;
        private System.Windows.Forms.Button btn_izlaz;
        private System.Windows.Forms.Label LBLponoviLozinku;
        private System.Windows.Forms.Label LBLnovaLozinka;
        private System.Windows.Forms.Button BTN_lozinka;
        private System.Windows.Forms.TextBox TXTponoviLozinku;
        private System.Windows.Forms.Button BTNspremiLozinku;
    }
}