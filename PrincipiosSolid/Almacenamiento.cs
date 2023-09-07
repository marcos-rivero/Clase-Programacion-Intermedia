using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    public class Almacenamiento
    {
        string path = "C:/temp";
        public void EscribirArchivo(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string LeerArchivo(string titulo)
        {
            return File.ReadAllText($"{path}/{titulo}.txt");
        }
    }
}
