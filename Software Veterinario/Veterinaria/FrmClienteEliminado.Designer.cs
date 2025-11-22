namespace Veterinaria
{
    partial class FrmClienteEliminado
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
            pnBarra = new Panel();
            dgvClienteEliminado = new DataGridView();
            txtFiltroClienteEliminado = new TextBox();
            lblX = new Label();
            btnRecuperar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClienteEliminado).BeginInit();
            SuspendLayout();
            // 
            // pnBarra
            // 
            pnBarra.Dock = DockStyle.Top;
            pnBarra.Location = new Point(0, 0);
            pnBarra.Name = "pnBarra";
            pnBarra.Size = new Size(669, 30);
            pnBarra.TabIndex = 1;
            // 
            // dgvClienteEliminado
            // 
            dgvClienteEliminado.AllowUserToResizeColumns = false;
            dgvClienteEliminado.AllowUserToResizeRows = false;
            dgvClienteEliminado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClienteEliminado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClienteEliminado.BackgroundColor = Color.FromArgb(120, 120, 160);
            dgvClienteEliminado.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvClienteEliminado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClienteEliminado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClienteEliminado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvClienteEliminado.DefaultCellStyle = dataGridViewCellStyle5;
            dgvClienteEliminado.EnableHeadersVisualStyles = false;
            dgvClienteEliminado.Location = new Point(13, 73);
            dgvClienteEliminado.MultiSelect = false;
            dgvClienteEliminado.Name = "dgvClienteEliminado";
            dgvClienteEliminado.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClienteEliminado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvClienteEliminado.RowHeadersVisible = false;
            dgvClienteEliminado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClienteEliminado.Size = new Size(644, 410);
            dgvClienteEliminado.TabIndex = 2;
            dgvClienteEliminado.SelectionChanged += dgvClienteEliminado_SelectionChanged;
            // 
            // txtFiltroClienteEliminado
            // 
            txtFiltroClienteEliminado.BackColor = Color.FromArgb(120, 120, 160);
            txtFiltroClienteEliminado.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroClienteEliminado.Font = new Font("Segoe UI", 10F);
            txtFiltroClienteEliminado.ForeColor = SystemColors.Window;
            txtFiltroClienteEliminado.Location = new Point(13, 40);
            txtFiltroClienteEliminado.Name = "txtFiltroClienteEliminado";
            txtFiltroClienteEliminado.Size = new Size(290, 25);
            txtFiltroClienteEliminado.TabIndex = 3;
            txtFiltroClienteEliminado.TextChanged += txtFiltroClienteEliminado_TextChanged;
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
            lblX.TabIndex = 9;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
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
            btnRecuperar.TabIndex = 10;
            btnRecuperar.Text = "Recuperar";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // FrmClienteEliminado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(669, 502);
            Controls.Add(btnRecuperar);
            Controls.Add(lblX);
            Controls.Add(txtFiltroClienteEliminado);
            Controls.Add(dgvClienteEliminado);
            Controls.Add(pnBarra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClienteEliminado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmClienteEliminado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienteEliminado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnBarra;
        private DataGridView dgvClienteEliminado;
        private TextBox txtFiltroClienteEliminado;
        private Label lblX;
        private Button btnRecuperar;
    }
}