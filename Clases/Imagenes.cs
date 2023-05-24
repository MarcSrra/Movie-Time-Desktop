using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWireframe
{
    public class Imagenes
    {
        public int id { get; set; }
        public int acierto { get; set; }
        public string imagen { get; set; }
        public string textocast { get; set; }
        public string textocat { get; set; }
        public string textoeng { get; set; }

        public Imagenes (int id, int acierto, string imagen, string texto_cast, string texto_cat, string texto_eng)
        {
            this.id = id;
            this.acierto = acierto;
            this.imagen = imagen;
            this.textocast = texto_cast;
            this.textocat = texto_cat;
            this.textoeng = texto_eng;
        }
    }


    
}