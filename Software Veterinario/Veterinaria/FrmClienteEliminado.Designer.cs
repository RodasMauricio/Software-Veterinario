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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvClienteEliminado = new DataGridView();
            txtFiltroClienteEliminado = new TextBox();
            lblX = new Label();
            btnRecuperar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClienteEliminado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 30);
            panel1.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClienteEliminado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClienteEliminado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClienteEliminado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClienteEliminado.EnableHeadersVisualStyles = false;
            dgvClienteEliminado.Location = new Point(13, 73);
            dgvClienteEliminado.MultiSelect = false;
            dgvClienteEliminado.Name = "dgvClienteEliminado";
            dgvClienteEliminado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 74, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 120, 160);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClienteEliminado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClienteEliminado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmClienteEliminado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienteEliminado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvClienteEliminado;
        private TextBox txtFiltroClienteEliminado;
        private Label lblX;
        private Button btnRecuperar;
    }
}