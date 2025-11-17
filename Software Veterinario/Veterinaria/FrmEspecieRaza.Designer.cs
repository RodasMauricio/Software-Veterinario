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
            textBox1 = new TextBox();
            lblX = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedad).BeginInit();
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
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(433, 208);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(214, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // cbEspecie
            // 
            cbEspecie.Enabled = false;
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Location = new Point(433, 272);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(214, 23);
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(120, 120, 160);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(13, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 25);
            textBox1.TabIndex = 11;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblX.ForeColor = SystemColors.Window;
            lblX.Location = new Point(646, -4);
            lblX.Name = "lblX";
            lblX.Size = new Size(25, 28);
            lblX.TabIndex = 8;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
            // 
            // FrmEspecieRaza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(669, 502);
            Controls.Add(textBox1);
            Controls.Add(lblEspecie);
            Controls.Add(lblDescripcion);
            Controls.Add(lblX);
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
            ((System.ComponentModel.ISupportInitialize)dgvPropiedad).EndInit();
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
        private TextBox textBox1;
        private Label lblX;
    }
}