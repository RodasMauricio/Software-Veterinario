namespace Veterinaria
{
    partial class FrmVeterinario
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
            dgvVeterinario = new DataGridView();
            lblNombre = new Label();
            lblMatricula = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVeterinario).BeginInit();
            SuspendLayout();
            // 
            // dgvVeterinario
            // 
            dgvVeterinario.AllowUserToResizeColumns = false;
            dgvVeterinario.AllowUserToResizeRows = false;
            dgvVeterinario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVeterinario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeterinario.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvVeterinario.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvVeterinario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVeterinario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVeterinario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVeterinario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVeterinario.EnableHeadersVisualStyles = false;
            dgvVeterinario.Location = new Point(12, 46);
            dgvVeterinario.MultiSelect = false;
            dgvVeterinario.Name = "dgvVeterinario";
            dgvVeterinario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVeterinario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVeterinario.RowHeadersVisible = false;
            dgvVeterinario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeterinario.Size = new Size(523, 520);
            dgvVeterinario.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(567, 182);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 10F);
            lblMatricula.ForeColor = SystemColors.Window;
            lblMatricula.Location = new Point(566, 236);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(66, 19);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matrícula";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = SystemColors.Window;
            lblEmail.Location = new Point(566, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F);
            lblTelefono.ForeColor = SystemColors.Window;
            lblTelefono.Location = new Point(566, 340);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(60, 19);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(120, 120, 160);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = SystemColors.Window;
            txtNombre.Location = new Point(571, 204);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 25);
            txtNombre.TabIndex = 5;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.FromArgb(120, 120, 160);
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Font = new Font("Segoe UI", 10F);
            txtMatricula.ForeColor = SystemColors.Window;
            txtMatricula.Location = new Point(571, 258);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(247, 25);
            txtMatricula.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(120, 120, 160);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(571, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 25);
            txtEmail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(120, 120, 160);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.ForeColor = SystemColors.Window;
            txtTelefono.Location = new Point(571, 362);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(247, 25);
            txtTelefono.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = SystemColors.Window;
            btnAgregar.Location = new Point(573, 11);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(120, 120, 160);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.Window;
            btnModificar.Location = new Point(654, 11);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.Location = new Point(735, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(120, 120, 160);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = SystemColors.Window;
            btnAceptar.Location = new Point(609, 543);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(120, 120, 160);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(706, 543);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(120, 120, 160);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(16, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 25);
            textBox1.TabIndex = 14;
            // 
            // FrmVeterinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtMatricula);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblMatricula);
            Controls.Add(lblNombre);
            Controls.Add(dgvVeterinario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVeterinario";
            Text = "FrmVeterinario";
            Load += FrmVeterinario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeterinario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVeterinario;
        private Label lblNombre;
        private Label lblMatricula;
        private Label lblEmail;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtMatricula;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox textBox1;
    }
}