using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarme
{
    public partial class Relogio : Form
    {
        public Relogio()
        {
            InitializeComponent();
        }
        Thread horas;
        bool time = true;

        private void Relogio_Load(object sender, EventArgs e)
        {
            horas = new Thread(Relogi);
            horas.IsBackground = true;
            horas.Start();

        }
        public void Relogi()
        {
            try
            {
                while (time)
                {
                    Invoke(new Action(() => lblHora.Text = DateTime.Now.ToString("HH:mm:ss")));

                    Thread.Sleep(1000);
                }
               // horas.Interrupt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                time = false;
                horas.SetApartmentState(ApartmentState.MTA);
            }
            
           
        }
        private void Relogio_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
