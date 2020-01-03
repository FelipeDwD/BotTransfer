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
        static Diretorio caminho = new Diretorio();

        System.Threading.Timer t;



        DirectoryInfo diretorioInfoOrigem = new DirectoryInfo(caminho.DiretorioOrigem());
        DirectoryInfo diretorioInfoDestino = new DirectoryInfo(caminho.DiretorioDestino());         


        FileInfo[] historyLast;
        int count = 0;
        int totalTransferidos = 0;
        int totalEncontrados = 0;
        int topHistoricoUser = 5;        

        private void RecuperarTotalArquivosNoDiretorio(DirectoryInfo directory)
        {
            foreach (FileInfo file in directory.GetFiles())
            {
                this.totalEncontrados++;
            }
            Invoke(new MethodInvoker(() => this.lblTotalEncontrados.Text = this.totalEncontrados.ToString()));
            Invoke(new MethodInvoker(() => this.lblTotalEncontrados.Refresh()));
            
        }

        private void ExecutarTransferencia(DirectoryInfo diretorioOrigem)
        {
            Log log = new Log();
            log.AbrirNovaTransferencia();

            foreach (FileInfo arquivo in diretorioOrigem.GetFiles())
            {
                File.Copy(arquivo.FullName, caminho.DiretorioDestino() + arquivo.Name);

                if (VerificarSeArquivoExisteNoDestino(arquivo))
                {
                    File.Move(arquivo.FullName, caminho.DiretorioEnviados() + arquivo.Name);
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

            log.FecharTransferencia(this.totalTransferidos);
        }

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

        private bool VerificarSeArquivoExisteNoDestino(FileInfo file)
        {
            foreach (FileInfo files in diretorioInfoDestino.GetFiles())
            {
                if (files.Name.ToString().Equals(file.Name))
                    return true;
            }
            return false;
        }

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

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            this.txtQuantidadeHistorico.Text = this.topHistoricoUser.ToString();
            this.txtQuantidadeHistorico.Refresh();
            ResetVariaveis_totalEncontrados_totalTransferidos();
            RecuperarTotalArquivosNoDiretorio(diretorioInfoOrigem);
            ExecutarTransferencia(diretorioInfoOrigem);
            AtualizarTxtUltimos();
        }

        public void ResetVariaveis_totalEncontrados_totalTransferidos()
        {
            this.totalEncontrados = 0;
            this.totalTransferidos = 0;
        }

        public void TimerCallback(Object o)
        {
            Invoke(new MethodInvoker(() => this.lblUltimaTransferencia.Text = DateTime.Now.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Text = this.topHistoricoUser.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Refresh()));
            ResetVariaveis_totalEncontrados_totalTransferidos();
            RecuperarTotalArquivosNoDiretorio(diretorioInfoOrigem);
            ExecutarTransferencia(diretorioInfoOrigem);
            AtualizarTxtUltimos();           
        }         
        

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (this.btnExecutar.Text.Equals("Iniciar"))
            {
                t = new System.Threading.Timer(TimerCallback, null, 0, 30000);
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
