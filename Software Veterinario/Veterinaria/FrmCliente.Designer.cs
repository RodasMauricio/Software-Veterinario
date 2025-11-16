namespace Veterinaria
{
    partial class FrmCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvCliente = new DataGridView();
            lblNombre = new Label();
            lblDniCuit = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblLocalidad = new Label();
            txtNombre = new TextBox();
            txtDniCuit = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtLocalidad = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtFiltroCliente = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToResizeColumns = false;
            dgvCliente.AllowUserToResizeRows = false;
            dgvCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvCliente.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCliente.EnableHeadersVisualStyles = false;
            dgvCliente.Location = new Point(12, 46);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(523, 520);
            dgvCliente.TabIndex = 0;
            dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(567, 136);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDniCuit
            // 
            lblDniCuit.Anchor = AnchorStyles.Right;
            lblDniCuit.AutoSize = true;
            lblDniCuit.Enabled = false;
            lblDniCuit.Font = new Font("Segoe UI", 10F);
            lblDniCuit.ForeColor = SystemColors.Window;
            lblDniCuit.Location = new Point(566, 190);
            lblDniCuit.Name = "lblDniCuit";
            lblDniCuit.Size = new Size(69, 19);
            lblDniCuit.TabIndex = 2;
            lblDniCuit.Text = "DNI-CUIT";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Enabled = false;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = SystemColors.Window;
            lblEmail.Location = new Point(566, 242);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Enabled = false;
            lblTelefono.Font = new Font("Segoe UI", 10F);
            lblTelefono.ForeColor = SystemColors.Window;
            lblTelefono.Location = new Point(566, 294);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(60, 19);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Enabled = false;
            lblDireccion.Font = new Font("Segoe UI", 10F);
            lblDireccion.ForeColor = SystemColors.Window;
            lblDireccion.Location = new Point(566, 346);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 19);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // lblLocalidad
            // 
            lblLocalidad.Anchor = AnchorStyles.Right;
            lblLocalidad.AutoSize = true;
            lblLocalidad.Enabled = false;
            lblLocalidad.Font = new Font("Segoe UI", 10F);
            lblLocalidad.ForeColor = SystemColors.Window;
            lblLocalidad.Location = new Point(566, 398);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(66, 19);
            lblLocalidad.TabIndex = 6;
            lblLocalidad.Text = "Localidad";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(120, 120, 160);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.Window;
            txtNombre.Location = new Point(571, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 25);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtDniCuit
            // 
            txtDniCuit.Anchor = AnchorStyles.Right;
            txtDniCuit.BackColor = Color.FromArgb(120, 120, 160);
            txtDniCuit.BorderStyle = BorderStyle.FixedSingle;
            txtDniCuit.Enabled = false;
            txtDniCuit.Font = new Font("Segoe UI", 10F);
            txtDniCuit.ForeColor = SystemColors.Window;
            txtDniCuit.Location = new Point(571, 212);
            txtDniCuit.Name = "txtDniCuit";
            txtDniCuit.Size = new Size(247, 25);
            txtDniCuit.TabIndex = 8;
            txtDniCuit.TextChanged += txtDniCuit_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(120, 120, 160);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(571, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 25);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(120, 120, 160);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Enabled = false;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.ForeColor = SystemColors.Window;
            txtTelefono.Location = new Point(571, 316);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 25);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Right;
            txtDireccion.BackColor = Color.FromArgb(120, 120, 160);
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Enabled = false;
            txtDireccion.Font = new Font("Segoe UI", 10F);
            txtDireccion.ForeColor = SystemColors.Window;
            txtDireccion.Location = new Point(571, 367);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(247, 25);
            txtDireccion.TabIndex = 11;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Anchor = AnchorStyles.Right;
            txtLocalidad.BackColor = Color.FromArgb(120, 120, 160);
            txtLocalidad.BorderStyle = BorderStyle.FixedSingle;
            txtLocalidad.Enabled = false;
            txtLocalidad.Font = new Font("Segoe UI", 10F);
            txtLocalidad.ForeColor = SystemColors.Window;
            txtLocalidad.Location = new Point(571, 420);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(247, 25);
            txtLocalidad.TabIndex = 12;
            txtLocalidad.TextChanged += txtLocalidad_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(120, 120, 160);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = SystemColors.Window;
            btnAceptar.Location = new Point(609, 543);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(120, 120, 160);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(706, 543);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroCliente.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroCliente.Font = new Font("Segoe UI", 10F);
            txtFiltroCliente.ForeColor = SystemColors.Window;
            txtFiltroCliente.Location = new Point(12, 11);
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.Size = new Size(261, 25);
            txtFiltroCliente.TabIndex = 15;
            txtFiltroCliente.TextChanged += txtFiltroCliente_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(573, 11);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(120, 120, 160);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.Window;
            btnModificar.Location = new Point(654, 11);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(735, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltroCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDniCuit);
            Controls.Add(txtNombre);
            Controls.Add(lblLocalidad);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblDniCuit);
            Controls.Add(lblNombre);
            Controls.Add(dgvCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCliente;
        private Label lblNombre;
        private Label lblDniCuit;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblLocalidad;
        private TextBox txtNombre;
        private TextBox txtDniCuit;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtLocalidad;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtFiltroCliente;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}