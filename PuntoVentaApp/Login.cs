using PuntoVentaApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinoTekiApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarioOb = new Usuarios();
            usuarioOb.Usuario = this.txt1.Text;
            usuarioOb.Contraseña = this.txt2.Text;

            if (usuarioOb.Buscar()==true)
                {
                MessageBox.Show(usuarioOb.Mensaje, "Login");
                MdiParent agregar = new MdiParent();
                agregar.ShowDialog();
                if (agregar.DialogResult == DialogResult.Yes)
                {
                }
            }
            else
            {
                MessageBox.Show(usuarioOb.Mensaje, "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
