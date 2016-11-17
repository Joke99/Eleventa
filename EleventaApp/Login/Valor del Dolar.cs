using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinoTekiApp.Interface_Producto;

namespace VinoTekiApp.Usuario
{
    public partial class Valor_del_Dolar : Form
    {
        public Valor_del_Dolar()
        {
            InitializeComponent();
        }

        private void Valor_del_Dolar_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(75, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto agregar = new Producto();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }
    }
}
