namespace Alarme
{
    partial class Cronometro
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
            listCronometro = new ListBox();
            lblCronometro = new Label();
            Tempo = new System.Windows.Forms.Timer(components);
            btnInicio = new Button();
            btnRedefinir = new Button();
            btnVoltas = new Button();
            SuspendLayout();
            // 
            // listCronometro
            // 
            listCronometro.BackColor = Color.LightBlue;
            listCronometro.FormattingEnabled = true;
            listCronometro.Location = new Point(544, 31);
            listCronometro.Name = "listCronometro";
            listCronometro.Size = new Size(222, 264);
            listCronometro.TabIndex = 0;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(53, 88);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(292, 94);
            lblCronometro.TabIndex = 1;
            lblCronometro.Text = "--:--:--:---";
            // 
            // Tempo
            // 
            Tempo.Enabled = true;
            Tempo.Tick += Tempo_Tick;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(91, 253);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(115, 36);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Iniciar";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnRedefinir
            // 
            btnRedefinir.Location = new Point(151, 295);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(115, 36);
            btnRedefinir.TabIndex = 3;
            btnRedefinir.Text = "Redefinir";
            btnRedefinir.UseVisualStyleBackColor = true;
            btnRedefinir.Click += btnRedefinir_Click;
            // 
            // btnVoltas
            // 
            btnVoltas.Location = new Point(212, 253);
            btnVoltas.Name = "btnVoltas";
            btnVoltas.Size = new Size(115, 36);
            btnVoltas.TabIndex = 4;
            btnVoltas.Text = "Voltas";
            btnVoltas.UseVisualStyleBackColor = true;
            btnVoltas.Click += btnVoltas_Click;
            // 
            // Cronometro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(814, 342);
            Controls.Add(btnVoltas);
            Controls.Add(btnRedefinir);
            Controls.Add(btnInicio);
            Controls.Add(lblCronometro);
            Controls.Add(listCronometro);
            Name = "Cronometro";
            Text = "Cronometro";
            Load += Cronometro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCronometro;
        private Label lblCronometro;
        private System.Windows.Forms.Timer Tempo;
        private Button btnInicio;
        private Button btnRedefinir;
        private Button btnVoltas;
    }
}