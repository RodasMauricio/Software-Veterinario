namespace Veterinaria
{
    partial class FrmEspecieRaza
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
            dgvPropiedad = new DataGridView();
            txtDescripcion = new TextBox();
            cbEspecie = new ComboBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblDescripcion = new Label();
            lblEspecie = new Label();
            txtFiltro = new TextBox();
            lblX = new Label();
            barraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedad).BeginInit();
            barraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPropiedad
            // 
            dgvPropiedad.AllowUserToResizeColumns = false;
            dgvPropiedad.AllowUserToResizeRows = false;
            dgvPropiedad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPropiedad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPropiedad.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvPropiedad.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvPropiedad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPropiedad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPropiedad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPropiedad.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPropiedad.EnableHeadersVisualStyles = false;
            dgvPropiedad.Location = new Point(13, 73);
            dgvPropiedad.MultiSelect = false;
            dgvPropiedad.Name = "dgvPropiedad";
            dgvPropiedad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPropiedad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPropiedad.RowHeadersVisible = false;
            dgvPropiedad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropiedad.Size = new Size(398, 410);
            dgvPropiedad.TabIndex = 0;
            dgvPropiedad.SelectionChanged += dgvPropiedad_SelectionChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(120, 120, 160);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = SystemColors.Window;
            txtDescripcion.Location = new Point(433, 208);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(214, 25);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // cbEspecie
            // 
            cbEspecie.BackColor = Color.FromArgb(120, 120, 160);
            cbEspecie.DropDownHeight = 90;
            cbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEspecie.Enabled = false;
            cbEspecie.Font = new Font("Segoe UI", 10F);
            cbEspecie.ForeColor = SystemColors.Window;
            cbEspecie.FormattingEnabled = true;
            cbEspecie.IntegralHeight = false;
            cbEspecie.Location = new Point(433, 272);
            cbEspecie.MaxDropDownItems = 5;
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(214, 25);
            cbEspecie.TabIndex = 2;
            cbEspecie.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(420, 39);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(120, 120, 160);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.Window;
            btnModificar.Location = new Point(503, 39);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(585, 39);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(120, 120, 160);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = SystemColors.Window;
            btnAceptar.Location = new Point(457, 460);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(120, 120, 160);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(549, 460);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Enabled = false;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = SystemColors.Window;
            lblDescripcion.Location = new Point(429, 186);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(79, 19);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripción";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Enabled = false;
            lblEspecie.Font = new Font("Segoe UI", 10F);
            lblEspecie.ForeColor = SystemColors.Window;
            lblEspecie.Location = new Point(429, 250);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(53, 19);
            lblEspecie.TabIndex = 10;
            lblEspecie.Text = "Especie";
            lblEspecie.Visible = false;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Font = new Font("Segoe UI", 10F);
            txtFiltro.ForeColor = SystemColors.Window;
            txtFiltro.Location = new Point(13, 40);
            txtFiltro.MaxLength = 100;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(290, 25);
            txtFiltro.TabIndex = 11;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.FlatStyle = FlatStyle.Flat;
            lblX.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblX.ForeColor = SystemColors.Window;
            lblX.Location = new Point(645, -2);
            lblX.Name = "lblX";
            lblX.Size = new Size(25, 28);
            lblX.TabIndex = 8;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(55, 55, 75);
            barraTitulo.Controls.Add(lblX);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(669, 30);
            barraTitulo.TabIndex = 12;
            // 
            // FrmEspecieRaza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(669, 502);
            Controls.Add(barraTitulo);
            Controls.Add(txtFiltro);
            Controls.Add(lblEspecie);
            Controls.Add(lblDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(cbEspecie);
            Controls.Add(txtDescripcion);
            Controls.Add(dgvPropiedad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEspecieRaza";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEspecieRaza";
            Load += FrmEspecieRaza_Load;
            SizeChanged += FrmEspecieRaza_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgvPropiedad).EndInit();
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPropiedad;
        private TextBox txtDescripcion;
        private ComboBox cbEspecie;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblDescripcion;
        private Label lblEspecie;
        private TextBox txtFiltro;
        private Label lblX;
        private Panel barraTitulo;
    }
}