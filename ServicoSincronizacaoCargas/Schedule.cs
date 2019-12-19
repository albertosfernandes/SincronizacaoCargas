using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServicoSincronizacaoCargas
{
    public partial class Schedule : ServiceBase
    {
        private Timer timer1 = null;

        public Schedule()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            int _interval = Properties.Settings.Default.IntervaloAtualizacao;
            _interval *= 60;
            _interval *= 1000;
            timer1 = new Timer();
            this.timer1.Interval = _interval;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            Library.WriteErrorLog("Serviço de Cargas iniciado.");

            
        }

        private List<string> LoadSettings()
        {
            List<string> listSettings = new List<string>();

            try
            {
                if (Properties.Settings.Default.ITENSMGV_TXT)
                {
                    listSettings.Add("itensmgv.txt");
                }

                if (Properties.Settings.Default.ARQSOK_TXT)
                {
                    listSettings.Add("arqsok.txt");
                }

                if (Properties.Settings.Default.DEPTO_TXT)
                {
                    listSettings.Add("depto.txt");
                }

                if (Properties.Settings.Default.TARA_TXT)
                {
                    listSettings.Add("tara.txt");
                }

                if (Properties.Settings.Default.TXTINFO_TXT)
                {
                    listSettings.Add("txtinfo.txt");
                }

                if (Properties.Settings.Default.CADTXT)
                {
                    listSettings.Add("cadtxt.txt");
                }

                if (Properties.Settings.Default.SETORTXT)
                {
                    listSettings.Add("setortxt.txt");
                }

                if (Properties.Settings.Default.REC_ASS)
                {
                    listSettings.Add("rec_ass.txt");
                }
            }
            catch(Exception erro)
            { throw erro; }

            return listSettings;
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            List<string> listSettings = LoadSettings();
            foreach (var file in listSettings)
            {
                //Write code here to do some job depends on your requirement
                Library.DownloadFile(file);
            }
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Serviço de Cargas parado.");
        }
    }
}
