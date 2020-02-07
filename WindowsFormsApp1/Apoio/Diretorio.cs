using Renci.SshNet;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp1.Apoio
{
    public class Diretorio
    {
        private static string _origem { get; set; }
        public static string _destino { get; set; }
        public string BackUp { get; set; }

        public DirectoryInfo InfoOrigem { get; set; }
        public DirectoryInfo InfoDestino { get; set; }       

        public List<FileInfo> arquivos { get; set; } = new List<FileInfo>();

        public Diretorio(string origem, string destino, string backup)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.BackUp = backup;
            this.InfoOrigem = new DirectoryInfo(_origem);
            this.InfoDestino = new DirectoryInfo(_destino);
            this.AjustaDestinoPath();
            this.AjustaBackupPath();
            this.VerificarArquivosDiretorio();            
        }
        
        public string Origem
        {
            get => _origem;
            set
            {
                _origem = value;
            }
        }

        public string Destino
        {
            get => _destino;
            set
            {
                _destino = value;
            }
        }

        public void VerificarArquivosDiretorio()
        {
            foreach (FileInfo arquivo in InfoOrigem.GetFiles())
            {
                arquivos.Add(arquivo);
            }
        }

        public bool VerificarArquivoExisteNoDestino(FileInfo file)
        {
            foreach (FileInfo files in InfoDestino.GetFiles())
            {
                if (files.Name.ToString().Equals(file.Name))
                {
                    return true;
                }
            }
            return false;
        }

        public void LimparListaArquivos()
        {
            arquivos.Clear();
        }
        
        private void AjustaDestinoPath()
        {
            this.Destino += @"\";
        }

        private void AjustaBackupPath()
        {
            this.BackUp += @"\";
        }
    }
}
