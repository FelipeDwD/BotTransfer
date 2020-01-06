using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Apoio;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewFileInfo(5);         
        }       

        StringBuilder sb = new StringBuilder();        
        Diretorio diretorio;
        Log log = new Log();
        Transferencia transferencia;

        System.Threading.Timer t;          


        FileInfo[] historyLast;
        int count = 0;
        int totalTransferidos = 0;       
        int topHistoricoUser = 5;         
        
        /// <summary>
        /// Cria uma nova instância da classe diretório
        /// </summary>
        public void InstanciarDiretorio()
        {
            //Instancia um novo diretório.
            diretorio = new Diretorio();
            ///Preenche a label "lblTotalEncontrados" com a quantidade total de indíces na lista "arquivos" da classe Diretorio.
            Invoke(new MethodInvoker(() => this.lblTotalEncontrados.Text = diretorio.arquivos.Count.ToString()));
            //Reseta a variável total transferidos.
            totalTransferidos = 0;
        }

        /// <summary>
        /// Executa todo o processo de transferência:
        /// Abertura no log, registros no log e fechamento no log.
        /// </summary>
        private void ExecutarTransferencia()
        {            
            InstanciarDiretorio();
            log.AbrirNovaTransferencia(transferencia.Origem, transferencia.Destino, transferencia.Enviados);

            foreach (FileInfo arquivo in diretorio.arquivos)
            {
                transferencia.TransferenciaUnica(arquivo);

                if (diretorio.VerificarArquivoExisteNoDestino(arquivo))
                {
                    transferencia.MoverParaEnviados(arquivo);
                    log.RegistrarTransferenciaNoLog(arquivo);
                    AtualizarListaHistorico(arquivo);
                    historyLast[RetornarTamanhoHistorico()] = arquivo;
                    AtualizarLabelTotalTransferidos();

                    if (count <= this.historyLast.Length)
                    {
                        AtualizarUltimos(this.historyLast);
                    }
                    count++;
                }
            }
            diretorio.LimparListaArquivos();
            log.FecharTransferencia(this.totalTransferidos);
        }

        /// <summary>
        /// Retorna os últimos registros
        /// </summary>        
        public string RetornarUltimos(FileInfo[] files)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                for (int i = files.Length - 1; i >= 0; i--)
                {
                    sb.Append(files[i].Name);
                    sb.Append(" - ");
                    sb.AppendLine(DateTime.Now.ToString());
                }

            }
            catch (System.NullReferenceException ex)
            {

            }
            return sb.ToString();
        }       
        /// <summary>
        /// Atualiza os últimos registros
        /// </summary>        
        public void AtualizarUltimos(FileInfo[] files)
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Refresh()));            
            for (int i = 0; i < (files.Length - 1); i++)
            {
                files[i] = files[(i + 1)];
            }
        }

        public int RetornarTamanhoHistorico()
        {
            return this.historyLast.Length - 1;
        }

        public void AtualizarLabelTotalTransferidos()
        {
            this.totalTransferidos++;
            Invoke(new MethodInvoker(() => this.lblTotalTransferidos.Refresh()));
            Invoke(new MethodInvoker(() => this.lblTotalTransferidos.Text = this.totalTransferidos.ToString()));            
        }

        public void AtualizarListaHistorico(FileInfo file)
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Refresh()));            
            sb.Append(file.Name);
            sb.Append(" - ");
            sb.AppendLine(DateTime.Now.ToString());
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = sb.ToString()));            
            sb.Clear();
        }

        public void AtualizarTxtUltimos()
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = RetornarUltimos(this.historyLast)));            
        }

        public void NewFileInfo(int lenght)
        {
            historyLast = new FileInfo[lenght];
            count = 0;
        }

       

        public void ExibirMensagemAtualizacaoHistorico(int registrosEmLista)
        {
            MessageBox.Show($"A lista irá trazer os últimos {registrosEmLista} somente na próxima execução");
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.topHistoricoUser = int.Parse(this.txtQuantidadeLista.Text.ToString());
            int registrosEmListaSolicitadoUsuario = int.Parse(this.txtQuantidadeLista.Text.ToString());
            NewFileInfo(registrosEmListaSolicitadoUsuario);
            ExibirMensagemAtualizacaoHistorico(registrosEmListaSolicitadoUsuario);
        }   

       

        public void TimerCallback(Object o)
        {
            Invoke(new MethodInvoker(() => this.lblUltimaTransferencia.Text = DateTime.Now.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Text = this.topHistoricoUser.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Refresh()));                       
            ExecutarTransferencia();
            AtualizarTxtUltimos();           
        }         
        

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (this.btnExecutar.Text.Equals("Iniciar"))
            {
                InstanciarDiretorio();
                transferencia = new Transferencia(diretorio.DiretorioOrigem, diretorio.DiretorioDestino, diretorio.DiretorioEnviados);
                t = new System.Threading.Timer(TimerCallback, null, 0, 120000);                
                MessageBox.Show("Robô iniciado com sucesso");
                this.btnExecutar.Text = "Pausar";
            }
            else if (this.btnExecutar.Text.Equals("Pausar"))
            {
                t.Dispose();
                MessageBox.Show("Parado com sucesso");
                this.btnExecutar.Text = "Iniciar";              
            }
        }
    }
}
