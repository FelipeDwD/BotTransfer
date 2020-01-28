using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Apoio
{
    public class Transferencia
    {
        private static string _origem;
        private static string _destino;
        private static string _enviados;

        public Diretorio diretorio { get; set; }
        public Log log { get; set; }   


        public string Origem
        {
            get { return _origem; }
            set
            {
                _origem = value;
            }
        }
        
        public string Destino
        {
            get { return _destino; }
            set
            {
                _destino = value;
            }
        }

        public string Enviados
        {
            get { return _enviados; }
            set
            {
                _enviados = value;
            }
        }

        public Transferencia(string origem, string destino, string enviados)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.Enviados = enviados;
        }     

        public void TransferenciaUnica(FileInfo arquivo)
        {
            try
            {
                File.Copy(arquivo.FullName, this.Destino + arquivo.Name);
            }
            catch (Exception)
            {


            }
        }
        
        public void MoverParaEnviados(FileInfo arquivo)
        {
            try
            {
                File.Move(arquivo.FullName, this.Enviados + arquivo.Name);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
