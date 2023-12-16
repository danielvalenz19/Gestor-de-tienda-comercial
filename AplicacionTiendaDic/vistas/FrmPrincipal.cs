using AplicacionTienda.model;
using AplicacionTiendaDic.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionTiendaDic.vistas
{
    public partial class FrmPrincipal : Form
    {
        private ClsProductos clsProductosModel = new ClsProductos();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarProductos();

        }
        private void CargarProductos()
        {
            ClsProductos clsProductos = new ClsProductos();
            dgvPrincipal.DataSource = clsProductos.ObtenerTodosUsuarios();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarResultadosBusqueda();

        }
        private void ActualizarResultadosBusqueda()
        {
            string palabraClave = txtBusqueda.Text.Trim();
            dgvPrincipal.DataSource = clsProductosModel.BuscarProductos(palabraClave);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarResultadosBusqueda();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //este es el evento de la imagen de usuario a la hora de precionarlo debera de llevar a otra vista de usuarios 
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
            this.Hide(); // Oculta el formulario actual en lugar de cerrarlo

        }
    }
}
