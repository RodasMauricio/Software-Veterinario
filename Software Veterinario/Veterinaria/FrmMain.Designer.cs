namespace Veterinaria
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuVertical = new Panel();
            btnServicios = new Button();
            btnVeterinarios = new Button();
            btnHistorial = new Button();
            btnTurnos = new Button();
            btnPacientes = new Button();
            btnClientes = new Button();
            button1 = new Button();
            barraTitulo = new Panel();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            btnNormal = new Button();
            btnX = new Button();
            btnSlide = new Label();
            panelContenedor = new Panel();
            menuVertical.SuspendLayout();
            barraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menuVertical
            // 
            menuVertical.BackColor = Color.FromArgb(40, 40, 60);
            menuVertical.Controls.Add(btnServicios);
            menuVertical.Controls.Add(btnVeterinarios);
            menuVertical.Controls.Add(btnHistorial);
            menuVertical.Controls.Add(btnTurnos);
            menuVertical.Controls.Add(btnPacientes);
            menuVertical.Controls.Add(btnClientes);
            menuVertical.Controls.Add(button1);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(170, 640);
            menuVertical.TabIndex = 0;
            // 
            // btnServicios
            // 
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 12F);
            btnServicios.ForeColor = SystemColors.Window;
            btnServicios.Image = (Image)resources.GetObject("btnServicios.Image");
            btnServicios.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicios.Location = new Point(0, 377);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(170, 38);
            btnServicios.TabIndex = 6;
            btnServicios.Text = "Servicios";
            btnServicios.TextAlign = ContentAlignment.MiddleRight;
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnVeterinarios
            // 
            btnVeterinarios.FlatAppearance.BorderSize = 0;
            btnVeterinarios.FlatStyle = FlatStyle.Flat;
            btnVeterinarios.Font = new Font("Segoe UI", 12F);
            btnVeterinarios.ForeColor = SystemColors.Window;
            btnVeterinarios.Image = (Image)resources.GetObject("btnVeterinarios.Image");
            btnVeterinarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeterinarios.Location = new Point(0, 339);
            btnVeterinarios.Name = "btnVeterinarios";
            btnVeterinarios.Size = new Size(170, 38);
            btnVeterinarios.TabIndex = 5;
            btnVeterinarios.Text = "Veterinarios";
            btnVeterinarios.TextAlign = ContentAlignment.MiddleRight;
            btnVeterinarios.UseVisualStyleBackColor = true;
            btnVeterinarios.Click += btnVeterinarios_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 12F);
            btnHistorial.ForeColor = SystemColors.Window;
            btnHistorial.Image = (Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorial.Location = new Point(0, 301);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(170, 38);
            btnHistorial.TabIndex = 4;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleRight;
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderSize = 0;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Segoe UI", 12F);
            btnTurnos.ForeColor = SystemColors.Window;
            btnTurnos.Image = (Image)resources.GetObject("btnTurnos.Image");
            btnTurnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnos.Location = new Point(0, 263);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(170, 38);
            btnTurnos.TabIndex = 3;
            btnTurnos.Text = "Turnos";
            btnTurnos.TextAlign = ContentAlignment.MiddleRight;
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 12F);
            btnPacientes.ForeColor = SystemColors.Window;
            btnPacientes.Image = (Image)resources.GetObject("btnPacientes.Image");
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(0, 225);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(170, 38);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleRight;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F);
            btnClientes.ForeColor = SystemColors.Window;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 187);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(170, 38);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 9);
            button1.Name = "button1";
            button1.Size = new Size(177, 68);
            button1.TabIndex = 0;
            button1.Text = "VetApp";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(55, 55, 75);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnNormal);
            barraTitulo.Controls.Add(btnX);
            barraTitulo.Controls.Add(btnSlide);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(170, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(854, 35);
            barraTitulo.TabIndex = 1;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximizar.ForeColor = SystemColors.Window;
            btnMaximizar.Location = new Point(790, -9);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 46);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.Text = "🗖";
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.Window;
            btnMinimizar.Location = new Point(755, -9);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 44);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "_";
            btnMinimizar.TextAlign = ContentAlignment.TopCenter;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormal.FlatAppearance.BorderSize = 0;
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnNormal.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNormal.ForeColor = SystemColors.Window;
            btnNormal.Location = new Point(789, -11);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(30, 46);
            btnNormal.TabIndex = 2;
            btnNormal.Text = "🗗";
            btnNormal.UseVisualStyleBackColor = true;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnX
            // 
            btnX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.ForeColor = SystemColors.Window;
            btnX.Location = new Point(819, 0);
            btnX.Name = "btnX";
            btnX.Size = new Size(35, 35);
            btnX.TabIndex = 2;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnSlide
            // 
            btnSlide.AutoSize = true;
            btnSlide.BackColor = Color.Transparent;
            btnSlide.Font = new Font("Segoe UI Emoji", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSlide.ForeColor = SystemColors.Window;
            btnSlide.Location = new Point(2, 1);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 31);
            btnSlide.TabIndex = 2;
            btnSlide.Text = "☰";
            btnSlide.Click += btnSlide_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(170, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(854, 605);
            panelContenedor.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            ClientSize = new Size(1024, 640);
            Controls.Add(panelContenedor);
            Controls.Add(barraTitulo);
            Controls.Add(menuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            menuVertical.ResumeLayout(false);
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuVertical;
        private Panel barraTitulo;
        private Label btnSlide;
        private Button btnX;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Button btnNormal;
        private Panel panelContenedor;
        private Button button1;
        private Button btnTurnos;
        private Button btnPacientes;
        private Button btnClientes;
        private Button btnServicios;
        private Button btnVeterinarios;
        private Button btnHistorial;
    }
}