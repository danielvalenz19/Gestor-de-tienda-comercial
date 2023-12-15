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
    }
}
