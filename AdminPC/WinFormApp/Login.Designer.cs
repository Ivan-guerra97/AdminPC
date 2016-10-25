namespace WinFormApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbUsr = new System.Windows.Forms.Label();
            this.lbPasw = new System.Windows.Forms.Label();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtPasw = new System.Windows.Forms.TextBox();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnIngre = new System.Windows.Forms.Button();
            this.lnkContra = new System.Windows.Forms.LinkLabel();
            this.logo_adpc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_adpc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsr
            // 
            this.lbUsr.AutoSize = true;
            this.lbUsr.BackColor = System.Drawing.Color.Transparent;
            this.lbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsr.Location = new System.Drawing.Point(276, 58);
            this.lbUsr.Name = "lbUsr";
            this.lbUsr.Size = new System.Drawing.Size(72, 18);
            this.lbUsr.TabIndex = 0;
            this.lbUsr.Text = "Usuario:";
            // 
            // lbPasw
            // 
            this.lbPasw.AutoSize = true;
            this.lbPasw.BackColor = System.Drawing.Color.Transparent;
            this.lbPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasw.Location = new System.Drawing.Point(276, 106);
            this.lbPasw.Name = "lbPasw";
            this.lbPasw.Size = new System.Drawing.Size(100, 18);
            this.lbPasw.TabIndex = 1;
            this.lbPasw.Text = "Contraseña:";
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(396, 58);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(212, 20);
            this.txtUsr.TabIndex = 2;
            // 
            // txtPasw
            // 
            this.txtPasw.Location = new System.Drawing.Point(396, 107);
            this.txtPasw.Name = "txtPasw";
            this.txtPasw.Size = new System.Drawing.Size(212, 20);
            this.txtPasw.TabIndex = 3;
            // 
            // btnRegis
            // 
            this.btnRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.Location = new System.Drawing.Point(396, 146);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(75, 28);
            this.btnRegis.TabIndex = 4;
            this.btnRegis.Text = "Registrar";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnIngre
            // 
            this.btnIngre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngre.Location = new System.Drawing.Point(533, 146);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(75, 28);
            this.btnIngre.TabIndex = 5;
            this.btnIngre.Text = "Ingresar";
            this.btnIngre.UseVisualStyleBackColor = true;
            this.btnIngre.Click += new System.EventHandler(this.btnIngre_Click);
            // 
            // lnkContra
            // 
            this.lnkContra.AutoSize = true;
            this.lnkContra.BackColor = System.Drawing.Color.Transparent;
            this.lnkContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkContra.LinkColor = System.Drawing.Color.Black;
            this.lnkContra.Location = new System.Drawing.Point(422, 248);
            this.lnkContra.Name = "lnkContra";
            this.lnkContra.Size = new System.Drawing.Size(186, 16);
            this.lnkContra.TabIndex = 6;
            this.lnkContra.TabStop = true;
            this.lnkContra.Text = "¿Has olvidado tu contraseña?";
            // 
            // logo_adpc
            // 
            this.logo_adpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_adpc.Image = ((System.Drawing.Image)(resources.GetObject("logo_adpc.Image")));
            this.logo_adpc.Location = new System.Drawing.Point(23, 60);
            this.logo_adpc.Name = "logo_adpc";
            this.logo_adpc.Size = new System.Drawing.Size(247, 149);
            this.logo_adpc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_adpc.TabIndex = 7;
            this.logo_adpc.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 273);
            this.Controls.Add(this.logo_adpc);
            this.Controls.Add(this.lnkContra);
            this.Controls.Add(this.btnIngre);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtPasw);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.lbPasw);
            this.Controls.Add(this.lbUsr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_adpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsr;
        private System.Windows.Forms.Label lbPasw;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtPasw;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.LinkLabel lnkContra;
        private System.Windows.Forms.PictureBox logo_adpc;
    }
}