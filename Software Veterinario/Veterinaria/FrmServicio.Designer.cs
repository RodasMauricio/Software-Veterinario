namespace Veterinaria
{
    partial class FrmServicio
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
            dgvServicio = new DataGridView();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblCosto = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnRecuperar = new Button();
            btnEliminados = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            SuspendLayout();
            // 
            // dgvServicio
            // 
            dgvServicio.AllowUserToResizeColumns = false;
            dgvServicio.AllowUserToResizeRows = false;
            dgvServicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicio.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvServicio.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvServicio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServicio.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServicio.EnableHeadersVisualStyles = false;
            dgvServicio.Location = new Point(12, 46);
            dgvServicio.MultiSelect = false;
            dgvServicio.Name = "dgvServicio";
            dgvServicio.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvServicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvServicio.RowHeadersVisible = false;
            dgvServicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicio.Size = new Size(523, 520);
            dgvServicio.TabIndex = 0;
            dgvServicio.CellFormatting += dgvServicio_CellFormatting;
            dgvServicio.SelectionChanged += dgvServicio_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Enabled = false;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(575, 179);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Enabled = false;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = SystemColors.Window;
            lblDescripcion.Location = new Point(575, 228);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(79, 19);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCosto
            // 
            lblCosto.Anchor = AnchorStyles.Right;
            lblCosto.AutoSize = true;
            lblCosto.Enabled = false;
            lblCosto.Font = new Font("Segoe UI", 10F);
            lblCosto.ForeColor = SystemColors.Window;
            lblCosto.Location = new Point(575, 326);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(45, 19);
            lblCosto.TabIndex = 10;
            lblCosto.Text = "Costo";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(120, 120, 160);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.Window;
            txtNombre.Location = new Point(579, 198);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 25);
            txtNombre.TabIndex = 17;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Right;
            txtDescripcion.BackColor = Color.FromArgb(120, 120, 160);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = SystemColors.Window;
            txtDescripcion.Location = new Point(579, 247);
            txtDescripcion.MaxLength = 500;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(228, 75);
            txtDescripcion.TabIndex = 18;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Anchor = AnchorStyles.Right;
            txtCosto.BackColor = Color.FromArgb(120, 120, 160);
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Enabled = false;
            txtCosto.Font = new Font("Segoe UI", 10F);
            txtCosto.ForeColor = SystemColors.Window;
            txtCosto.Location = new Point(579, 345);
            txtCosto.MaxLength = 50;
            txtCosto.Name = "txtCosto";
            txtCosto.ShortcutsEnabled = false;
            txtCosto.Size = new Size(228, 25);
            txtCosto.TabIndex = 19;
            txtCosto.TextChanged += txtCosto_TextChanged;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(120, 120, 160);
            btnAceptar.Enabled = false;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = SystemColors.Window;
            btnAceptar.Location = new Point(609, 543);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 20;
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
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnAgregar.TabIndex = 22;
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
            btnModificar.TabIndex = 23;
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
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecuperar.BackColor = Color.SeaGreen;
            btnRecuperar.FlatAppearance.BorderSize = 0;
            btnRecuperar.FlatStyle = FlatStyle.Flat;
            btnRecuperar.ForeColor = SystemColors.Window;
            btnRecuperar.Location = new Point(460, 17);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(75, 23);
            btnRecuperar.TabIndex = 25;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Visible = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // btnEliminados
            // 
            btnEliminados.BackColor = Color.FromArgb(120, 120, 160);
            btnEliminados.FlatAppearance.BorderSize = 0;
            btnEliminados.FlatStyle = FlatStyle.Flat;
            btnEliminados.ForeColor = SystemColors.Window;
            btnEliminados.Location = new Point(12, 17);
            btnEliminados.Name = "btnEliminados";
            btnEliminados.Size = new Size(75, 23);
            btnEliminados.TabIndex = 26;
            btnEliminados.Text = "Eliminados";
            btnEliminados.UseVisualStyleBackColor = false;
            btnEliminados.Click += btnEliminados_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActualizar.BackColor = Color.FromArgb(120, 120, 160);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.Window;
            btnActualizar.Location = new Point(12, 572);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(22, 27);
            btnActualizar.TabIndex = 27;
            btnActualizar.Text = "↻";
            btnActualizar.TextAlign = ContentAlignment.TopCenter;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminados);
            Controls.Add(btnRecuperar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblCosto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(dgvServicio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmServicio";
            Text = "FrmServicio";
            Load += FrmServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServicio;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblCosto;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtCosto;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnRecuperar;
        private Button btnEliminados;
        private Button btnActualizar;
    }
}