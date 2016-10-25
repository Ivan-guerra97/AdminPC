using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.btnRegistro.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
            if (Login.DialogResult == DialogResult.Yes)
            {

            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
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
