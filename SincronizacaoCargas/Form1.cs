using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SincronizacaoCargas.forms;


namespace SincronizacaoCargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }       

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracao frm = new frmConfiguracao();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbItensmgv.Checked)
            {
                baixarArquivos("ITENSMGV.TXT");
            }

            if (cbTxtinfo.Checked)
            {
                baixarArquivos("TXTINFO.TXT");
            }

            if (cbDepto.Checked)
            {
                baixarArquivos("Depto.TXT");
            }

            if (cbCadTxt.Checked)
            {
                baixarArquivos("CADTXT.TXT");
            }

            if (cbSetorTxt.Checked)
            {
                baixarArquivos("SETORTXT.TXT");
            }

            if (cbRec_ass.Checked)
            {
                baixarArquivos("REC_ASS.TXT");
            }

            if (cbPricetab.Checked)
            {
                baixarArquivos("PRICETAB.TXT");
            }

            if (cbProdutos.Checked)
            {
                baixarArquivos("PRODUTOS.TXT");
            }
        }

        private void baixarArquivos(string v)
        {           
            try
            {
                button1.Enabled = false;
                string url = Properties.Settings.Default.UrlDownload;
                string destino = Properties.Settings.Default.Destino;
                destino += @"\" + v;
                url += v;
                Uri siteUri = new Uri(url);
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(siteUri, destino);

                             
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                button1.Enabled = true;
                UltimaAtualizacao();
            }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Baixado com sucesso.");
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UltimaAtualizacao()
        {
            string diretorio = Properties.Settings.Default.Destino;
            string arquivos = null;
            DirectoryInfo dirInfo = new DirectoryInfo(diretorio);
            FileInfo[] files = dirInfo.GetFiles("*.txt");
            foreach (var file in files)
            {
                arquivos += file.Name + " - " +  file.LastWriteTime.ToShortDateString() + " : " + file.LastWriteTime.ToShortTimeString() + " - " + file.Length;
            }

            label2.Text = arquivos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int _interval = Properties.Settings.Default.IntervaloAtualizacao;
            _interval *= 60;
            _interval *= 1000;           
            timer2.Interval = _interval;            
            timer2.Enabled = true;
            UltimaAtualizacao();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UltimaAtualizacao();
            CriarLog();
        }

        private void CriarLog()
        {
            StreamWriter sw = null;
            sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + ": Última verificação de download." );
            sw.Flush();
            sw.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
