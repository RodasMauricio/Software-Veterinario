namespace Veterinaria
{
    partial class FrmPaciente
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvPaciente = new DataGridView();
            txtFiltroPaciente = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            lblEspecie = new Label();
            lblRaza = new Label();
            lblCliente = new Label();
            lblFechaNacimiento = new Label();
            lblSexo = new Label();
            lblColorPelaje = new Label();
            lblPeso = new Label();
            lblObservaciones = new Label();
            txtNombre = new TextBox();
            txtSexo = new TextBox();
            txtColorPelaje = new TextBox();
            txtPeso = new TextBox();
            txtObservaciones = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnAgregarEspecie = new Button();
            btnAgregarRaza = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // dgvPaciente
            // 
            dgvPaciente.AllowUserToResizeColumns = false;
            dgvPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaciente.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvPaciente.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvPaciente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPaciente.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPaciente.EnableHeadersVisualStyles = false;
            dgvPaciente.Location = new Point(12, 46);
            dgvPaciente.MultiSelect = false;
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPaciente.RowHeadersVisible = false;
            dgvPaciente.ScrollBars = ScrollBars.Horizontal;
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.Size = new Size(523, 520);
            dgvPaciente.TabIndex = 0;
            // 
            // txtFiltroPaciente
            // 
            txtFiltroPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltroPaciente.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroPaciente.Font = new Font("Segoe UI", 10F);
            txtFiltroPaciente.ForeColor = SystemColors.Window;
            txtFiltroPaciente.Location = new Point(12, 11);
            txtFiltroPaciente.Name = "txtFiltroPaciente";
            txtFiltroPaciente.Size = new Size(261, 25);
            txtFiltroPaciente.TabIndex = 1;
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
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
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
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(567, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // lblEspecie
            // 
            lblEspecie.Anchor = AnchorStyles.Right;
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 10F);
            lblEspecie.ForeColor = SystemColors.Window;
            lblEspecie.Location = new Point(567, 135);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(53, 19);
            lblEspecie.TabIndex = 8;
            lblEspecie.Text = "Especie";
            // 
            // lblRaza
            // 
            lblRaza.Anchor = AnchorStyles.Right;
            lblRaza.AutoSize = true;
            lblRaza.Font = new Font("Segoe UI", 10F);
            lblRaza.ForeColor = SystemColors.Window;
            lblRaza.Location = new Point(567, 178);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(37, 19);
            lblRaza.TabIndex = 9;
            lblRaza.Text = "Raza";
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.ForeColor = SystemColors.Window;
            lblCliente.Location = new Point(567, 220);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(51, 19);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "Cliente";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.Anchor = AnchorStyles.Right;
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 10F);
            lblFechaNacimiento.ForeColor = SystemColors.Window;
            lblFechaNacimiento.Location = new Point(567, 262);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(136, 19);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblSexo
            // 
            lblSexo.Anchor = AnchorStyles.Right;
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 10F);
            lblSexo.ForeColor = SystemColors.Window;
            lblSexo.Location = new Point(567, 304);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(37, 19);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo";
            // 
            // lblColorPelaje
            // 
            lblColorPelaje.Anchor = AnchorStyles.Right;
            lblColorPelaje.AutoSize = true;
            lblColorPelaje.Font = new Font("Segoe UI", 10F);
            lblColorPelaje.ForeColor = SystemColors.Window;
            lblColorPelaje.Location = new Point(567, 346);
            lblColorPelaje.Name = "lblColorPelaje";
            lblColorPelaje.Size = new Size(81, 19);
            lblColorPelaje.TabIndex = 13;
            lblColorPelaje.Text = "Color pelaje";
            // 
            // lblPeso
            // 
            lblPeso.Anchor = AnchorStyles.Right;
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 10F);
            lblPeso.ForeColor = SystemColors.Window;
            lblPeso.Location = new Point(567, 391);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(37, 19);
            lblPeso.TabIndex = 14;
            lblPeso.Text = "Peso";
            // 
            // lblObservaciones
            // 
            lblObservaciones.Anchor = AnchorStyles.Right;
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 10F);
            lblObservaciones.ForeColor = SystemColors.Window;
            lblObservaciones.Location = new Point(566, 437);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(98, 19);
            lblObservaciones.TabIndex = 15;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(120, 120, 160);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.Window;
            txtNombre.Location = new Point(571, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 25);
            txtNombre.TabIndex = 16;
            // 
            // txtSexo
            // 
            txtSexo.Anchor = AnchorStyles.Right;
            txtSexo.BackColor = Color.FromArgb(120, 120, 160);
            txtSexo.BorderStyle = BorderStyle.FixedSingle;
            txtSexo.Font = new Font("Segoe UI", 10F);
            txtSexo.ForeColor = SystemColors.Window;
            txtSexo.Location = new Point(571, 322);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(228, 25);
            txtSexo.TabIndex = 17;
            // 
            // txtColorPelaje
            // 
            txtColorPelaje.Anchor = AnchorStyles.Right;
            txtColorPelaje.BackColor = Color.FromArgb(120, 120, 160);
            txtColorPelaje.BorderStyle = BorderStyle.FixedSingle;
            txtColorPelaje.Font = new Font("Segoe UI", 10F);
            txtColorPelaje.ForeColor = SystemColors.Window;
            txtColorPelaje.Location = new Point(571, 366);
            txtColorPelaje.Name = "txtColorPelaje";
            txtColorPelaje.Size = new Size(228, 25);
            txtColorPelaje.TabIndex = 18;
            // 
            // txtPeso
            // 
            txtPeso.Anchor = AnchorStyles.Right;
            txtPeso.BackColor = Color.FromArgb(120, 120, 160);
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 10F);
            txtPeso.ForeColor = SystemColors.Window;
            txtPeso.Location = new Point(571, 410);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(228, 25);
            txtPeso.TabIndex = 19;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Anchor = AnchorStyles.Right;
            txtObservaciones.BackColor = Color.FromArgb(120, 120, 160);
            txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
            txtObservaciones.Font = new Font("Segoe UI", 10F);
            txtObservaciones.ForeColor = SystemColors.Window;
            txtObservaciones.Location = new Point(571, 455);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(228, 25);
            txtObservaciones.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(120, 120, 160);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(571, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 25);
            comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.BackColor = Color.FromArgb(120, 120, 160);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.ForeColor = SystemColors.Window;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(571, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 25);
            comboBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.BackColor = Color.FromArgb(120, 120, 160);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 10F);
            comboBox3.ForeColor = SystemColors.Window;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(571, 237);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(228, 25);
            comboBox3.TabIndex = 23;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Right;
            dtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 10F);
            dtpFechaNacimiento.Location = new Point(571, 280);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 23);
            dtpFechaNacimiento.TabIndex = 24;
            // 
            // btnAgregarEspecie
            // 
            btnAgregarEspecie.Anchor = AnchorStyles.Right;
            btnAgregarEspecie.Location = new Point(805, 154);
            btnAgregarEspecie.Name = "btnAgregarEspecie";
            btnAgregarEspecie.Size = new Size(21, 23);
            btnAgregarEspecie.TabIndex = 25;
            btnAgregarEspecie.Text = "+";
            btnAgregarEspecie.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRaza
            // 
            btnAgregarRaza.Anchor = AnchorStyles.Right;
            btnAgregarRaza.Location = new Point(805, 196);
            btnAgregarRaza.Name = "btnAgregarRaza";
            btnAgregarRaza.Size = new Size(21, 23);
            btnAgregarRaza.TabIndex = 26;
            btnAgregarRaza.Text = "+";
            btnAgregarRaza.UseVisualStyleBackColor = true;
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(btnAgregarRaza);
            Controls.Add(btnAgregarEspecie);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtObservaciones);
            Controls.Add(txtPeso);
            Controls.Add(txtColorPelaje);
            Controls.Add(txtSexo);
            Controls.Add(txtNombre);
            Controls.Add(lblObservaciones);
            Controls.Add(lblPeso);
            Controls.Add(lblColorPelaje);
            Controls.Add(lblSexo);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblCliente);
            Controls.Add(lblRaza);
            Controls.Add(lblEspecie);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltroPaciente);
            Controls.Add(dgvPaciente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPaciente";
            Text = "FrmPaciente";
            Load += FrmPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPaciente;
        private TextBox txtFiltroPaciente;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombre;
        private Label lblEspecie;
        private Label lblRaza;
        private Label lblCliente;
        private Label lblFechaNacimiento;
        private Label lblSexo;
        private Label lblColorPelaje;
        private Label lblPeso;
        private Label lblObservaciones;
        private TextBox txtNombre;
        private TextBox txtSexo;
        private TextBox txtColorPelaje;
        private TextBox txtPeso;
        private TextBox txtObservaciones;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAgregarEspecie;
        private Button btnAgregarRaza;
    }
}