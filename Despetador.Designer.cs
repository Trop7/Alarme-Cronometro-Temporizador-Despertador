namespace Alarme
{
    partial class Despetador
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
            lblalarme = new Label();
            label1 = new Label();
            cbSegundos = new ComboBox();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            cbMinuto = new ComboBox();
            cbHora = new ComboBox();
            listTempo = new ListBox();
            LblData = new Label();
            lblHora = new Label();
            btnAlarme = new Button();
            label5 = new Label();
            label2 = new Label();
            labeltempo = new System.Windows.Forms.Timer(components);
            tempo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblalarme
            // 
            lblalarme.AutoSize = true;
            lblalarme.BackColor = Color.Transparent;
            lblalarme.FlatStyle = FlatStyle.Flat;
            lblalarme.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblalarme.ForeColor = Color.Black;
            lblalarme.Location = new Point(475, 153);
            lblalarme.Name = "lblalarme";
            lblalarme.Size = new Size(61, 17);
            lblalarme.TabIndex = 36;
            lblalarme.Text = "Alarme!! ";
            lblalarme.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(361, 109);
            label1.Name = "label1";
            label1.Size = new Size(20, 23);
            label1.TabIndex = 35;
            label1.Text = "S";
            // 
            // cbSegundos
            // 
            cbSegundos.BackColor = Color.Pink;
            cbSegundos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSegundos.FormattingEnabled = true;
            cbSegundos.Location = new Point(347, 134);
            cbSegundos.Name = "cbSegundos";
            cbSegundos.Size = new Size(50, 36);
            cbSegundos.TabIndex = 28;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(12, 143);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(104, 27);
            dateTimePicker.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(299, 108);
            label4.Name = "label4";
            label4.Size = new Size(26, 23);
            label4.TabIndex = 33;
            label4.Text = "M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(240, 109);
            label3.Name = "label3";
            label3.Size = new Size(23, 23);
            label3.TabIndex = 32;
            label3.Text = "H";
            // 
            // cbMinuto
            // 
            cbMinuto.BackColor = Color.Pink;
            cbMinuto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMinuto.FormattingEnabled = true;
            cbMinuto.Location = new Point(286, 134);
            cbMinuto.Name = "cbMinuto";
            cbMinuto.Size = new Size(50, 36);
            cbMinuto.TabIndex = 26;
            // 
            // cbHora
            // 
            cbHora.BackColor = Color.Pink;
            cbHora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHora.FormattingEnabled = true;
            cbHora.Location = new Point(223, 134);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(50, 36);
            cbHora.TabIndex = 25;
            // 
            // listTempo
            // 
            listTempo.BackColor = Color.Thistle;
            listTempo.FormattingEnabled = true;
            listTempo.Location = new Point(651, 94);
            listTempo.Name = "listTempo";
            listTempo.Size = new Size(182, 204);
            listTempo.TabIndex = 31;
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.FlatStyle = FlatStyle.Flat;
            LblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblData.Location = new Point(585, 19);
            LblData.Name = "LblData";
            LblData.Size = new Size(142, 28);
            LblData.TabIndex = 29;
            LblData.Text = "seg - 00/00/00";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(165, -1);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(293, 84);
            lblHora.TabIndex = 27;
            lblHora.Text = "00:00:00";
            // 
            // btnAlarme
            // 
            btnAlarme.BackColor = Color.Orchid;
            btnAlarme.FlatAppearance.BorderSize = 0;
            btnAlarme.FlatStyle = FlatStyle.Flat;
            btnAlarme.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlarme.Location = new Point(199, 253);
            btnAlarme.Name = "btnAlarme";
            btnAlarme.Size = new Size(208, 49);
            btnAlarme.TabIndex = 30;
            btnAlarme.Text = "Alarme";
            btnAlarme.UseVisualStyleBackColor = false;
            btnAlarme.Click += btnAlarme_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(272, 141);
            label5.Name = "label5";
            label5.Size = new Size(15, 23);
            label5.TabIndex = 38;
            label5.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 139);
            label2.Name = "label2";
            label2.Size = new Size(15, 23);
            label2.TabIndex = 37;
            label2.Text = ":";
            // 
            // labeltempo
            // 
            labeltempo.Interval = 500;
            labeltempo.Tick += labeltempo_Tick_1;
            // 
            // tempo
            // 
            tempo.Enabled = true;
            tempo.Interval = 1000;
            tempo.Tick += tempo_Tick;
            // 
            // Despetador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(864, 370);
            Controls.Add(lblalarme);
            Controls.Add(label1);
            Controls.Add(cbSegundos);
            Controls.Add(dateTimePicker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbMinuto);
            Controls.Add(cbHora);
            Controls.Add(listTempo);
            Controls.Add(LblData);
            Controls.Add(lblHora);
            Controls.Add(btnAlarme);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Despetador";
            Text = "Despetador";
  
            FormClosed += Despetador_FormClosed;
            Load += Despetador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblalarme;
        private Label label1;
        private ComboBox cbSegundos;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private Label label3;
        private ComboBox cbMinuto;
        private ComboBox cbHora;
        private ListBox listTempo;
        private Label LblData;
        private Label lblHora;
        private Button btnAlarme;
        private Label label5;
        private Label label2;
        private System.Windows.Forms.Timer labeltempo;
        private System.Windows.Forms.Timer tempo;
    }
}