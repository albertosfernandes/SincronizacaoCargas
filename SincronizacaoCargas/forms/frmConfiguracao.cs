using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SincronizacaoCargas.forms
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.UrlDownload = tbUrlDownload.Text;
                Properties.Settings.Default.Destino = tbDestino.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                MessageBox.Show("Gravado com sucesso.");
            }
            frmConfiguracao.ActiveForm.Close();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            try
            {
                tbUrlDownload.Text = Properties.Settings.Default.UrlDownload;
                tbDestino.Text = Properties.Settings.Default.Destino;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
