
using LGT_SDK_NETCORE;
using LGT_SDK_NETCORE.Entities;
using System.Security.Cryptography.X509Certificates;


namespace SimuladorBackOffice.Models
{
    public class ContratacionLogalty
    {

        public ContratacionLogalty()
        {
            Config config = new Config();

            _pathWork = ""; 
            _fileToSend = "ContratoCONSUMOV14.pdf"; //Fichero ubicado en el directorio de trabajo a enviar
            _fileToSend1 = "CaratulaCONSUMOV15.pdf"; //Fichero ubicado en el directorio de trabajo a enviar
            _fileToSend2 = "SolicitudCONSUMOV14.pdf"; //Fichero ubicado en el directorio de trabajo a enviar
            _fileHTML = ""; //fichero HTML ubicado en el directorio de trabajo a enviar (PT0011_MESSAGE)
            _fileTextSMS = ""; //fichero txt ubicado en el directorio de trabajo a enviar (PT0011_MESSAGE)
 


         certificado = new X509Certificate2("C:\\Users\\DanielPerez\\Documents\\FOMEPADE.pfx", "logalty", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);

            ConnectSetting = new ConnectSetting
            {
                Url = config.UriLGTBUSDemo,//URL;
                                           //  Settings for Non Proxy
                ProxyType = config.ProxyTypeDefault
            };
        }
        private string _pathWork; //Directorio de entrada y salida de ficheros
        private string _fileToSend; //Fichero ubicado en el directorio de trabajo a enviar
        private string _fileToSend1; //Fichero ubicado en el directorio de trabajo a enviar
        private string _fileToSend2; //Fichero ubicado en el directorio de trabajo a enviar
        private string _fileHTML; //HTML de email PT0011_MESSAGE 
        private string _fileTextSMS; //SMS de PT0011_MESSAGE
        private X509Certificate2 certificado;
        private ConnectSetting connectSetting;


        public string PathWork { get => _pathWork; set => _pathWork = value; }
        public string FileToSend { get => _fileToSend; set => _fileToSend = value; }
        public string FileToSend1 { get => _fileToSend1; set => _fileToSend1 = value; }
        public string FileToSend2 { get => _fileToSend2; set => _fileToSend2 = value; }
        public string FileHTML { get => _fileHTML; set => _fileHTML = value; }
        public string FileTextSMS { get => _fileTextSMS; set => _fileTextSMS = value; }
        public X509Certificate2 Certificado { get => certificado; set => certificado = value; }
        public ConnectSetting ConnectSetting { get => connectSetting; set => connectSetting = value; }
        public string username { get; set; }
        public string age { get; set; }


    }
}
