namespace Alarme
{
    partial class Temporizador
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
            components = new System.ComponentModel.Container();
            lbTemporizador = new Label();
            btEditar = new Button();
            btnRedefinir = new Button();
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHora = new TextBox();
            txtMinnuto = new TextBox();
            txtSegundo = new TextBox();
            temporiza = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            linkLabel7 = new LinkLabel();
            SuspendLayout();
            // 
            // lbTemporizador
            // 
            lbTemporizador.AutoSize = true;
            lbTemporizador.Font = new Font("Tahoma", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTemporizador.Location = new Point(57, -1);
            lbTemporizador.Name = "lbTemporizador";
            lbTemporizador.Size = new Size(410, 145);
            lbTemporizador.TabIndex = 6;
            lbTemporizador.Text = "--:--:--";
            // 
            // btEditar
            // 
            btEditar.FlatAppearance.BorderSize = 2;
            btEditar.FlatStyle = FlatStyle.Flat;
            btEditar.ForeColor = Color.DarkSlateGray;
            btEditar.ImageAlign = ContentAlignment.TopCenter;
            btEditar.Location = new Point(156, 299);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(94, 29);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btnRedefinir
            // 
            btnRedefinir.FlatAppearance.BorderSize = 2;
            btnRedefinir.FlatStyle = FlatStyle.Flat;
            btnRedefinir.ForeColor = Color.DarkSlateGray;
            btnRedefinir.ImageAlign = ContentAlignment.TopCenter;
            btnRedefinir.Location = new Point(253, 299);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(94, 29);
            btnRedefinir.TabIndex = 4;
            btnRedefinir.Text = "Redefinir";
            btnRedefinir.UseVisualStyleBackColor = true;
            btnRedefinir.Click += btnRedefinir_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderSize = 2;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.DarkSlateGray;
            btnIniciar.ImageAlign = ContentAlignment.TopCenter;
            btnIniciar.Location = new Point(157, 184);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(189, 29);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 229);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "Horas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 229);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Minutos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 229);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Segundos";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(157, 256);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(48, 27);
            txtHora.TabIndex = 0;
            txtHora.Text = "01";
            txtHora.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMinnuto
            // 
            txtMinnuto.Location = new Point(215, 256);
            txtMinnuto.Name = "txtMinnuto";
            txtMinnuto.Size = new Size(48, 27);
            txtMinnuto.TabIndex = 1;
            txtMinnuto.Text = "01";
            txtMinnuto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(272, 256);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(48, 27);
            txtSegundo.TabIndex = 2;
            txtSegundo.Text = "00";
            txtSegundo.TextAlign = HorizontalAlignment.Center;
            // 
            // temporiza
            // 
            temporiza.Interval = 1000;
            temporiza.Tick += temporiza_Tick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(592, 34);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 28);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "5 Minutos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F);
            linkLabel2.Location = new Point(592, 61);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 28);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "10 Minutos";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 12F);
            linkLabel3.Location = new Point(592, 86);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(111, 28);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "15 Minutos";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Segoe UI", 12F);
            linkLabel4.Location = new Point(592, 110);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(111, 28);
            linkLabel4.TabIndex = 10;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "60 Minutos";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Segoe UI", 12F);
            linkLabel5.Location = new Point(592, 134);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(122, 28);
            linkLabel5.TabIndex = 11;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "120 Minutos";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Font = new Font("Segoe UI", 12F);
            linkLabel6.Location = new Point(592, 162);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(122, 28);
            linkLabel6.TabIndex = 12;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "240 Minutos";
            linkLabel6.LinkClicked += linkLabel6_LinkClicked;
            // 
            // linkLabel7
            // 
            linkLabel7.AutoSize = true;
            linkLabel7.Font = new Font("Segoe UI", 12F);
            linkLabel7.Location = new Point(592, 190);
            linkLabel7.Name = "linkLabel7";
            linkLabel7.Size = new Size(122, 28);
            linkLabel7.TabIndex = 13;
            linkLabel7.TabStop = true;
            linkLabel7.Text = "350 Minutos";
            linkLabel7.LinkClicked += linkLabel7_LinkClicked;
            // 
            // Temporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(822, 342);
            Controls.Add(linkLabel7);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(txtSegundo);
            Controls.Add(txtMinnuto);
            Controls.Add(txtHora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(btnRedefinir);
            Controls.Add(btEditar);
            Controls.Add(lbTemporizador);
            Name = "Temporizador";
            Text = "Temporizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTemporizador;
        private Button btEditar;
        private Button btnRedefinir;
        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHora;
        private TextBox txtMinnuto;
        private TextBox txtSegundo;
        private System.Windows.Forms.Timer temporiza;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
    }
}