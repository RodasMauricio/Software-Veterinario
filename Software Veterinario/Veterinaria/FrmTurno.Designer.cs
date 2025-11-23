namespace Veterinaria
{
    partial class FrmTurno
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
            dgvTurno = new DataGridView();
            lblPaciente = new Label();
            lblVeterinario = new Label();
            lblServicio = new Label();
            lblFecha = new Label();
            lblEstado = new Label();
            lblNotas = new Label();
            cbPaciente = new ComboBox();
            cbVeterinario = new ComboBox();
            cbServicio = new ComboBox();
            cbEstado = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtFiltroTurno = new TextBox();
            dtpTurno = new DateTimePicker();
            btnActualizar = new Button();
            lblHorario = new Label();
            cbHorario = new ComboBox();
            txtFiltroPaciente = new TextBox();
            txtNotas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTurno).BeginInit();
            SuspendLayout();
            // 
            // dgvTurno
            // 
            dgvTurno.AllowUserToResizeColumns = false;
            dgvTurno.AllowUserToResizeRows = false;
            dgvTurno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurno.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvTurno.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvTurno.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTurno.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTurno.EnableHeadersVisualStyles = false;
            dgvTurno.Location = new Point(12, 46);
            dgvTurno.MultiSelect = false;
            dgvTurno.Name = "dgvTurno";
            dgvTurno.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTurno.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTurno.RowHeadersVisible = false;
            dgvTurno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurno.Size = new Size(523, 520);
            dgvTurno.TabIndex = 0;
            dgvTurno.SelectionChanged += dgvTurno_SelectionChanged;
            // 
            // lblPaciente
            // 
            lblPaciente.Anchor = AnchorStyles.Right;
            lblPaciente.AutoSize = true;
            lblPaciente.Enabled = false;
            lblPaciente.Font = new Font("Segoe UI", 10F);
            lblPaciente.ForeColor = SystemColors.Window;
            lblPaciente.Location = new Point(563, 79);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(60, 19);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Paciente";
            // 
            // lblVeterinario
            // 
            lblVeterinario.Anchor = AnchorStyles.Right;
            lblVeterinario.AutoSize = true;
            lblVeterinario.Enabled = false;
            lblVeterinario.Font = new Font("Segoe UI", 10F);
            lblVeterinario.ForeColor = SystemColors.Window;
            lblVeterinario.Location = new Point(562, 132);
            lblVeterinario.Name = "lblVeterinario";
            lblVeterinario.Size = new Size(75, 19);
            lblVeterinario.TabIndex = 2;
            lblVeterinario.Text = "Veterinario";
            // 
            // lblServicio
            // 
            lblServicio.Anchor = AnchorStyles.Right;
            lblServicio.AutoSize = true;
            lblServicio.Enabled = false;
            lblServicio.Font = new Font("Segoe UI", 10F);
            lblServicio.ForeColor = SystemColors.Window;
            lblServicio.Location = new Point(562, 184);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(55, 19);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "Servicio";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Enabled = false;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = SystemColors.Window;
            lblFecha.Location = new Point(562, 237);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Enabled = false;
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.ForeColor = SystemColors.Window;
            lblEstado.Location = new Point(562, 342);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 19);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado";
            // 
            // lblNotas
            // 
            lblNotas.Anchor = AnchorStyles.Right;
            lblNotas.AutoSize = true;
            lblNotas.Enabled = false;
            lblNotas.Font = new Font("Segoe UI", 10F);
            lblNotas.ForeColor = SystemColors.Window;
            lblNotas.Location = new Point(562, 397);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(45, 19);
            lblNotas.TabIndex = 6;
            lblNotas.Text = "Notas";
            // 
            // cbPaciente
            // 
            cbPaciente.Anchor = AnchorStyles.Right;
            cbPaciente.BackColor = Color.FromArgb(120, 120, 160);
            cbPaciente.DropDownHeight = 90;
            cbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaciente.Enabled = false;
            cbPaciente.Font = new Font("Segoe UI", 10F);
            cbPaciente.ForeColor = SystemColors.Window;
            cbPaciente.FormattingEnabled = true;
            cbPaciente.IntegralHeight = false;
            cbPaciente.Location = new Point(567, 101);
            cbPaciente.MaxDropDownItems = 5;
            cbPaciente.Name = "cbPaciente";
            cbPaciente.Size = new Size(255, 25);
            cbPaciente.TabIndex = 7;
            // 
            // cbVeterinario
            // 
            cbVeterinario.Anchor = AnchorStyles.Right;
            cbVeterinario.BackColor = Color.FromArgb(120, 120, 160);
            cbVeterinario.DropDownHeight = 90;
            cbVeterinario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVeterinario.Enabled = false;
            cbVeterinario.Font = new Font("Segoe UI", 10F);
            cbVeterinario.ForeColor = SystemColors.Window;
            cbVeterinario.FormattingEnabled = true;
            cbVeterinario.IntegralHeight = false;
            cbVeterinario.Location = new Point(567, 155);
            cbVeterinario.MaxDropDownItems = 5;
            cbVeterinario.Name = "cbVeterinario";
            cbVeterinario.Size = new Size(255, 25);
            cbVeterinario.TabIndex = 8;
            // 
            // cbServicio
            // 
            cbServicio.Anchor = AnchorStyles.Right;
            cbServicio.BackColor = Color.FromArgb(120, 120, 160);
            cbServicio.DropDownHeight = 90;
            cbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServicio.Enabled = false;
            cbServicio.Font = new Font("Segoe UI", 10F);
            cbServicio.ForeColor = SystemColors.Window;
            cbServicio.FormattingEnabled = true;
            cbServicio.IntegralHeight = false;
            cbServicio.Location = new Point(567, 207);
            cbServicio.MaxDropDownItems = 5;
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(255, 25);
            cbServicio.TabIndex = 9;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Right;
            cbEstado.BackColor = Color.FromArgb(120, 120, 160);
            cbEstado.DropDownHeight = 90;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Enabled = false;
            cbEstado.Font = new Font("Segoe UI", 10F);
            cbEstado.ForeColor = SystemColors.Window;
            cbEstado.FormattingEnabled = true;
            cbEstado.IntegralHeight = false;
            cbEstado.Location = new Point(567, 363);
            cbEstado.MaxDropDownItems = 5;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(255, 25);
            cbEstado.TabIndex = 10;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Right;
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(567, 259);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(255, 23);
            dtpFecha.TabIndex = 12;
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
            btnAgregar.TabIndex = 13;
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
            btnModificar.TabIndex = 14;
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
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnAceptar.TabIndex = 16;
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
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtFiltroTurno
            // 
            txtFiltroTurno.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroTurno.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroTurno.Font = new Font("Segoe UI", 10F);
            txtFiltroTurno.ForeColor = SystemColors.Window;
            txtFiltroTurno.Location = new Point(12, 11);
            txtFiltroTurno.MaxLength = 100;
            txtFiltroTurno.Name = "txtFiltroTurno";
            txtFiltroTurno.Size = new Size(261, 25);
            txtFiltroTurno.TabIndex = 18;
            txtFiltroTurno.TextChanged += txtFiltroTurno_TextChanged;
            // 
            // dtpTurno
            // 
            dtpTurno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpTurno.Location = new Point(307, 13);
            dtpTurno.Name = "dtpTurno";
            dtpTurno.Size = new Size(228, 23);
            dtpTurno.TabIndex = 19;
            dtpTurno.ValueChanged += dtpTurno_ValueChanged;
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
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "↻";
            btnActualizar.TextAlign = ContentAlignment.TopCenter;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblHorario
            // 
            lblHorario.Anchor = AnchorStyles.Right;
            lblHorario.AutoSize = true;
            lblHorario.Enabled = false;
            lblHorario.Font = new Font("Segoe UI", 10F);
            lblHorario.ForeColor = SystemColors.Window;
            lblHorario.Location = new Point(562, 289);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(55, 19);
            lblHorario.TabIndex = 21;
            lblHorario.Text = "Horario";
            // 
            // cbHorario
            // 
            cbHorario.Anchor = AnchorStyles.Right;
            cbHorario.BackColor = Color.FromArgb(120, 120, 160);
            cbHorario.DropDownHeight = 90;
            cbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHorario.Enabled = false;
            cbHorario.Font = new Font("Segoe UI", 10F);
            cbHorario.ForeColor = SystemColors.Window;
            cbHorario.FormattingEnabled = true;
            cbHorario.IntegralHeight = false;
            cbHorario.Location = new Point(567, 310);
            cbHorario.MaxDropDownItems = 5;
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(255, 25);
            cbHorario.TabIndex = 22;
            // 
            // txtFiltroPaciente
            // 
            txtFiltroPaciente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFiltroPaciente.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroPaciente.Font = new Font("Segoe UI", 10F);
            txtFiltroPaciente.ForeColor = SystemColors.Window;
            txtFiltroPaciente.Location = new Point(274, 572);
            txtFiltroPaciente.MaxLength = 100;
            txtFiltroPaciente.Name = "txtFiltroPaciente";
            txtFiltroPaciente.Size = new Size(261, 25);
            txtFiltroPaciente.TabIndex = 23;
            txtFiltroPaciente.TextChanged += txtFiltroPaciente_TextChanged;
            // 
            // txtNotas
            // 
            txtNotas.Anchor = AnchorStyles.Right;
            txtNotas.BackColor = Color.FromArgb(120, 120, 160);
            txtNotas.BorderStyle = BorderStyle.FixedSingle;
            txtNotas.Enabled = false;
            txtNotas.Font = new Font("Segoe UI", 10F);
            txtNotas.ForeColor = SystemColors.Window;
            txtNotas.Location = new Point(567, 419);
            txtNotas.MaxLength = 250;
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(255, 75);
            txtNotas.TabIndex = 11;
            txtNotas.TextChanged += txtNotas_TextChanged;
            // 
            // FrmTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(txtFiltroPaciente);
            Controls.Add(cbHorario);
            Controls.Add(lblHorario);
            Controls.Add(btnActualizar);
            Controls.Add(dtpTurno);
            Controls.Add(txtFiltroTurno);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFecha);
            Controls.Add(txtNotas);
            Controls.Add(cbEstado);
            Controls.Add(cbServicio);
            Controls.Add(cbVeterinario);
            Controls.Add(cbPaciente);
            Controls.Add(lblNotas);
            Controls.Add(lblEstado);
            Controls.Add(lblFecha);
            Controls.Add(lblServicio);
            Controls.Add(lblVeterinario);
            Controls.Add(lblPaciente);
            Controls.Add(dgvTurno);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTurno";
            Text = "FrmTurno";
            Load += FrmTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurno;
        private Label lblPaciente;
        private Label lblVeterinario;
        private Label lblServicio;
        private Label lblFecha;
        private Label lblEstado;
        private Label lblNotas;
        private ComboBox cbPaciente;
        private ComboBox cbVeterinario;
        private ComboBox cbServicio;
        private ComboBox cbEstado;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtFiltroTurno;
        private DateTimePicker dtpTurno;
        private Button btnActualizar;
        private Label lblHorario;
        private ComboBox cbHorario;
        private TextBox txtFiltroPaciente;
        private TextBox txtNotas;
    }
}