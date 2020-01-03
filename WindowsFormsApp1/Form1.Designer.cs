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
            this.txtQuantidadeLista = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTransferidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeHistorico = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalEncontrados = new System.Windows.Forms.Label();
            this.lblListaHistorico = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUltimaTransferencia = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantidadeLista
            // 
            this.txtQuantidadeLista.Location = new System.Drawing.Point(524, 12);
            this.txtQuantidadeLista.Name = "txtQuantidadeLista";
            this.txtQuantidadeLista.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidadeLista.TabIndex = 0;
            this.txtQuantidadeLista.Text = "5";
            this.txtQuantidadeLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(622, 12);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(85, 20);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(317, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de arquivos transferidos/ Total encontrados:";
            // 
            // lblTotalTransferidos
            // 
            this.lblTotalTransferidos.Location = new System.Drawing.Point(556, 97);
            this.lblTotalTransferidos.Name = "lblTotalTransferidos";
            this.lblTotalTransferidos.Size = new System.Drawing.Size(33, 23);
            this.lblTotalTransferidos.TabIndex = 3;
            this.lblTotalTransferidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(425, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista do(s):";
            // 
            // txtQuantidadeHistorico
            // 
            this.txtQuantidadeHistorico.Location = new System.Drawing.Point(489, 131);
            this.txtQuantidadeHistorico.Name = "txtQuantidadeHistorico";
            this.txtQuantidadeHistorico.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeHistorico.TabIndex = 5;
            this.txtQuantidadeHistorico.Text = "últimos";
            this.txtQuantidadeHistorico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(604, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "arquivos transferidos:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(605, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalEncontrados
            // 
            this.lblTotalEncontrados.Location = new System.Drawing.Point(644, 97);
            this.lblTotalEncontrados.Name = "lblTotalEncontrados";
            this.lblTotalEncontrados.Size = new System.Drawing.Size(68, 23);
            this.lblTotalEncontrados.TabIndex = 11;
            this.lblTotalEncontrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblListaHistorico
            // 
            this.lblListaHistorico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaHistorico.Location = new System.Drawing.Point(474, 162);
            this.lblListaHistorico.Name = "lblListaHistorico";
            this.lblListaHistorico.Size = new System.Drawing.Size(239, 208);
            this.lblListaHistorico.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(317, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Última transferência feita em:";
            // 
            // lblUltimaTransferencia
            // 
            this.lblUltimaTransferencia.Location = new System.Drawing.Point(458, 63);
            this.lblUltimaTransferencia.Name = "lblUltimaTransferencia";
            this.lblUltimaTransferencia.Size = new System.Drawing.Size(149, 25);
            this.lblUltimaTransferencia.TabIndex = 13;
            this.lblUltimaTransferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(474, 385);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(239, 33);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Iniciar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 430);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblUltimaTransferencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalEncontrados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblListaHistorico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantidadeHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalTransferidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtQuantidadeLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblListaHistorico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUltimaTransferencia;
        private System.Windows.Forms.Button btnExecutar;
    }
}

