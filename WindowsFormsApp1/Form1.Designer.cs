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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantidadeLista
            // 
            this.txtQuantidadeLista.Location = new System.Drawing.Point(480, 69);
            this.txtQuantidadeLista.Name = "txtQuantidadeLista";
            this.txtQuantidadeLista.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidadeLista.TabIndex = 0;
            this.txtQuantidadeLista.Text = "5";
            this.txtQuantidadeLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(578, 69);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(85, 20);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de arquivos transferidos /  Total encontrados:";
            // 
            // lblTotalTransferidos
            // 
            this.lblTotalTransferidos.Location = new System.Drawing.Point(246, 38);
            this.lblTotalTransferidos.Name = "lblTotalTransferidos";
            this.lblTotalTransferidos.Size = new System.Drawing.Size(33, 23);
            this.lblTotalTransferidos.TabIndex = 3;
            this.lblTotalTransferidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista do(s):";
            // 
            // txtQuantidadeHistorico
            // 
            this.txtQuantidadeHistorico.Location = new System.Drawing.Point(74, 74);
            this.txtQuantidadeHistorico.Name = "txtQuantidadeHistorico";
            this.txtQuantidadeHistorico.Size = new System.Drawing.Size(89, 23);
            this.txtQuantidadeHistorico.TabIndex = 5;
            this.txtQuantidadeHistorico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(160, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "últimos arquivos transferidos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(295, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalEncontrados
            // 
            this.lblTotalEncontrados.Location = new System.Drawing.Point(334, 38);
            this.lblTotalEncontrados.Name = "lblTotalEncontrados";
            this.lblTotalEncontrados.Size = new System.Drawing.Size(68, 23);
            this.lblTotalEncontrados.TabIndex = 11;
            this.lblTotalEncontrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblListaHistorico
            // 
            this.lblListaHistorico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaHistorico.Location = new System.Drawing.Point(10, 97);
            this.lblListaHistorico.Name = "lblListaHistorico";
            this.lblListaHistorico.Size = new System.Drawing.Size(285, 208);
            this.lblListaHistorico.TabIndex = 7;
            this.lblListaHistorico.Click += new System.EventHandler(this.lblListaHistorico_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Última transferência feita em:";
            // 
            // lblUltimaTransferencia
            // 
            this.lblUltimaTransferencia.Location = new System.Drawing.Point(148, 9);
            this.lblUltimaTransferencia.Name = "lblUltimaTransferencia";
            this.lblUltimaTransferencia.Size = new System.Drawing.Size(149, 25);
            this.lblUltimaTransferencia.TabIndex = 13;
            this.lblUltimaTransferencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(8, 317);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(287, 33);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Iniciar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(309, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(335, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade a exibir na lista:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 366);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Text = "Transferência de Arquivo XML";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

