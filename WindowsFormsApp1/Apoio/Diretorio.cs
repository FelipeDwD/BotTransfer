using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Apoio
{
    public class Diretorio
    {
        public string _diretorioDestino { get; set; }
        public DirectoryInfo diretorioInfoOrigem { get; set; } = new DirectoryInfo(DiretorioOrigem());
        public DirectoryInfo diretorioInfoDestino { get; set; } = new DirectoryInfo(DiretorioDestinoStatic());

        public List<FileInfo> arquivos { get; set; } = new List<FileInfo>();

        public Diretorio()
        {
            VerificarArquivosDiretorio();
        }

        public string DiretorioDestino
        {
            get { return _diretorioDestino; }
            set
            {
                _diretorioDestino = DiretorioDestinoStatic();
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

        public static string DiretorioOrigem()
        {
            var origem = DiretoriosDocTxt(0);
            return origem;
        }

        public static string DiretorioDestinoStatic()
        {
            var destino = DiretoriosDocTxt(2);
            return destino;
        }

        public string DiretorioEnviados()
        {
            var enviados = DiretoriosDocTxt(1);
            return enviados;
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
    }
}
