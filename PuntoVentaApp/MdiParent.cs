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
using VinoTekiApp.Interface_Producto;
using VinoTekiApp.Interface_Venta;


namespace VinoTekiApp
{
    public partial class MdiParent : Form
    {
        public MdiParent()
        {
            InitializeComponent();
        }
        public static Boolean FormIsOpen(String FormABuscar)
        {
            Boolean lEncontrado = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == FormABuscar)
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    lEncontrado = true;
                    break;
                }
            }
            return lEncontrado;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Venta agregar = new Venta();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!FormIsOpen("Inventarios"))
            {
                Inventarios form = new Inventarios();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Producto agregar = new Producto();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Inventarios agregar = new Inventarios();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.Yes)
            {
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
    }

