namespace WinFormApp
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lbRegisNomb = new System.Windows.Forms.Label();
            this.lblRegisApe = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblConfCorreo = new System.Windows.Forms.Label();
            this.lblPasw = new System.Windows.Forms.Label();
            this.lblConfPasw = new System.Windows.Forms.Label();
            this.lblMatri = new System.Windows.Forms.Label();
            this.txtRegisNomb = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtConfCorreo = new System.Windows.Forms.TextBox();
            this.txtPasw = new System.Windows.Forms.TextBox();
            this.txtConfPasw = new System.Windows.Forms.TextBox();
            this.txtMatri = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRegisNomb
            // 
            this.lbRegisNomb.AutoSize = true;
            this.lbRegisNomb.BackColor = System.Drawing.Color.Transparent;
            this.lbRegisNomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisNomb.Location = new System.Drawing.Point(123, 53);
            this.lbRegisNomb.Name = "lbRegisNomb";
            this.lbRegisNomb.Size = new System.Drawing.Size(67, 16);
            this.lbRegisNomb.TabIndex = 0;
            this.lbRegisNomb.Text = "Nombre:";
            // 
            // lblRegisApe
            // 
            this.lblRegisApe.AutoSize = true;
            this.lblRegisApe.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisApe.Location = new System.Drawing.Point(112, 99);
            this.lblRegisApe.Name = "lblRegisApe";
            this.lblRegisApe.Size = new System.Drawing.Size(78, 16);
            this.lblRegisApe.TabIndex = 1;
            this.lblRegisApe.Text = "Apellidos:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(131, 150);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 16);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblConfCorreo
            // 
            this.lblConfCorreo.AutoSize = true;
            this.lblConfCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblConfCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfCorreo.Location = new System.Drawing.Point(46, 202);
            this.lblConfCorreo.Name = "lblConfCorreo";
            this.lblConfCorreo.Size = new System.Drawing.Size(144, 16);
            this.lblConfCorreo.TabIndex = 3;
            this.lblConfCorreo.Text = "Confirmar el correo:";
            // 
            // lblPasw
            // 
            this.lblPasw.AutoSize = true;
            this.lblPasw.BackColor = System.Drawing.Color.Transparent;
            this.lblPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasw.Location = new System.Drawing.Point(99, 257);
            this.lblPasw.Name = "lblPasw";
            this.lblPasw.Size = new System.Drawing.Size(91, 16);
            this.lblPasw.TabIndex = 4;
            this.lblPasw.Text = "Contraseña:";
            // 
            // lblConfPasw
            // 
            this.lblConfPasw.AutoSize = true;
            this.lblConfPasw.BackColor = System.Drawing.Color.Transparent;
            this.lblConfPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPasw.Location = new System.Drawing.Point(29, 313);
            this.lblConfPasw.Name = "lblConfPasw";
            this.lblConfPasw.Size = new System.Drawing.Size(161, 16);
            this.lblConfPasw.TabIndex = 5;
            this.lblConfPasw.Text = "Confirmar Contraseña:";
            // 
            // lblMatri
            // 
            this.lblMatri.AutoSize = true;
            this.lblMatri.BackColor = System.Drawing.Color.Transparent;
            this.lblMatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatri.Location = new System.Drawing.Point(115, 366);
            this.lblMatri.Name = "lblMatri";
            this.lblMatri.Size = new System.Drawing.Size(75, 16);
            this.lblMatri.TabIndex = 6;
            this.lblMatri.Text = "Matricula:";
            // 
            // txtRegisNomb
            // 
            this.txtRegisNomb.Location = new System.Drawing.Point(205, 49);
            this.txtRegisNomb.Name = "txtRegisNomb";
            this.txtRegisNomb.Size = new System.Drawing.Size(211, 20);
            this.txtRegisNomb.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(205, 146);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(211, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtConfCorreo
            // 
            this.txtConfCorreo.Location = new System.Drawing.Point(205, 198);
            this.txtConfCorreo.Name = "txtConfCorreo";
            this.txtConfCorreo.Size = new System.Drawing.Size(211, 20);
            this.txtConfCorreo.TabIndex = 10;
            // 
            // txtPasw
            // 
            this.txtPasw.Location = new System.Drawing.Point(205, 253);
            this.txtPasw.Name = "txtPasw";
            this.txtPasw.Size = new System.Drawing.Size(211, 20);
            this.txtPasw.TabIndex = 11;
            this.txtPasw.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtConfPasw
            // 
            this.txtConfPasw.Location = new System.Drawing.Point(205, 309);
            this.txtConfPasw.Name = "txtConfPasw";
            this.txtConfPasw.Size = new System.Drawing.Size(211, 20);
            this.txtConfPasw.TabIndex = 12;
            // 
            // txtMatri
            // 
            this.txtMatri.Location = new System.Drawing.Point(205, 366);
            this.txtMatri.Name = "txtMatri";
            this.txtMatri.Size = new System.Drawing.Size(211, 20);
            this.txtMatri.TabIndex = 13;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(245, 445);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(141, 44);
            this.btnRegistro.TabIndex = 14;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(49, 445);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(141, 44);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 531);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtMatri);
            this.Controls.Add(this.txtConfPasw);
            this.Controls.Add(this.txtPasw);
            this.Controls.Add(this.txtConfCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtRegisNomb);
            this.Controls.Add(this.lblMatri);
            this.Controls.Add(this.lblConfPasw);
            this.Controls.Add(this.lblPasw);
            this.Controls.Add(this.lblConfCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblRegisApe);
            this.Controls.Add(this.lbRegisNomb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegisNomb;
        private System.Windows.Forms.Label lblRegisApe;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblConfCorreo;
        private System.Windows.Forms.Label lblPasw;
        private System.Windows.Forms.Label lblConfPasw;
        private System.Windows.Forms.Label lblMatri;
        private System.Windows.Forms.TextBox txtRegisNomb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtConfCorreo;
        private System.Windows.Forms.TextBox txtPasw;
        private System.Windows.Forms.TextBox txtConfPasw;
        private System.Windows.Forms.TextBox txtMatri;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnRegresar;
    }
}