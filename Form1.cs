using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic.ApplicationServices;

namespace Alarme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        public Form AtualChildForm;

        private void OpenchildForm(Form childForm)
        {
            //Abre qualquer form
            if (AtualChildForm == null)
            {
                AtualChildForm = childForm;
            }
            else
            {
                AtualChildForm.Dispose();
                AtualChildForm.Close();
                
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDektop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }

        private void btnDespertador_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Despetador());
        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Temporizador());
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Cronometro());
        }

        private void btnrelogio_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Relogio());
        }
    }

}
