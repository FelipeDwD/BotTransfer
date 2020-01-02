using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Apoio
{
    public struct Caminho
    {
        public string Caminhos(int line)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\FelipeN\Desktop\BotTransfer\WindowsFormsApp1\Caminhos.txt");
            string lineFolder = lines[line];
            string[] breaks = lineFolder.Split('@');
            string folder = breaks[2];
            return folder;
        }

        public string CaminhoOrigem()
        {
            var origem = Caminhos(0);
            return origem;
        }

        public string CaminhoDestino()
        {
            var destino = Caminhos(2);
            return destino;
        }

        public string CaminhoEnviados()
        {
            var enviados = Caminhos(1);
            return enviados;
        }
    }
}
