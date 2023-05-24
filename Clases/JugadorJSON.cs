using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWireframe
{
    public class JugadorJSON
    {
        public string user { get; set; }
        public string passwd { get; set; }
        public string ultimocambiopasswd { get; set; }
        public int puntuacion { get; set; }
        public string nombre { get; set; }
        public int fechanacimiento { get; set; }
        public string fotoperfil { get; set; }
        public string genero { get; set; }
    }
}
