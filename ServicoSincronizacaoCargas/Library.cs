using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServicoSincronizacaoCargas
{
    public class Library
    {
        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        public static void DownloadFile(string v)
        {
            try
            {
                string url = Properties.Settings.Default.UrlDownload;
                string destino = Properties.Settings.Default.Destino;
                destino += @"\" + v;
                url += v;
                Uri siteUri = new Uri(url);
                WebClient client = new WebClient();
                client.DownloadFile(siteUri, destino);
                WriteErrorLog(DateTime.Now + " - Baixado com sucesso: " + v);
            }
            catch (Exception erro)
            {
                WriteErrorLog(erro);
            }
        }
    }
}
