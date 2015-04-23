using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2.Transversal.Log
{
    public class Logger
    {
        private string pathAtual = string.Empty;

        /// <summary>
        /// Classe de log
        /// </summary>
        /// <param name="mensagem"></param>
        public Logger()
        {

        }

        /// <summary>
        /// Grava log
        /// </summary>
        /// <param name="mensagem"></param>
        public void GravaLog(String mensagem)
        {
            pathAtual = "C:\\Users\\Rodrigo\\Documents\\Visual Studio 2012\\Projects\\Caliope";

            //Abrir o arquivo
            StreamWriter valor = new StreamWriter(pathAtual + "\\log.txt", true, Encoding.ASCII);

            //Escreve arquivo
            valor.WriteLine(mensagem);

            //Fecha o arquivo
            valor.Close();
        }
    }
}
