using System.IO;

namespace WindowsFormsApp1.Interfaces
{
    public interface ITransferencia
    {
        bool TransferenciaUnica(FileInfo file);
        bool TransferenciaVarios(FileInfo file);
    }
}
