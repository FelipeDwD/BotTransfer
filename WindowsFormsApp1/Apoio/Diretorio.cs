using Renci.SshNet;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp1.Apoio
{
    public class Diretorio
    {
        private string _diretorioDestino { get; set; }
        private string _diretorioOrigem { get; set; }
        public string _diretorioEnviados { get; set; }
        public DirectoryInfo diretorioInfoOrigem { get; set; } = new DirectoryInfo(DiretorioOrigemStatic());
        public DirectoryInfo diretorioInfoDestino { get; set; } = new DirectoryInfo(DiretorioDestinoStatic());

        public List<FileInfo> arquivos { get; set; } = new List<FileInfo>();

        public Diretorio()
        {
            VerificarArquivosDiretorio();
            this.DiretorioOrigem = DiretorioOrigemStatic();
            this.DiretorioDestino = DiretorioDestinoStatic();
            this.DiretorioEnviados = DiretorioEnviadosStatic();
        }

        public string DiretorioDestino
        {
            get { return _diretorioDestino; }
            set
            {
                _diretorioDestino = value;
            }            
        }

        public string DiretorioOrigem
        {
            get { return _diretorioOrigem; }
            set
            {
                _diretorioOrigem = value;
            }
        }

        public string DiretorioEnviados
        {
            get { return _diretorioEnviados; }
            set
            {
                _diretorioEnviados = value;
            }
        }

        public static string DiretoriosDocTxt(int line)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\FelipeN\Desktop\BotTransfer\WindowsFormsApp1\Caminhos.txt");
            string lineFolder = lines[line];
            string[] breaks = lineFolder.Split('@');
            string folder = breaks[2];
            return folder;
        }

        public static string DiretorioOrigemStatic()
        {       
            var origem = DiretoriosDocTxt(0);
            return origem;
        }

        public static string DiretorioDestinoStatic()
        {
            var destino = DiretoriosDocTxt(2);
            return ValidarUltimoCaractere(destino);            
        }

        public static string DiretorioEnviadosStatic()
        {
            var enviados = DiretoriosDocTxt(1);
            return ValidarUltimoCaractere(enviados);           
        }

        public void VerificarArquivosDiretorio()
        {
            foreach (FileInfo arquivo in diretorioInfoOrigem.GetFiles())
            {
                arquivos.Add(arquivo);
            }
        }

        public bool VerificarArquivoExisteNoDestino(FileInfo file)
        {
            foreach (FileInfo files in diretorioInfoDestino.GetFiles())
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

        public static string ValidarUltimoCaractere(string caminho)
        {
            bool ultimo = caminho[caminho.Length - 1].ToString().Equals(@"\");            

            if(!ultimo)
                caminho += @"\";

            return caminho;
        }
    }
}
