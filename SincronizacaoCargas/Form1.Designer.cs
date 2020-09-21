namespace SincronizacaoCargas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPricetab = new System.Windows.Forms.CheckBox();
            this.cbSetorTxt = new System.Windows.Forms.CheckBox();
            this.cbRec_ass = new System.Windows.Forms.CheckBox();
            this.cbCadTxt = new System.Windows.Forms.CheckBox();
            this.cbDepto = new System.Windows.Forms.CheckBox();
            this.cbTxtinfo = new System.Windows.Forms.CheckBox();
            this.cbItensmgv = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbProdutos = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configurações";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cbProdutos);
            this.groupBox1.Controls.Add(this.cbPricetab);
            this.groupBox1.Controls.Add(this.cbSetorTxt);
            this.groupBox1.Controls.Add(this.cbRec_ass);
            this.groupBox1.Controls.Add(this.cbCadTxt);
            this.groupBox1.Controls.Add(this.cbDepto);
            this.groupBox1.Controls.Add(this.cbTxtinfo);
            this.groupBox1.Controls.Add(this.cbItensmgv);
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos";
            // 
            // cbPricetab
            // 
            this.cbPricetab.AutoSize = true;
            this.cbPricetab.Location = new System.Drawing.Point(263, 20);
            this.cbPricetab.Name = "cbPricetab";
            this.cbPricetab.Size = new System.Drawing.Size(78, 17);
            this.cbPricetab.TabIndex = 6;
            this.cbPricetab.Text = "pricetab.txt";
            this.cbPricetab.UseVisualStyleBackColor = true;
            // 
            // cbSetorTxt
            // 
            this.cbSetorTxt.AutoSize = true;
            this.cbSetorTxt.Location = new System.Drawing.Point(143, 69);
            this.cbSetorTxt.Name = "cbSetorTxt";
            this.cbSetorTxt.Size = new System.Drawing.Size(74, 17);
            this.cbSetorTxt.TabIndex = 5;
            this.cbSetorTxt.Text = "setortxt.txt";
            this.cbSetorTxt.UseVisualStyleBackColor = true;
            // 
            // cbRec_ass
            // 
            this.cbRec_ass.AutoSize = true;
            this.cbRec_ass.Location = new System.Drawing.Point(143, 44);
            this.cbRec_ass.Name = "cbRec_ass";
            this.cbRec_ass.Size = new System.Drawing.Size(77, 17);
            this.cbRec_ass.TabIndex = 4;
            this.cbRec_ass.Text = "rec_ass.txt";
            this.cbRec_ass.UseVisualStyleBackColor = true;
            // 
            // cbCadTxt
            // 
            this.cbCadTxt.AutoSize = true;
            this.cbCadTxt.Location = new System.Drawing.Point(143, 20);
            this.cbCadTxt.Name = "cbCadTxt";
            this.cbCadTxt.Size = new System.Drawing.Size(69, 17);
            this.cbCadTxt.TabIndex = 3;
            this.cbCadTxt.Text = "cadtxt.txt";
            this.cbCadTxt.UseVisualStyleBackColor = true;
            // 
            // cbDepto
            // 
            this.cbDepto.AutoSize = true;
            this.cbDepto.Location = new System.Drawing.Point(7, 69);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(67, 17);
            this.cbDepto.TabIndex = 2;
            this.cbDepto.Text = "depto.txt";
            this.cbDepto.UseVisualStyleBackColor = true;
            // 
            // cbTxtinfo
            // 
            this.cbTxtinfo.AutoSize = true;
            this.cbTxtinfo.Location = new System.Drawing.Point(7, 44);
            this.cbTxtinfo.Name = "cbTxtinfo";
            this.cbTxtinfo.Size = new System.Drawing.Size(65, 17);
            this.cbTxtinfo.TabIndex = 1;
            this.cbTxtinfo.Text = "txinfo.txt";
            this.cbTxtinfo.UseVisualStyleBackColor = true;
            // 
            // cbItensmgv
            // 
            this.cbItensmgv.AutoSize = true;
            this.cbItensmgv.Checked = true;
            this.cbItensmgv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbItensmgv.Location = new System.Drawing.Point(7, 20);
            this.cbItensmgv.Name = "cbItensmgv";
            this.cbItensmgv.Size = new System.Drawing.Size(82, 17);
            this.cbItensmgv.TabIndex = 0;
            this.cbItensmgv.Text = "itensmgv.txt";
            this.cbItensmgv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atualizar arquivo(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Última atualização:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "nunca";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Sincronização de cargas";
            this.notifyIcon1.Visible = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 240);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // cbProdutos
            // 
            this.cbProdutos.AutoSize = true;
            this.cbProdutos.Location = new System.Drawing.Point(263, 44);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(81, 17);
            this.cbProdutos.TabIndex = 7;
            this.cbProdutos.Text = "produtos.txt";
            this.cbProdutos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 354);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronização Cargas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDepto;
        private System.Windows.Forms.CheckBox cbTxtinfo;
        private System.Windows.Forms.CheckBox cbItensmgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbCadTxt;
        private System.Windows.Forms.CheckBox cbSetorTxt;
        private System.Windows.Forms.CheckBox cbRec_ass;
        private System.Windows.Forms.CheckBox cbPricetab;
        private System.Windows.Forms.CheckBox cbProdutos;
    }
}

