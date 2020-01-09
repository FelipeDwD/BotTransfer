using System.IO;

namespace WindowsFormsApp1.Interfaces
{
    public interface IFtp
    {
        void EnviarArquivo(FileInfo file);
        void VerificarArquivo(FileInfo file);
    }
}
