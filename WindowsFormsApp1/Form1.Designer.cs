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
            this.lblListaHistorico = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantidadeLista
            // 
            this.txtQuantidadeLista.Location = new System.Drawing.Point(524, 12);
            this.txtQuantidadeLista.Name = "txtQuantidadeLista";
            this.txtQuantidadeLista.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidadeLista.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(368, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de arquivos transferidos:";
            // 
            // lblTotalTransferidos
            // 
            this.lblTotalTransferidos.Location = new System.Drawing.Point(538, 47);
            this.lblTotalTransferidos.Name = "lblTotalTransferidos";
            this.lblTotalTransferidos.Size = new System.Drawing.Size(100, 23);
            this.lblTotalTransferidos.TabIndex = 3;
            this.lblTotalTransferidos.Text = "0";
            this.lblTotalTransferidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(368, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista do(s):";
            // 
            // txtQuantidadeHistorico
            // 
            this.txtQuantidadeHistorico.Location = new System.Drawing.Point(432, 79);
            this.txtQuantidadeHistorico.Name = "txtQuantidadeHistorico";
            this.txtQuantidadeHistorico.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeHistorico.TabIndex = 5;
            this.txtQuantidadeHistorico.Text = "últimos";
            this.txtQuantidadeHistorico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(547, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "arquivos transferidos:";
            // 
            // lblListaHistorico
            // 
            this.lblListaHistorico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListaHistorico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaHistorico.Location = new System.Drawing.Point(468, 109);
            this.lblListaHistorico.Name = "lblListaHistorico";
            this.lblListaHistorico.Size = new System.Drawing.Size(239, 208);
            this.lblListaHistorico.TabIndex = 7;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(495, 331);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(212, 33);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 377);
            this.Controls.Add(this.btnTransferir);
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
        private System.Windows.Forms.Label lblListaHistorico;
        private System.Windows.Forms.Button btnTransferir;
    }
}

