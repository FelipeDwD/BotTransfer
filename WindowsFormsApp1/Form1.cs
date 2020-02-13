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
            MinutoToMiliSegundos(2);
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Variável armazena origem dos arquivos selecionada pelo usuário no formulário.
        /// </summary>
        string origem = "";

        /// <summary>
        /// Variável armazena o caminho de destino para onde serão enviados os arquivos.
        /// </summary>
        string destino = "";

        /// <summary>
        /// Variável armazena o caminho da pasta de back-up selecionada pelo usuário.
        /// </summary>
        string backup = "";

        /// <summary>
        /// Variável armazena o intervalo de tempo entre transferências convetido em milisegundos.
        /// </summary>
        int intervaloMilisegundos = 0;

        /// <summary>
        /// Variável armazena o intervalo de transferência em minutos
        /// </summary>
        int intervaloMinutos = 0;


        /// <summary>
        /// Variável armazena a hora de início da primeira transferência.
        /// </summary>
        DateTime horaInicio;

        /// <summary>
        /// Variável armazena o horário da próxima transferência
        /// </summary>
        DateTime horarioProximaTransferencia;


        StringBuilder sb = new StringBuilder();
        Diretorio diretorio;
        Log log;
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
            diretorio = new Diretorio(origem, destino, backup);
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
            Invoke(new MethodInvoker(() => this.txtHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.txtHistorico.Refresh()));
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
            Invoke(new MethodInvoker(() => this.txtHistorico.Refresh()));
            sb.Append(file.Name);
            sb.Append(" - ");
            sb.AppendLine(DateTime.Now.ToString());
            Invoke(new MethodInvoker(() => this.txtHistorico.Text = sb.ToString()));
            sb.Clear();
        }

        public void AtualizarTxtUltimos()
        {
            Invoke(new MethodInvoker(() => this.txtHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.txtHistorico.Text = RetornarUltimos(this.historyLast)));
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
            IntervaloTransferencia();
            ExecutarTransferencia();
            AtualizarTxtUltimos();
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (this.btnExecutar.Text.Equals("Iniciar"))
            {
                if (CaminhosFornecidos())
                {
                    this.InicioTransferencia();
                    InstanciarDiretorio();
                    transferencia = new Transferencia(diretorio.Origem, diretorio.Destino, diretorio.BackUp);
                    t = new System.Threading.Timer(TimerCallback, null, 0, this.intervaloMilisegundos);                    
                    MessageBox.Show("Robô iniciado com sucesso");
                    this.BloquearBotoes();
                    this.btnExecutar.Text = "Pausar";
                }
                else
                {
                    return;
                }

            }
            else if (this.btnExecutar.Text.Equals("Pausar"))
            {
                t.Dispose();
                MessageBox.Show("Parado com sucesso");
                this.DesbloquearBotoes();
                this.btnExecutar.Text = "Iniciar";
            }
        }

        private bool CaminhosFornecidos()
        {
            if (txtOrigemCaminho.TextLength != 0
                && txtDestinoCaminho.TextLength != 0
                && txtBackupCaminho.TextLength != 0
                && txtLogCaminho.TextLength != 0)
            {
                return true;
            }
            MessageBox.Show("Favor fornecer todos diretórios");
            return false;
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            fbdOrigem.Description = "Selecione a pasta de origem onde os arquivos serão coletados: ";
            fbdOrigem.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdOrigem.ShowNewFolderButton = true;

            fbdOrigem.ShowDialog();

            string diretorioOrigem = $@"{fbdOrigem.SelectedPath.ToString()}";
            txtOrigemCaminho.Text = diretorioOrigem;
            origem = diretorioOrigem;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            fbdDestino.Description = "Seleciona a pasta de destino, para onde os arquivos serão enviados: ";
            fbdDestino.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdDestino.ShowNewFolderButton = true;

            fbdDestino.ShowDialog();

            string diretorioDestino = $@"{fbdDestino.SelectedPath.ToString()}";
            txtDestinoCaminho.Text = diretorioDestino;
            destino = diretorioDestino;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            fbdBackup.Description = "Selecione a pasta de back-up dos arquivos: ";
            fbdBackup.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdBackup.ShowNewFolderButton = true;

            fbdBackup.ShowDialog();

            string diretorioBackup = $@"{fbdBackup.SelectedPath.ToString()}";
            txtBackupCaminho.Text = diretorioBackup;
            backup = diretorioBackup;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            fbdLog.Description = "Selecione uma pasta para armazenar o log das transferências: ";
            fbdLog.RootFolder = Environment.SpecialFolder.MyComputer;
            fbdLog.ShowNewFolderButton = true;

            fbdLog.ShowDialog();

            string diretorioLog = $@"{fbdLog.SelectedPath.ToString()}";

            //Cria uma instância do tipo Log
            this.log = new Log(diretorioLog);

            txtLogCaminho.Text = diretorioLog;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            int minutos = int.Parse(nmcTime.Value.ToString());
            this.MinutoToMiliSegundos(minutos);

            MessageBox.Show($"Robô programado para transferir a cada {minutos} minutos.");
        }

        public void InicioTransferencia()
        {
            horaInicio = DateTime.Now;
            Invoke(new MethodInvoker(() => lblHoraInicio.Text = horaInicio.ToString()));
            this.horarioProximaTransferencia = this.horaInicio;
        }

        public void IntervaloTransferencia()
        {
            this.MilisegundosToMinuto(this.intervaloMilisegundos);
            this.horarioProximaTransferencia = this.horarioProximaTransferencia.AddMinutes(this.intervaloMinutos);
            Invoke(new MethodInvoker(() => lblProximaExecucao.Text = this.horarioProximaTransferencia.ToString()));
        }

        private void MinutoToMiliSegundos(int minutos)
        {
            int milisegundos = minutos * 60000;
            this.intervaloMilisegundos = milisegundos;
        }

        private void MilisegundosToMinuto(int milisegundos)
        {
            int minuto = milisegundos / 60000;
            this.intervaloMinutos = minuto;
        }

        private void BloquearBotoes()
        {
            btnBackup.Enabled = false;
            btnDestino.Enabled = false;
            btnLog.Enabled = false;
            btnOrigem.Enabled = false;
            btnTime.Enabled = false;
            btn_Ok.Enabled = false;
        }

        private void DesbloquearBotoes()
        {
            btnBackup.Enabled = true;
            btnDestino.Enabled = true;
            btnLog.Enabled = true;
            btnOrigem.Enabled = true;
            btnTime.Enabled = true;
            btn_Ok.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHistorico.Text = "Nenhum registro a ser exibido.";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
