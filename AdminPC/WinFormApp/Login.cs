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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngre_Click(object sender, EventArgs e)
        {

            if ((txtUsr.Text == "Ivan") && (txtPasw.Text == "12345678"))
            {
                MessageBox.Show("Bienvenido Ivan");
                this.Hide();
                AdminPC AdminPC = new AdminPC();
                AdminPC.ShowDialog();
                if (AdminPC.DialogResult == DialogResult.Yes)
                {

                }
                
                }
                /*else
                {
                    MessageBox.Show("Datos Erroneos Vuelve a intentar");
                }*/

                if((txtUsr.Text=="Horacio") && (txtPasw.Text == "123456"))
                 {
                     MessageBox.Show("Bienvenido Maestro Horacio");
                     this.Hide();
                     MenuAdmin MenuAdmin = new MenuAdmin();
                     MenuAdmin.ShowDialog();
                     if (MenuAdmin.DialogResult == DialogResult.Yes)
                     {

                     }
                 }
                 else
                 {
                     MessageBox.Show("Datos erroneos vuelve a intentar");
                 }




            
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro Registro = new Registro();
            Registro.ShowDialog();
            if (Registro.DialogResult == DialogResult.Yes)
            {

            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            this.btnRegis.DialogResult = System.Windows.Forms.DialogResult.Yes;
           

        }

        private void txtPasw_TextChanged(object sender, EventArgs e)
        {
            txtPasw.PasswordChar = '*';
        }
    }
}
