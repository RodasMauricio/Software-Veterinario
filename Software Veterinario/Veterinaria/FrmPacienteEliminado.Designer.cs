namespace Veterinaria
{
    partial class FrmPacienteEliminado
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
            dgvPacienteEliminado = new DataGridView();
            txtFiltroPacienteEliminado = new TextBox();
            btnRecuperar = new Button();
            pnBarra = new Panel();
            lblX = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacienteEliminado).BeginInit();
            pnBarra.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPacienteEliminado
            // 
            dgvPacienteEliminado.AllowUserToResizeColumns = false;
            dgvPacienteEliminado.AllowUserToResizeRows = false;
            dgvPacienteEliminado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPacienteEliminado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacienteEliminado.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvPacienteEliminado.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvPacienteEliminado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPacienteEliminado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacienteEliminado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPacienteEliminado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPacienteEliminado.EnableHeadersVisualStyles = false;
            dgvPacienteEliminado.Location = new Point(13, 73);
            dgvPacienteEliminado.MultiSelect = false;
            dgvPacienteEliminado.Name = "dgvPacienteEliminado";
            dgvPacienteEliminado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPacienteEliminado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPacienteEliminado.RowHeadersVisible = false;
            dgvPacienteEliminado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacienteEliminado.Size = new Size(644, 410);
            dgvPacienteEliminado.TabIndex = 3;
            dgvPacienteEliminado.SelectionChanged += dgvPacienteEliminado_SelectionChanged;
            // 
            // txtFiltroPacienteEliminado
            // 
            txtFiltroPacienteEliminado.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroPacienteEliminado.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroPacienteEliminado.Font = new Font("Segoe UI", 10F);
            txtFiltroPacienteEliminado.ForeColor = SystemColors.Window;
            txtFiltroPacienteEliminado.Location = new Point(13, 40);
            txtFiltroPacienteEliminado.Name = "txtFiltroPacienteEliminado";
            txtFiltroPacienteEliminado.Size = new Size(290, 25);
            txtFiltroPacienteEliminado.TabIndex = 4;
            txtFiltroPacienteEliminado.TextChanged += txtFiltroPacienteEliminado_TextChanged;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.SeaGreen;
            btnRecuperar.FlatAppearance.BorderSize = 0;
            btnRecuperar.FlatStyle = FlatStyle.Flat;
            btnRecuperar.ForeColor = SystemColors.Window;
            btnRecuperar.Location = new Point(582, 44);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(75, 23);
            btnRecuperar.TabIndex = 11;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // pnBarra
            // 
            pnBarra.Controls.Add(lblX);
            pnBarra.Dock = DockStyle.Top;
            pnBarra.Location = new Point(0, 0);
            pnBarra.Name = "pnBarra";
            pnBarra.Size = new Size(669, 30);
            pnBarra.TabIndex = 12;
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
            lblX.TabIndex = 10;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
            // 
            // FrmPacienteEliminado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(669, 502);
            Controls.Add(pnBarra);
            Controls.Add(btnRecuperar);
            Controls.Add(txtFiltroPacienteEliminado);
            Controls.Add(dgvPacienteEliminado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPacienteEliminado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPacienteEliminado";
            Load += FrmPacienteEliminado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacienteEliminado).EndInit();
            pnBarra.ResumeLayout(false);
            pnBarra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacienteEliminado;
        private TextBox txtFiltroPacienteEliminado;
        private Button btnRecuperar;
        private Panel pnBarra;
        private Label lblX;
    }
}