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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Documento de texto |*.txt";
            Abrir.Title = "Guardar RichtTextBox";
            Abrir.FileName = "Sin titulo 1";
            var resultado = Abrir.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(Abrir.FileName);
                richTextBox1.Text = leer.ReadToEnd();
                leer.Close();
            }
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

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
            if (Login.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
