using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Apoio;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetFileInfoLenght(5);
            System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 0, 60000);
        }       

        StringBuilder sb = new StringBuilder();       

        static string[] lines = File.ReadAllLines(@"C:\Users\FelipeN\Desktop\BotTransfer\WindowsFormsApp1\Caminhos.txt");

        static string source_line = lines[0];
        static string sent_line = lines[1];
        static string destiny_line = lines[2];

        static string[] source_breaks = source_line.Split('@');
        static string[] sent_breaks = sent_line.Split('@');
        static string[] destiny_breaks = destiny_line.Split('@');

        static string source = source_breaks[2];
        static string sent = sent_breaks[2];
        static string destiny = destiny_breaks[2];

        static string directorySource = $@"{source}";
        static string directoryDestiny = $@"{destiny}";
        static string directorySent = $@"{sent}";

        DirectoryInfo directoryInfoSource = new DirectoryInfo(directorySource);
        DirectoryInfo directoryInfoDestiny = new DirectoryInfo(directoryDestiny);


        FileInfo[] historyLast;
        int count = 0;
        int totalTransferidos = 0;
        int totalEncontrados = 0;
        int topHistoricoUser = 5;

        private void SetTotalFilesInDirectory(DirectoryInfo directory)
        {
            foreach (FileInfo file in directory.GetFiles())
            {
                this.totalEncontrados++;
            }
            Invoke(new MethodInvoker(() => this.lblTotalEncontrados.Text = this.totalEncontrados.ToString()));
            Invoke(new MethodInvoker(() => this.lblTotalEncontrados.Refresh()));
            
        }

        private void Process(DirectoryInfo directory)
        {
            FileTxt file = new FileTxt();
            file.OpenNewTransferLog();

            foreach (FileInfo fileSource in directory.GetFiles())
            {
                File.Copy(fileSource.FullName, directoryDestiny + fileSource.Name);

                if (ExistsInDestiny(fileSource))
                {
                    File.Move(fileSource.FullName, directorySent + fileSource.Name);
                    file.RegisterTransfInLog(fileSource);
                    UpdateHistoryList(fileSource);
                    historyLast[ReturnSizeHistory()] = fileSource;
                    UpdatelblTotalTransferidos();

                    if (count <= this.historyLast.Length)
                    {
                        UpdateLast(this.historyLast);
                    }
                    count++;
                }
            }

            file.CloseTransfer(count);
        }

        public string ReturnLast(FileInfo[] files)
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

        private bool ExistsInDestiny(FileInfo file)
        {
            foreach (FileInfo files in directoryInfoDestiny.GetFiles())
            {
                if (files.Name.ToString().Equals(file.Name))
                    return true;
            }
            return false;
        }

        public void UpdateLast(FileInfo[] files)
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Refresh()));            
            for (int i = 0; i < (files.Length - 1); i++)
            {
                files[i] = files[(i + 1)];
            }
        }

        public int ReturnSizeHistory()
        {
            return this.historyLast.Length - 1;
        }

        public void UpdatelblTotalTransferidos()
        {
            this.totalTransferidos++;
            Invoke(new MethodInvoker(() => this.lblTotalTransferidos.Refresh()));
            Invoke(new MethodInvoker(() => this.lblTotalTransferidos.Text = this.totalTransferidos.ToString()));            
        }

        public void UpdateHistoryList(FileInfo file)
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Refresh()));            
            sb.Append(file.Name);
            sb.Append(" - ");
            sb.AppendLine(DateTime.Now.ToString());
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = sb.ToString()));            
            sb.Clear();
        }

        public void UpdateTxtUltimos()
        {
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = ""));
            Invoke(new MethodInvoker(() => this.lblListaHistorico.Text = ReturnLast(this.historyLast)));            
        }

        public void NewFileInfo(int lenght)
        {
            historyLast = new FileInfo[lenght];
        }

        public void SetFileInfoLenght(int lenght)
        {
            NewFileInfo(lenght);
            count = 0;
        }

        public void ShowMessageNotifyAmountHistory(int registerInList)
        {
            MessageBox.Show($"A lista irá trazer os últimos {registerInList} somente na próxima execução");
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.topHistoricoUser = int.Parse(this.txtQuantidadeLista.Text.ToString());
            int registerInListRequeriedUser = int.Parse(this.txtQuantidadeLista.Text.ToString());
            SetFileInfoLenght(registerInListRequeriedUser);
            ShowMessageNotifyAmountHistory(registerInListRequeriedUser);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            this.txtQuantidadeHistorico.Text = this.topHistoricoUser.ToString();
            this.txtQuantidadeHistorico.Refresh();
            ResetLabelTransferidos_Encontrados();
            SetTotalFilesInDirectory(directoryInfoSource);
            Process(directoryInfoSource);
            UpdateTxtUltimos();
        }

        public void ResetLabelTransferidos_Encontrados()
        {
            this.totalEncontrados = 0;
            this.totalTransferidos = 0;
        }

        public void TimerCallback(Object o)
        {
            Invoke(new MethodInvoker(() => this.lblUltimaTransferencia.Text = DateTime.Now.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Text = this.topHistoricoUser.ToString()));
            Invoke(new MethodInvoker(() => this.txtQuantidadeHistorico.Refresh()));
            ResetLabelTransferidos_Encontrados();
            SetTotalFilesInDirectory(directoryInfoSource);
            Process(directoryInfoSource);
            UpdateTxtUltimos();
        }     
    }
}
