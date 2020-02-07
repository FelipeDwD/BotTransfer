using System;
using System.IO;
using System.Text;


namespace WindowsFormsApp1.Apoio
{
    public class Log
    {
        public DateTime dayLog;
        public string Diretorio { get; set; }

        public Log(string diretorio)
        {
            this.Diretorio = diretorio;
        }

        public void AbrirNovaTransferencia(string origemArquivoTransferencia, string destinoArquivoTransferencia, string pastaEnviadosTransferencia)
        {
            StringBuilder cabecalhoTransferencia = new StringBuilder();
            cabecalhoTransferencia.Append("\n\n\n\n:: :: :: :: :: :: :: :: Hora início: ");
            cabecalhoTransferencia.AppendLine(ReturnCurrentTime());
            cabecalhoTransferencia.Append("Origem: ");
            cabecalhoTransferencia.AppendLine(origemArquivoTransferencia);
            cabecalhoTransferencia.Append("Destino: ");
            cabecalhoTransferencia.AppendLine(destinoArquivoTransferencia);
            cabecalhoTransferencia.Append("Back-up: ");
            cabecalhoTransferencia.AppendLine(pastaEnviadosTransferencia);

            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"{this.Diretorio}\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n\n{cabecalhoTransferencia.ToString()}");
            }
        }

        public void FecharTransferencia(int totalTransf)
        {
            StringBuilder footerTransfer = new StringBuilder();
            footerTransfer.Append("Hora término: ");
            footerTransfer.AppendLine(ReturnCurrentTime());
            footerTransfer.Append("Total transferidos: ");
            footerTransfer.AppendLine(totalTransf.ToString());

            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"{this.Diretorio}\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n\n{footerTransfer.ToString()}");
            }

        }

        public void RegistrarTransferenciaNoLog(FileInfo fileTransfer)
        {
            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"{this.Diretorio}\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n {fileTransfer.Name} - {fileTransfer.Length} bytes :: {ReturnCurrentTime()}");
            }
        }

        public string ReturnDayLog()
        {
            dayLog = DateTime.Now;
            return dayLog.ToString("yyyy-MM-dd");           
        }

        public string ReturnCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
