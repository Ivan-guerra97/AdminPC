namespace WinFormApp
{
    partial class AdminPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPC));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isla2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.isla3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.isla4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.isla5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProgramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quejas y Sugerencias del Laboratorio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islasToolStripMenuItem,
            this.isla2ToolStripMenuItem,
            this.isla3ToolStripMenuItem,
            this.isla4ToolStripMenuItem,
            this.isla5ToolStripMenuItem,
            this.programasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islasToolStripMenuItem
            // 
            this.islasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarToolStripMenuItem});
            this.islasToolStripMenuItem.Name = "islasToolStripMenuItem";
            this.islasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.islasToolStripMenuItem.Text = "Isla 1";
            this.islasToolStripMenuItem.Click += new System.EventHandler(this.islasToolStripMenuItem_Click);
            // 
            // reportarToolStripMenuItem
            // 
            this.reportarToolStripMenuItem.Name = "reportarToolStripMenuItem";
            this.reportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportarToolStripMenuItem.Text = "Reportar";
            this.reportarToolStripMenuItem.Click += new System.EventHandler(this.reportarToolStripMenuItem_Click);
            // 
            // isla2ToolStripMenuItem
            // 
            this.isla2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarToolStripMenuItem1});
            this.isla2ToolStripMenuItem.Name = "isla2ToolStripMenuItem";
            this.isla2ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.isla2ToolStripMenuItem.Text = "Isla 2";
            // 
            // reportarToolStripMenuItem1
            // 
            this.reportarToolStripMenuItem1.Name = "reportarToolStripMenuItem1";
            this.reportarToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.reportarToolStripMenuItem1.Text = "Reportar";
            this.reportarToolStripMenuItem1.Click += new System.EventHandler(this.reportarToolStripMenuItem1_Click);
            // 
            // isla3ToolStripMenuItem
            // 
            this.isla3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarToolStripMenuItem2});
            this.isla3ToolStripMenuItem.Name = "isla3ToolStripMenuItem";
            this.isla3ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.isla3ToolStripMenuItem.Text = "Isla 3";
            // 
            // reportarToolStripMenuItem2
            // 
            this.reportarToolStripMenuItem2.Name = "reportarToolStripMenuItem2";
            this.reportarToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.reportarToolStripMenuItem2.Text = "Reportar";
            this.reportarToolStripMenuItem2.Click += new System.EventHandler(this.reportarToolStripMenuItem2_Click);
            // 
            // isla4ToolStripMenuItem
            // 
            this.isla4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarToolStripMenuItem3});
            this.isla4ToolStripMenuItem.Name = "isla4ToolStripMenuItem";
            this.isla4ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.isla4ToolStripMenuItem.Text = "Isla 4";
            // 
            // reportarToolStripMenuItem3
            // 
            this.reportarToolStripMenuItem3.Name = "reportarToolStripMenuItem3";
            this.reportarToolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.reportarToolStripMenuItem3.Text = "Reportar";
            this.reportarToolStripMenuItem3.Click += new System.EventHandler(this.reportarToolStripMenuItem3_Click);
            // 
            // isla5ToolStripMenuItem
            // 
            this.isla5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarToolStripMenuItem4});
            this.isla5ToolStripMenuItem.Name = "isla5ToolStripMenuItem";
            this.isla5ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.isla5ToolStripMenuItem.Text = "Isla 5";
            // 
            // reportarToolStripMenuItem4
            // 
            this.reportarToolStripMenuItem4.Name = "reportarToolStripMenuItem4";
            this.reportarToolStripMenuItem4.Size = new System.Drawing.Size(119, 22);
            this.reportarToolStripMenuItem4.Text = "Reportar";
            this.reportarToolStripMenuItem4.Click += new System.EventHandler(this.reportarToolStripMenuItem4_Click);
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProgramasToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // verProgramasToolStripMenuItem
            // 
            this.verProgramasToolStripMenuItem.Name = "verProgramasToolStripMenuItem";
            this.verProgramasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.verProgramasToolStripMenuItem.Text = "Ver programas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 236);
            this.textBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(377, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AdminPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 469);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPC";
            this.Load += new System.EventHandler(this.AdminPC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isla2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem isla3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem isla4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem isla5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProgramasToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}