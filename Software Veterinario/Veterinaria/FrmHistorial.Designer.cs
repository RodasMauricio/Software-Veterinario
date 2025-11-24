namespace Veterinaria
{
    partial class FrmHistorial
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
            dgvHistorial = new DataGridView();
            txtFiltroHistorial = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblIdTurno = new Label();
            lblMotivoConsulta = new Label();
            lblDiagnostico = new Label();
            lblTratamiento = new Label();
            lblPrecioFinal = new Label();
            txtIdTurno = new TextBox();
            txtMotivoConsulta = new TextBox();
            txtDiagnostico = new TextBox();
            txtTratamiento = new TextBox();
            txtPrecioFinal = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.Location = new Point(12, 46);
            dgvHistorial.Name = "dgvHistorial";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHistorial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(523, 520);
            dgvHistorial.TabIndex = 0;
            dgvHistorial.CellFormatting += dgvHistorial_CellFormatting;
            dgvHistorial.SelectionChanged += dgvHistorial_SelectionChanged;
            // 
            // txtFiltroHistorial
            // 
            txtFiltroHistorial.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroHistorial.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroHistorial.Font = new Font("Segoe UI", 10F);
            txtFiltroHistorial.ForeColor = SystemColors.Window;
            txtFiltroHistorial.Location = new Point(12, 11);
            txtFiltroHistorial.Name = "txtFiltroHistorial";
            txtFiltroHistorial.Size = new Size(261, 25);
            txtFiltroHistorial.TabIndex = 1;
            txtFiltroHistorial.TextChanged += txtFiltroHistorial_TextChanged;
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
            btnAgregar.TabIndex = 2;
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
            btnModificar.TabIndex = 3;
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
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblIdTurno
            // 
            lblIdTurno.Anchor = AnchorStyles.Right;
            lblIdTurno.AutoSize = true;
            lblIdTurno.Enabled = false;
            lblIdTurno.Font = new Font("Segoe UI", 10F);
            lblIdTurno.ForeColor = SystemColors.Window;
            lblIdTurno.Location = new Point(566, 79);
            lblIdTurno.Name = "lblIdTurno";
            lblIdTurno.Size = new Size(63, 19);
            lblIdTurno.TabIndex = 5;
            lblIdTurno.Text = "ID Turno";
            // 
            // lblMotivoConsulta
            // 
            lblMotivoConsulta.Anchor = AnchorStyles.Right;
            lblMotivoConsulta.AutoSize = true;
            lblMotivoConsulta.Enabled = false;
            lblMotivoConsulta.Font = new Font("Segoe UI", 10F);
            lblMotivoConsulta.ForeColor = SystemColors.Window;
            lblMotivoConsulta.Location = new Point(565, 133);
            lblMotivoConsulta.Name = "lblMotivoConsulta";
            lblMotivoConsulta.Size = new Size(111, 19);
            lblMotivoConsulta.TabIndex = 6;
            lblMotivoConsulta.Text = "Motivo Consulta";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.Anchor = AnchorStyles.Right;
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Enabled = false;
            lblDiagnostico.Font = new Font("Segoe UI", 10F);
            lblDiagnostico.ForeColor = SystemColors.Window;
            lblDiagnostico.Location = new Point(565, 187);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(81, 19);
            lblDiagnostico.TabIndex = 7;
            lblDiagnostico.Text = "Diagnóstico";
            // 
            // lblTratamiento
            // 
            lblTratamiento.Anchor = AnchorStyles.Right;
            lblTratamiento.AutoSize = true;
            lblTratamiento.Enabled = false;
            lblTratamiento.Font = new Font("Segoe UI", 10F);
            lblTratamiento.ForeColor = SystemColors.Window;
            lblTratamiento.Location = new Point(565, 331);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(82, 19);
            lblTratamiento.TabIndex = 8;
            lblTratamiento.Text = "Tratamiento";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.Anchor = AnchorStyles.Right;
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Enabled = false;
            lblPrecioFinal.Font = new Font("Segoe UI", 10F);
            lblPrecioFinal.ForeColor = SystemColors.Window;
            lblPrecioFinal.Location = new Point(565, 476);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(78, 19);
            lblPrecioFinal.TabIndex = 9;
            lblPrecioFinal.Text = "Precio Final";
            // 
            // txtIdTurno
            // 
            txtIdTurno.Anchor = AnchorStyles.Right;
            txtIdTurno.BackColor = Color.FromArgb(120, 120, 160);
            txtIdTurno.BorderStyle = BorderStyle.FixedSingle;
            txtIdTurno.Enabled = false;
            txtIdTurno.Font = new Font("Segoe UI", 10F);
            txtIdTurno.ForeColor = SystemColors.Window;
            txtIdTurno.Location = new Point(570, 101);
            txtIdTurno.MaxLength = 50;
            txtIdTurno.Name = "txtIdTurno";
            txtIdTurno.ShortcutsEnabled = false;
            txtIdTurno.Size = new Size(247, 25);
            txtIdTurno.TabIndex = 10;
            txtIdTurno.TextChanged += txtIdTurno_TextChanged;
            txtIdTurno.KeyPress += txtIdTurno_KeyPress;
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Anchor = AnchorStyles.Right;
            txtMotivoConsulta.BackColor = Color.FromArgb(120, 120, 160);
            txtMotivoConsulta.BorderStyle = BorderStyle.FixedSingle;
            txtMotivoConsulta.Enabled = false;
            txtMotivoConsulta.Font = new Font("Segoe UI", 10F);
            txtMotivoConsulta.ForeColor = SystemColors.Window;
            txtMotivoConsulta.Location = new Point(570, 155);
            txtMotivoConsulta.MaxLength = 200;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new Size(247, 25);
            txtMotivoConsulta.TabIndex = 11;
            txtMotivoConsulta.TextChanged += txtMotivoConsulta_TextChanged;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Anchor = AnchorStyles.Right;
            txtDiagnostico.BackColor = Color.FromArgb(120, 120, 160);
            txtDiagnostico.BorderStyle = BorderStyle.FixedSingle;
            txtDiagnostico.Enabled = false;
            txtDiagnostico.Font = new Font("Segoe UI", 10F);
            txtDiagnostico.ForeColor = SystemColors.Window;
            txtDiagnostico.Location = new Point(570, 209);
            txtDiagnostico.MaxLength = 500;
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(247, 115);
            txtDiagnostico.TabIndex = 12;
            txtDiagnostico.TextChanged += txtDiagnostico_TextChanged;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Anchor = AnchorStyles.Right;
            txtTratamiento.BackColor = Color.FromArgb(120, 120, 160);
            txtTratamiento.BorderStyle = BorderStyle.FixedSingle;
            txtTratamiento.Enabled = false;
            txtTratamiento.Font = new Font("Segoe UI", 10F);
            txtTratamiento.ForeColor = SystemColors.Window;
            txtTratamiento.Location = new Point(570, 353);
            txtTratamiento.MaxLength = 500;
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(247, 115);
            txtTratamiento.TabIndex = 13;
            txtTratamiento.TextChanged += txtTratamiento_TextChanged;
            // 
            // txtPrecioFinal
            // 
            txtPrecioFinal.Anchor = AnchorStyles.Right;
            txtPrecioFinal.BackColor = Color.FromArgb(120, 120, 160);
            txtPrecioFinal.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioFinal.Enabled = false;
            txtPrecioFinal.Font = new Font("Segoe UI", 10F);
            txtPrecioFinal.ForeColor = SystemColors.Window;
            txtPrecioFinal.Location = new Point(570, 497);
            txtPrecioFinal.MaxLength = 100;
            txtPrecioFinal.Name = "txtPrecioFinal";
            txtPrecioFinal.ShortcutsEnabled = false;
            txtPrecioFinal.Size = new Size(247, 25);
            txtPrecioFinal.TabIndex = 14;
            txtPrecioFinal.TextChanged += txtPrecioFinal_TextChanged;
            txtPrecioFinal.KeyPress += txtPrecioFinal_KeyPress;
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
            btnAceptar.TabIndex = 15;
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
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecioFinal);
            Controls.Add(txtTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(txtIdTurno);
            Controls.Add(lblPrecioFinal);
            Controls.Add(lblTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblMotivoConsulta);
            Controls.Add(lblIdTurno);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltroHistorial);
            Controls.Add(dgvHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            SizeChanged += FrmHistorial_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorial;
        private TextBox txtFiltroHistorial;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblIdTurno;
        private Label lblMotivoConsulta;
        private Label lblDiagnostico;
        private Label lblTratamiento;
        private Label lblPrecioFinal;
        private TextBox txtIdTurno;
        private TextBox txtMotivoConsulta;
        private TextBox txtDiagnostico;
        private TextBox txtTratamiento;
        private TextBox txtPrecioFinal;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}