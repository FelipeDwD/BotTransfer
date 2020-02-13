namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtQuantidadeLista = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTransferidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeHistorico = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalEncontrados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUltimaTransferencia = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigemCaminho = new System.Windows.Forms.TextBox();
            this.txtDestinoCaminho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBackupCaminho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogCaminho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.fbdOrigem = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdLog = new System.Windows.Forms.FolderBrowserDialog();
            this.Diretorios = new System.Windows.Forms.GroupBox();
            this.Historico = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmcTime = new System.Windows.Forms.NumericUpDown();
            this.Tempo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProximaExecucao = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Diretorios.SuspendLayout();
            this.Historico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTime)).BeginInit();
            this.Tempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantidadeLista
            // 
            this.txtQuantidadeLista.Location = new System.Drawing.Point(217, 30);
            this.txtQuantidadeLista.Name = "txtQuantidadeLista";
            this.txtQuantidadeLista.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidadeLista.TabIndex = 0;
            this.txtQuantidadeLista.Text = "5";
            this.txtQuantidadeLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.Location = new System.Drawing.Point(317, 30);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(85, 20);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de arquivos transferidos /  Total encontrados:";
            // 
            // lblTotalTransferidos
            // 
            this.lblTotalTransferidos.Location = new System.Drawing.Point(270, 36);
            this.lblTotalTransferidos.Name = "lblTotalTransferidos";
            this.lblTotalTransferidos.Size = new System.Drawing.Size(33, 23);
            this.lblTotalTransferidos.TabIndex = 3;
            this.lblTotalTransferidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Histórico dos";
            // 
            // txtQuantidadeHistorico
            // 
            this.txtQuantidadeHistorico.Location = new System.Drawing.Point(79, 56);
            this.txtQuantidadeHistorico.Name = "txtQuantidadeHistorico";
            this.txtQuantidadeHistorico.Size = new System.Drawing.Size(89, 23);
            this.txtQuantidadeHistorico.TabIndex = 5;
            this.txtQuantidadeHistorico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(165, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "últimos arquivos transferidos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(317, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalEncontrados
            // 
            this.lblTotalEncontrados.Location = new System.Drawing.Point(354, 36);
            this.lblTotalEncontrados.Name = "lblTotalEncontrados";
            this.lblTotalEncontrados.Size = new System.Drawing.Size(68, 23);
            this.lblTotalEncontrados.TabIndex = 11;
            this.lblTotalEncontrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(431, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Última transferência feita em:";
            // 
            // lblUltimaTransferencia
            // 
            this.lblUltimaTransferencia.Location = new System.Drawing.Point(572, 34);
            this.lblUltimaTransferencia.Name = "lblUltimaTransferencia";
            this.lblUltimaTransferencia.Size = new System.Drawing.Size(149, 25);
            this.lblUltimaTransferencia.TabIndex = 13;
            this.lblUltimaTransferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutar.Location = new System.Drawing.Point(12, 764);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(788, 33);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Iniciar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade a exibir no histórico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Origem:";
            // 
            // txtOrigemCaminho
            // 
            this.txtOrigemCaminho.Location = new System.Drawing.Point(70, 41);
            this.txtOrigemCaminho.Name = "txtOrigemCaminho";
            this.txtOrigemCaminho.Size = new System.Drawing.Size(606, 20);
            this.txtOrigemCaminho.TabIndex = 19;
            // 
            // txtDestinoCaminho
            // 
            this.txtDestinoCaminho.Location = new System.Drawing.Point(70, 67);
            this.txtDestinoCaminho.Name = "txtDestinoCaminho";
            this.txtDestinoCaminho.Size = new System.Drawing.Size(606, 20);
            this.txtDestinoCaminho.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Destino:";
            // 
            // txtBackupCaminho
            // 
            this.txtBackupCaminho.Location = new System.Drawing.Point(70, 93);
            this.txtBackupCaminho.Name = "txtBackupCaminho";
            this.txtBackupCaminho.Size = new System.Drawing.Size(606, 20);
            this.txtBackupCaminho.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Back-up:";
            // 
            // txtLogCaminho
            // 
            this.txtLogCaminho.Location = new System.Drawing.Point(70, 119);
            this.txtLogCaminho.Name = "txtLogCaminho";
            this.txtLogCaminho.Size = new System.Drawing.Size(606, 20);
            this.txtLogCaminho.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Log:";
            // 
            // btnOrigem
            // 
            this.btnOrigem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrigem.Location = new System.Drawing.Point(683, 41);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(62, 20);
            this.btnOrigem.TabIndex = 26;
            this.btnOrigem.Text = "...";
            this.btnOrigem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // btnLog
            // 
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Location = new System.Drawing.Point(682, 119);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(62, 20);
            this.btnLog.TabIndex = 27;
            this.btnLog.Text = "...";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Location = new System.Drawing.Point(683, 93);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(62, 20);
            this.btnBackup.TabIndex = 28;
            this.btnBackup.Text = "...";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestino.Location = new System.Drawing.Point(682, 67);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(62, 20);
            this.btnDestino.TabIndex = 29;
            this.btnDestino.Text = "...";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // Diretorios
            // 
            this.Diretorios.Controls.Add(this.txtOrigemCaminho);
            this.Diretorios.Controls.Add(this.btnDestino);
            this.Diretorios.Controls.Add(this.label6);
            this.Diretorios.Controls.Add(this.btnBackup);
            this.Diretorios.Controls.Add(this.label9);
            this.Diretorios.Controls.Add(this.btnLog);
            this.Diretorios.Controls.Add(this.txtDestinoCaminho);
            this.Diretorios.Controls.Add(this.btnOrigem);
            this.Diretorios.Controls.Add(this.label10);
            this.Diretorios.Controls.Add(this.txtLogCaminho);
            this.Diretorios.Controls.Add(this.txtBackupCaminho);
            this.Diretorios.Controls.Add(this.label11);
            this.Diretorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Diretorios.Location = new System.Drawing.Point(12, 12);
            this.Diretorios.Name = "Diretorios";
            this.Diretorios.Size = new System.Drawing.Size(786, 170);
            this.Diretorios.TabIndex = 30;
            this.Diretorios.TabStop = false;
            this.Diretorios.Text = "Diretórios";
            // 
            // Historico
            // 
            this.Historico.Controls.Add(this.btnLimpar);
            this.Historico.Controls.Add(this.txtHistorico);
            this.Historico.Controls.Add(this.txtQuantidadeLista);
            this.Historico.Controls.Add(this.label8);
            this.Historico.Controls.Add(this.lblUltimaTransferencia);
            this.Historico.Controls.Add(this.label5);
            this.Historico.Controls.Add(this.btn_Ok);
            this.Historico.Controls.Add(this.label2);
            this.Historico.Controls.Add(this.txtQuantidadeHistorico);
            this.Historico.Controls.Add(this.label3);
            this.Historico.Location = new System.Drawing.Point(12, 344);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(786, 414);
            this.Historico.TabIndex = 31;
            this.Historico.TabStop = false;
            this.Historico.Text = "Histórico";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(626, 354);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar Histórico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(67, 82);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(553, 313);
            this.txtHistorico.TabIndex = 18;
            this.txtHistorico.Text = "Nenhum registro a ser exibido.";
            this.txtHistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalEncontrados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalTransferidos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 81);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processo";
            // 
            // nmcTime
            // 
            this.nmcTime.Location = new System.Drawing.Point(16, 22);
            this.nmcTime.Name = "nmcTime";
            this.nmcTime.Size = new System.Drawing.Size(120, 20);
            this.nmcTime.TabIndex = 34;
            this.nmcTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Tempo
            // 
            this.Tempo.Controls.Add(this.label13);
            this.Tempo.Controls.Add(this.lblHoraInicio);
            this.Tempo.Controls.Add(this.label12);
            this.Tempo.Controls.Add(this.lblProximaExecucao);
            this.Tempo.Controls.Add(this.btnTime);
            this.Tempo.Controls.Add(this.label7);
            this.Tempo.Controls.Add(this.nmcTime);
            this.Tempo.Location = new System.Drawing.Point(12, 201);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(786, 50);
            this.Tempo.TabIndex = 36;
            this.Tempo.TabStop = false;
            this.Tempo.Text = "Tempo de execução";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(279, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "Início:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.Location = new System.Drawing.Point(328, 19);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(158, 23);
            this.lblHoraInicio.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(523, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 39;
            this.label12.Text = "Próxima execução:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblProximaExecucao
            // 
            this.lblProximaExecucao.Location = new System.Drawing.Point(619, 22);
            this.lblProximaExecucao.Name = "lblProximaExecucao";
            this.lblProximaExecucao.Size = new System.Drawing.Size(161, 23);
            this.lblProximaExecucao.TabIndex = 38;
            // 
            // btnTime
            // 
            this.btnTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTime.Location = new System.Drawing.Point(181, 19);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 37;
            this.btnTime.Text = "OK";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "min.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 809);
            this.Controls.Add(this.Tempo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.Diretorios);
            this.Controls.Add(this.btnExecutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferência de arquivos XML";
            this.Diretorios.ResumeLayout(false);
            this.Diretorios.PerformLayout();
            this.Historico.ResumeLayout(false);
            this.Historico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmcTime)).EndInit();
            this.Tempo.ResumeLayout(false);
            this.Tempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantidadeLista;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTransferidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtQuantidadeHistorico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalEncontrados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUltimaTransferencia;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrigemCaminho;
        private System.Windows.Forms.TextBox txtDestinoCaminho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBackupCaminho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogCaminho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.FolderBrowserDialog fbdOrigem;
        private System.Windows.Forms.FolderBrowserDialog fbdDestino;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.FolderBrowserDialog fbdLog;
        private System.Windows.Forms.GroupBox Diretorios;
        private System.Windows.Forms.GroupBox Historico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmcTime;
        private System.Windows.Forms.GroupBox Tempo;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProximaExecucao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblHoraInicio;
    }
}

