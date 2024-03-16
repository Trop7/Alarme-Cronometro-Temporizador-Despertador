namespace Alarme
{
    partial class Relogio
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
            lblHora = new Label();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Garamond", 72F, FontStyle.Italic, GraphicsUnit.Point, 161);
            lblHora.Location = new Point(176, 84);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(445, 135);
            lblHora.TabIndex = 0;
            lblHora.Text = "00:00:00";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Relogio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(817, 327);
            Controls.Add(lblHora);
            Name = "Relogio";
            Text = "Relogio";
            FormClosed += Relogio_FormClosed;
            Load += Relogio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
    }
}