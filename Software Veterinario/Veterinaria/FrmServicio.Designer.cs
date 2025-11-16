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
            dgvServicio.Location = new Point(157, 42);
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
            // 
            // FrmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(854, 605);
            Controls.Add(dgvServicio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmServicio";
            Text = "FrmServicio";
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServicio;
    }
}