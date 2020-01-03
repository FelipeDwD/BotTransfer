using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Apoio
{
    public struct Diretorio
    {
        public string DiretoriosDocTxt(int line)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\FelipeN\Desktop\BotTransfer\WindowsFormsApp1\Caminhos.txt");
            string lineFolder = lines[line];
            string[] breaks = lineFolder.Split('@');
            string folder = breaks[2];
            return folder;
        }

        public string DiretorioOrigem()
        {
            var origem = DiretoriosDocTxt(0);
            return origem;
        }

        public string DiretorioDestino()
        {
            var destino = DiretoriosDocTxt(2);
            return destino;
        }

        public string DiretorioEnviados()
        {
            var enviados = DiretoriosDocTxt(1);
            return enviados;
        }
    }
}
