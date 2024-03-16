namespace Alarme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnDespertador = new Button();
            btnTemporizador = new Button();
            btnCronometro = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            btnrelogio = new Button();
            lblAlarmeAtivo = new Label();
            lblhoraAtivado = new Label();
            lbAlarmeAtivdo = new Label();
            lblHome = new Label();
            panelHome = new Panel();
            panelDektop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.RoyalBlue;
            panelMenu.Controls.Add(btnDespertador);
            panelMenu.Controls.Add(btnTemporizador);
            panelMenu.Controls.Add(btnCronometro);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnrelogio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(159, 413);
            panelMenu.TabIndex = 2;
            // 
            // btnDespertador
            // 
            btnDespertador.BackColor = Color.CornflowerBlue;
            btnDespertador.FlatAppearance.BorderSize = 0;
            btnDespertador.FlatStyle = FlatStyle.Flat;
            btnDespertador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespertador.Location = new Point(0, 92);
            btnDespertador.Name = "btnDespertador";
            btnDespertador.Size = new Size(156, 60);
            btnDespertador.TabIndex = 4;
            btnDespertador.Text = "Despertador";
            btnDespertador.UseVisualStyleBackColor = false;
            btnDespertador.Click += btnDespertador_Click;
            // 
            // btnTemporizador
            // 
            btnTemporizador.BackColor = Color.CornflowerBlue;
            btnTemporizador.FlatAppearance.BorderSize = 0;
            btnTemporizador.FlatStyle = FlatStyle.Flat;
            btnTemporizador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTemporizador.Location = new Point(0, 152);
            btnTemporizador.Name = "btnTemporizador";
            btnTemporizador.Size = new Size(156, 60);
            btnTemporizador.TabIndex = 3;
            btnTemporizador.Text = "Temporizador";
            btnTemporizador.UseVisualStyleBackColor = false;
            btnTemporizador.Click += btnTemporizador_Click;
            // 
            // btnCronometro
            // 
            btnCronometro.BackColor = Color.CornflowerBlue;
            btnCronometro.FlatAppearance.BorderSize = 0;
            btnCronometro.FlatStyle = FlatStyle.Flat;
            btnCronometro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCronometro.Location = new Point(0, 212);
            btnCronometro.Name = "btnCronometro";
            btnCronometro.Size = new Size(156, 60);
            btnCronometro.TabIndex = 2;
            btnCronometro.Text = "Cronômetro";
            btnCronometro.UseVisualStyleBackColor = false;
            btnCronometro.Click += btnCronometro_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(159, 93);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnrelogio
            // 
            btnrelogio.BackColor = Color.CornflowerBlue;
            btnrelogio.FlatAppearance.BorderSize = 0;
            btnrelogio.FlatStyle = FlatStyle.Flat;
            btnrelogio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrelogio.Location = new Point(0, 272);
            btnrelogio.Name = "btnrelogio";
            btnrelogio.Size = new Size(156, 60);
            btnrelogio.TabIndex = 0;
            btnrelogio.Text = "Relogio";
            btnrelogio.UseVisualStyleBackColor = false;
            btnrelogio.Click += btnrelogio_Click;
            // 
            // lblAlarmeAtivo
            // 
            lblAlarmeAtivo.AutoSize = true;
            lblAlarmeAtivo.FlatStyle = FlatStyle.Flat;
            lblAlarmeAtivo.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeAtivo.Location = new Point(165, 128);
            lblAlarmeAtivo.Name = "lblAlarmeAtivo";
            lblAlarmeAtivo.Size = new Size(0, 112);
            lblAlarmeAtivo.TabIndex = 5;
            // 
            // lblhoraAtivado
            // 
            lblhoraAtivado.AutoSize = true;
            lblhoraAtivado.FlatStyle = FlatStyle.Flat;
            lblhoraAtivado.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhoraAtivado.Location = new Point(329, 288);
            lblhoraAtivado.Name = "lblhoraAtivado";
            lblhoraAtivado.Size = new Size(0, 61);
            lblhoraAtivado.TabIndex = 7;
            // 
            // lbAlarmeAtivdo
            // 
            lbAlarmeAtivdo.AutoSize = true;
            lbAlarmeAtivdo.Location = new Point(624, 319);
            lbAlarmeAtivdo.Name = "lbAlarmeAtivdo";
            lbAlarmeAtivdo.Size = new Size(0, 20);
            lbAlarmeAtivdo.TabIndex = 18;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.FlatStyle = FlatStyle.Flat;
            lblHome.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.Black;
            lblHome.Location = new Point(347, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(118, 41);
            lblHome.TabIndex = 0;
            lblHome.Text = "Home";
            lblHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.RoyalBlue;
            panelHome.Controls.Add(lblHome);
            panelHome.Dock = DockStyle.Top;
            panelHome.Location = new Point(159, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(854, 64);
            panelHome.TabIndex = 26;
            // 
            // panelDektop
            // 
            panelDektop.Dock = DockStyle.Fill;
            panelDektop.Location = new Point(159, 64);
            panelDektop.Name = "panelDektop";
            panelDektop.Size = new Size(854, 349);
            panelDektop.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 413);
            Controls.Add(panelDektop);
            Controls.Add(panelHome);
            Controls.Add(lbAlarmeAtivdo);
            Controls.Add(lblhoraAtivado);
            Controls.Add(lblAlarmeAtivo);
            Controls.Add(panelMenu);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private Button btnrelogio;
        private Label lblAlarmeAtivo;
        private Label lblhoraAtivado;
        private Label lbAlarmeAtivdo;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnDespertador;
        private Button btnTemporizador;
        private Button btnCronometro;
        private Label lblHome;
        private Panel panelHome;
        private Panel panelDektop;
    }
}
