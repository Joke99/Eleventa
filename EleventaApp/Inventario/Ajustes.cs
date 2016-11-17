using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinoTekiApp.Inventario
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos_bajos_en_Inventario agregar = new Productos_bajos_en_Inventario();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }
    }
}
