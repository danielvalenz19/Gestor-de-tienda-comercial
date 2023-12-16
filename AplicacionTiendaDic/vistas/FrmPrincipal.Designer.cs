namespace AplicacionTiendaDic.vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            dgvPrincipal = new DataGridView();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            hacerVentaToolStripMenuItem = new ToolStripMenuItem();
            hacerCompraToolStripMenuItem = new ToolStripMenuItem();
            modificacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarProductosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            miUsuarioToolStripMenuItem = new ToolStripMenuItem();
            generalSoloAdministradoresToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirYCerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(234, 236);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Size = new Size(551, 264);
            dgvPrincipal.TabIndex = 0;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Location = new Point(315, 178);
            txtBusqueda.Multiline = true;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(250, 33);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(234, 177);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 520);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(137, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 100);
            panel2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem, modificacionesToolStripMenuItem, usuariosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(910, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hacerVentaToolStripMenuItem, hacerCompraToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(67, 20);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // hacerVentaToolStripMenuItem
            // 
            hacerVentaToolStripMenuItem.Name = "hacerVentaToolStripMenuItem";
            hacerVentaToolStripMenuItem.Size = new Size(180, 22);
            hacerVentaToolStripMenuItem.Text = "Hacer Venta";
            // 
            // hacerCompraToolStripMenuItem
            // 
            hacerCompraToolStripMenuItem.Name = "hacerCompraToolStripMenuItem";
            hacerCompraToolStripMenuItem.Size = new Size(180, 22);
            hacerCompraToolStripMenuItem.Text = "Hacer Compra";
            // 
            // modificacionesToolStripMenuItem
            // 
            modificacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductosToolStripMenuItem });
            modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            modificacionesToolStripMenuItem.Size = new Size(100, 20);
            modificacionesToolStripMenuItem.Text = "Modificaciones";
            // 
            // agregarProductosToolStripMenuItem
            // 
            agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            agregarProductosToolStripMenuItem.Size = new Size(180, 22);
            agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miUsuarioToolStripMenuItem, generalSoloAdministradoresToolStripMenuItem, usuariosToolStripMenuItem1 });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(66, 20);
            usuariosToolStripMenuItem.Text = "Ventanas";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // miUsuarioToolStripMenuItem
            // 
            miUsuarioToolStripMenuItem.Name = "miUsuarioToolStripMenuItem";
            miUsuarioToolStripMenuItem.Size = new Size(238, 22);
            miUsuarioToolStripMenuItem.Text = "Proveedores";
            miUsuarioToolStripMenuItem.Click += miUsuarioToolStripMenuItem_Click;
            // 
            // generalSoloAdministradoresToolStripMenuItem
            // 
            generalSoloAdministradoresToolStripMenuItem.Name = "generalSoloAdministradoresToolStripMenuItem";
            generalSoloAdministradoresToolStripMenuItem.Size = new Size(238, 22);
            generalSoloAdministradoresToolStripMenuItem.Text = "General (Solo Administradores)";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirYCerrarSesionToolStripMenuItem, cerrarSesionToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirYCerrarSesionToolStripMenuItem
            // 
            salirYCerrarSesionToolStripMenuItem.Name = "salirYCerrarSesionToolStripMenuItem";
            salirYCerrarSesionToolStripMenuItem.Size = new Size(180, 22);
            salirYCerrarSesionToolStripMenuItem.Text = "Salir y Cerrar Sesion";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(238, 22);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(dgvPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrincipal;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem modificacionesToolStripMenuItem;
        private ToolStripMenuItem agregarProductosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirYCerrarSesionToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem miUsuarioToolStripMenuItem;
        private ToolStripMenuItem hacerVentaToolStripMenuItem;
        private ToolStripMenuItem hacerCompraToolStripMenuItem;
        private ToolStripMenuItem generalSoloAdministradoresToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
    }
}