using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWireframe.Usuarios
{
    public class UsuarioJSON
    {
        public string user { get; set; }
        public string passwd { get; set; }
        public string ultimocambiopasswd { get; set; }
        public string type { get; set; }
        public string nombre { get; set; }
        public string fechanacimiento { get; set; }
        public string genero { get; set; }
    }
}
