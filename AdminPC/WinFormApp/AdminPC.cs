using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WinFormApp
{
    public partial class AdminPC : Form
    {
        public AdminPC()
        {
            InitializeComponent();
        }

        private void reportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Isla_1 Isla1 = new Isla_1();
            Isla1.ShowDialog();
            if (Isla1.DialogResult == DialogResult.Yes)
            {

            }

        }

        private void AdminPC_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void reportarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Isla_2 Isla2 = new Isla_2();
            Isla2.ShowDialog();
            if (Isla2.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void reportarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Isla_3 Isla3 = new Isla_3();
            Isla3.ShowDialog();
            if (Isla3.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void reportarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Isla_4 Isla4 = new Isla_4();
            Isla4.ShowDialog();
            if (Isla4.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void reportarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Isla_5 Isla5 = new Isla_5();
            Isla5.ShowDialog();
            if (Isla5.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void islasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
            if (Login.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Documento de texto |*.txt";
            guardar.Title = "Guardar RichtTextBox";
            guardar.FileName = "Sin titulo 1";
            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in richTextBox1.Lines)
                {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }
    }
}
