using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1.Apoio
{
    public class Ftp
    {
        private static string _url;
        private static string _usuario;
        private static string _senha;
       

        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
            }
        }

        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }

        public Ftp(string url, string usuario, string senha)
        {           
            this.Url = url;
            this.Usuario = usuario;
            this.Senha = senha;
        }

        public static void EnviarArquivoFTP(FileInfo arquivo)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(_url));

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(_usuario, _senha);
                request.UseBinary = true;
                request.ContentLength = arquivo.Length;

                using (FileStream fs = arquivo.OpenRead())
                {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;

                    using (Stream stream = request.GetRequestStream())
                    {
                        while (bytesSent < arquivo.Length)
                        {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }
                }
            }
            catch (Exception e)
            {                
                MessageBox.Show(e.Message);
            }            
        }

    }
}
