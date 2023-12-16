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
    public partial class FrmUsuarios : Form
    {
        private ClsUsuarios clsUsuarios = new ClsUsuarios();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = clsUsuarios.ObtenerTodosUsuarios();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string contraseña = txtContraseña.Text;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString(); // Asumiendo que cmbTipoUsuario es tu ComboBox

            clsUsuarios.GuardarUsuario(id, nombre, apellido, edad, contraseña, tipoUsuario);
            CargarUsuarios(); // Recargar los usuarios después de guardar uno nuevo
        }
    }
}
