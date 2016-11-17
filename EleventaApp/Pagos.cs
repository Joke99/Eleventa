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
    public partial class Varios_Productos : Form
    {
        public Varios_Productos()
        {
            InitializeComponent();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Efectivo agregar = new Efectivo();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dolares agregar = new dolares();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tarjeta agregar = new tarjeta();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mixto agregar = new Mixto();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credito agregar = new Credito();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
