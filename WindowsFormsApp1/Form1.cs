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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetFileInfoLenght(5);
        }

        StringBuilder sb = new StringBuilder();

        static string directorySource = @"C:\Users\Felipe Neves\Desktop\direct\source";
        static string directoryDestiny = @"C:\Users\Felipe Neves\Desktop\direct\destiny\";
        static string directorySent = @"C:\Users\Felipe Neves\Desktop\direct\source\sent\";

        DirectoryInfo directoryInfoSource = new DirectoryInfo(directorySource);
        DirectoryInfo directoryInfoDestiny = new DirectoryInfo(directoryDestiny);

        FileInfo[] historyLast;
        int count = 0;
        int totalTransferidos = 0;
        int totalEncontrados = 0;

        private void SetTotalFilesInDirectory(DirectoryInfo directory)
        {
            foreach (FileInfo file in directory.GetFiles())
            {
                this.totalEncontrados++;
            }
            this.lblTotalEncontrados.Text = this.totalEncontrados.ToString();
            this.lblTotalEncontrados.Refresh();
        }

        private void Process(DirectoryInfo directory)
        {
            foreach (FileInfo fileSource in directory.GetFiles())
            {
                File.Copy(fileSource.FullName, directoryDestiny + fileSource.Name);

                if (ExistsInDestiny(fileSource))
                {
                    File.Move(fileSource.FullName, directorySent + fileSource.Name);
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
            this.lblListaHistorico.Text = "";
            this.lblListaHistorico.Refresh();
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
            this.lblTotalTransferidos.Refresh();
            this.lblTotalTransferidos.Text = this.totalTransferidos.ToString();                       
        }

        public void UpdateHistoryList(FileInfo file)
        {
            this.lblListaHistorico.Refresh();
            sb.Append(file.Name);
            sb.Append(" - ");
            sb.AppendLine(DateTime.Now.ToString());
            this.lblListaHistorico.Text = sb.ToString();
            sb.Clear();
        }

        public void UpdateTxtUltimos()
        {
            this.lblListaHistorico.Text = "";
            this.lblListaHistorico.Text = ReturnLast(this.historyLast);
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
            int registerInListRequeriedUser = int.Parse(this.txtQuantidadeLista.Text.ToString());
            SetFileInfoLenght(registerInListRequeriedUser);
            ShowMessageNotifyAmountHistory(registerInListRequeriedUser);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
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
       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
