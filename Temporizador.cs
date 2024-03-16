using System.Diagnostics;

namespace Alarme
{
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        int h, m, s;
        bool IsRunning;
        string captura;


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            temporizar(txtHora, txtMinnuto, txtSegundo);

            if (IsRunning)
            {
                temporiza.Stop();            
                btnIniciar.Text = "Iniciar";
                btnIniciar.BackColor = Color.Black;
                
            }
            else
            {
                
                temporiza.Start();              
                btnIniciar.Text = "Parar";
                btnIniciar.BackColor = Color.CornflowerBlue;
            }
                IsRunning = !IsRunning;
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            temporiza.Stop();
            temporiza.Dispose();
            btnIniciar.Text = "Iniciar";
            txtHora.Text = "00";
            txtMinnuto.Text = "01";
            txtSegundo.Text = "00";
            lbTemporizador.Text = txtHora.Text + ":" + txtMinnuto.Text + ":" + txtSegundo.Text;
            txtHora.Focus();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            temporiza.Stop();
            temporiza.Dispose();
            temporizar(txtHora, txtMinnuto, txtSegundo);
            temporiza.Start();
            
        }
        public void temporizar(TextBox hora, TextBox minuto, TextBox segundo)
        {
            
            h = int.Parse(hora.Text);
            m = int.Parse(minuto.Text);
            s = int.Parse(segundo.Text);
            if (m >= 60)
            {
                h = m / 60;
                m = m % 60;
            }
            else 
            {
                h = int.Parse(hora.Text);
                m = int.Parse(minuto.Text);
                s = int.Parse(segundo.Text);
            }

        }
        private void temporiza_Tick(object sender, EventArgs e)
        {
            s--;

            if (s < 0)
            {
                s = 59;

                if (m >= 0)
                {
                    m--;

                    if (m < 0)
                    {
                        m = 59;

                        if (h > 0)
                        {
                            h--;
                        }
                    }
                }
            }
            lbTemporizador.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            
            if (h == 0 && m == 0 && s == 0)
            {
                temporiza.Stop();
                btnIniciar.Text = "Iniciar";
                btnIniciar.BackColor = Color.BlanchedAlmond;
                MessageBox.Show("Tempo...");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "05";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "10";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "15";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "60";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "120";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "240";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHora.Text = "00";
            txtMinnuto.Text = "350";
            txtSegundo.Text = "00";

            temporizar(txtHora, txtMinnuto, txtSegundo);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            temporiza.Stop();
        }
    }
}
