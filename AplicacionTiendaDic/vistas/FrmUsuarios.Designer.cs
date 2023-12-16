namespace AplicacionTiendaDic.vistas
{
    partial class FrmUsuarios
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
            dgvUsuarios = new DataGridView();
            panel2 = new Panel();
            btnRegresar = new Button();
            panel1 = new Panel();
            txtId = new TextBox();
            btnGuardar = new Button();
            lblId = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            cmbTipoUsuario = new ComboBox();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(227, 305);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(739, 282);
            dgvUsuarios.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnRegresar);
            panel2.Location = new Point(132, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 100);
            panel2.TabIndex = 6;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(759, 37);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 621);
            panel1.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(240, 136);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 34);
            txtId.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(429, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(222, 118);
            lblId.Name = "lblId";
            lblId.Size = new Size(79, 15);
            lblId.TabIndex = 9;
            lblId.Text = "Id del Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 118);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(429, 136);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 34);
            txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 118);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(621, 136);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(168, 34);
            txtApellido.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(793, 118);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 15;
            label1.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(811, 136);
            txtEdad.Multiline = true;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(168, 34);
            txtEdad.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 173);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 17;
            label4.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(240, 191);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(168, 34);
            txtContraseña.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 173);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 19;
            label5.Text = "Tipo de Usuario";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "", "Administrador", "Usuario" });
            cmbTipoUsuario.Location = new Point(414, 191);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(183, 23);
            cmbTipoUsuario.TabIndex = 20;
            cmbTipoUsuario.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(510, 253);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 623);
            Controls.Add(btnActualizar);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lblId);
            Controls.Add(btnGuardar);
            Controls.Add(txtId);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtId;
        private Button btnGuardar;
        private Label lblId;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
        private ComboBox cmbTipoUsuario;
        private Button btnRegresar;
        private Button btnActualizar;
    }
}