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
    public partial class Productos_bajos_en_Inventario : Form
    {
        public Productos_bajos_en_Inventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_de_Inventario agregar = new Reporte_de_Inventario();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }
    }
}
