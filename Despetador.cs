using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Alarme
{
    public partial class Despetador : Form
    {
        public Despetador()
        {
            InitializeComponent();
        }

        int bond = 0;
        List<DateTime> alarms = new List<DateTime>();
        //Dictionary<DateTime, bool> alarm = new Dictionary<DateTime, bool>();
        List<Alarme> alarmes = new List<Alarme>();
        SoundPlayer toque = new SoundPlayer(@"C:\Users\NOTEBOOK\Music\20.wav");
        Thread hora;
        bool timer = true;


        private void Despetador_Load(object sender, EventArgs e)
        {
            Alarme tempo = new Alarme();
            tempo.Datalbl();
            LblData.Text = tempo.Datalbl();
            /////////////////////////////////
            hora = new Thread(Relogio);
            hora.IsBackground = true;
            hora.Start();

            /////////////////////////////////
            Alarme.PreencherComboBoxHora(cbHora);
            Alarme.PreencherComboBoxMinutos(cbMinuto);
            Alarme.PreencherComboBoxSegundos(cbSegundos);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnAlarme_Click_1(object sender, EventArgs e)
        {
            DateTime DataFormada = DateTime.Parse(cbHora.Text + ":" + cbMinuto.Text + ":" + cbSegundos.Text);
            DateTime alarmTime = DataFormada;
            alarmes.Add(new Alarme(alarmTime));
            listTempo.Items.Add(alarmTime.ToString("HH:mm:ss"));

        }

        public void Relogio()
        {
           try
            {
                while (timer)
                {
                    Invoke(new Action(() => lblHora.Text = DateTime.Now.ToString("HH:mm:ss")));

                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timer = false;
                hora.SetApartmentState(ApartmentState.MTA);
            }
           
        }
        void som()
        {
            SoundPlayer toque = new SoundPlayer(@"C:\Users\NOTEBOOK\Music\20.wav");
            int seg = 0;

            while (seg < 10)
            {
                toque.Play();
                Thread.Sleep(500);
                seg++;
            }
            labeltempo.Stop();
        }

        private void labeltempo_Tick_1(object sender, EventArgs e)
        {

            if (bond > 5)
            {
                // labeltempo.Stop();
                bond = 0;
            }
            if (lblalarme.Visible == false)
            {
                lblalarme.Visible = true;
            }
            else { lblalarme.Visible = false; }

            if (bond == 0)
            {
                lblalarme.ForeColor = Color.Red;
                lblalarme.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else if (bond == 1)
            {
                lblalarme.ForeColor = Color.Green;
                lblalarme.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else if (bond == 2)
            {
                lblalarme.ForeColor = Color.Blue;
                lblalarme.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else if (bond == 3)
            {
                lblalarme.ForeColor = Color.HotPink;
                lblalarme.Font = new Font("Comic Sans MS", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else if (bond == 4)
            {
                lblalarme.ForeColor = Color.Yellow;
                lblalarme.Font = new Font("Comic Sans MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            bond++;
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            foreach (Alarme alar in alarmes)
            {
                //if (!alar.Value && currentTime.Hour == alar.Key.Hour && currentTime.Minute == alar.Key.Minute && currentTime.Second == alar.Key.Second)
                //{
                //    //MessageBox.Show("Alarme!", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    alarm[alar.Key] = true;
                //    toque.Play();
                //    UpdateListBox();
                //}
                if (!alar.Disparado && currentTime.Hour == alar.Tempo.Hour && currentTime.Minute == alar.Tempo.Minute && currentTime.Second == alar.Tempo.Second)
                {
                    Thread somm = new Thread(som);
                    somm.IsBackground = true;
                    somm.Start();
                    labeltempo.Start();
                    //MessageBox.Show("Alarme!", "Alarme", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                    alar.Disparado = true;
                    UpdateListBox();
                }
            }
            void UpdateListBox()
            {
                listTempo.Items.Clear();
                foreach (var ala in alarmes)
                {
                    //listTempo.Items.Add($"{ala.Key.ToString("HH:mm:ss")} {(ala.Value ? "OK" : "")}");
                    listTempo.Items.Add($"{ala.Tempo.ToString("HH:mm:ss")} {(ala.Disparado ? "OK" : "")}");
                }
            }
        }

        private void Despetador_FormClosed(object sender, FormClosedEventArgs e)
        {
           //this.Close();    
        }
    }
}
