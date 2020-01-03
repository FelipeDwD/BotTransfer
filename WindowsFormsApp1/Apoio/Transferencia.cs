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

        public void TransferirTodos()
        {
            diretorio = new Diretorio();
            log = new Log();
            log.AbrirNovaTransferencia();

            foreach (FileInfo arquivo in diretorio.diretorioInfoOrigem.GetFiles())
            {
                File.Copy(arquivo.FullName, diretorio.DiretorioDestino + arquivo.Name);

                if (diretorio.VerificarArquivoExisteNoDestino(arquivo))
                {
                    File.Move(arquivo.FullName, diretorio.DiretorioEnviados() + arquivo.Name);
                    log.RegistrarTransferenciaNoLog(arquivo);

                }
            }
        }

        public bool TransferenciaUnica(FileInfo arquivo)
        {        
             File.Copy(arquivo.FullName, diretorio.DiretorioDestino + arquivo.Name);

            if (diretorio.VerificarArquivoExisteNoDestino(arquivo))
            {
                MoverParaEnviados(arquivo);
                return true;
            }
            return false;
        }
        
        public void MoverParaEnviados(FileInfo arquivo)
        {
            File.Move(arquivo.FullName, diretorio.DiretorioEnviados() + arquivo.Name);
        }
    }
}
