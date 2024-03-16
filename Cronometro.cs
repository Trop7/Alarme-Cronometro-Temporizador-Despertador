
using System.Diagnostics;

namespace Alarme
{
    public partial class Cronometro : Form
    {
        public Cronometro()
        {
            InitializeComponent();
        }
        Stopwatch crono = new Stopwatch();
        private void Cronometro_Load(object sender, EventArgs e)
        {


        }
        private void Tempo_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = string.Format("{0:hh\\:mm\\:ss\\.fff}", crono.Elapsed);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (crono.IsRunning)
            {
                crono.Stop();
                btnInicio.Text = "Inicio";
            }
            else
            {
                crono.Start();
                btnInicio.Text = "Parar";
            }
        }
        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            crono.Reset();
            btnInicio.Text = "Inicio";
            lblCronometro.Text = string.Format("{0:hh\\:mm\\:ss\\.fff}", crono.Elapsed);
        }

        private void btnVoltas_Click(object sender, EventArgs e)
        {
            listCronometro.Items.Add(string.Format("{0:hh\\:mm\\:ss\\.fff}", crono.Elapsed));
        }
    }
}
