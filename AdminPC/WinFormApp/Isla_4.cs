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
    public partial class Isla_4 : Form
    {
        public Isla_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPC AdminPC = new AdminPC();
            AdminPC.ShowDialog();
            if (AdminPC.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
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
