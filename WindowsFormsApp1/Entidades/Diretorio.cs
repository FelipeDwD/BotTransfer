using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Diretorio
    {
        public string NomeDiretorio { get; set; }
        public string[] Linhas = File.ReadAllLines(@"C:\Users\FelipeN\Desktop\BotTransfer\WindowsFormsApp1\Caminhos.txt");
        public string _diretorio_linha;    


        public Diretorio(string nomeDiretorio, string  diretorio_linha)
        {
            this.NomeDiretorio = nomeDiretorio;           
            this.Diretorio_Linha = diretorio_linha;
        }     

        public string Diretorio_Linha
        {
            get => _diretorio_linha;
            set
            {
                _diretorio_linha = value;
            }
        }

        public override string ToString()
        {
            return "a";
        }
    }
}
