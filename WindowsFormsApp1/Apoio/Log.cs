using System;
using System.IO;
using System.Text;


namespace WindowsFormsApp1.Apoio
{
    public struct Log
    {
        public DateTime dayLog;


        public void AbrirNovaTransferencia(string origemArquivoTransferencia, string destinoArquivoTransferencia, string pastaEnviadosTransferencia)
        {
            StringBuilder cabecalhoTransferencia = new StringBuilder();
            cabecalhoTransferencia.Append("\n\n\n========== Hora início: ");
            cabecalhoTransferencia.AppendLine(ReturnCurrentTime());
            cabecalhoTransferencia.Append("Origem: ");
            cabecalhoTransferencia.AppendLine(origemArquivoTransferencia);
            cabecalhoTransferencia.Append("Destino: ");
            cabecalhoTransferencia.AppendLine(destinoArquivoTransferencia);
            cabecalhoTransferencia.Append("Enviados: ");
            cabecalhoTransferencia.AppendLine(pastaEnviadosTransferencia);

            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
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
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
            {
                file.WriteLine($"\n\n{footerTransfer.ToString()}");
            }

        }

        public void RegistrarTransferenciaNoLog(FileInfo fileTransfer)
        {
            using (System.IO.StreamWriter file
                = new System.IO.StreamWriter($@"C:\Users\FelipeN\Desktop\TestFolder\{ReturnDayLog()}_LOG.txt", true))
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
