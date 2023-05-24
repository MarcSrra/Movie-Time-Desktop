using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using ProyectoCapraboEscritorio;

namespace DesktopWireframe.JSON
{
    internal class ManageJsonImagenes
    {
        private const String ruta = @"..\..\JSON\";

        public static BindingList<Imagenes> LeerJson(String dificultad)
        {
            String rutaFinal = ruta + dificultad + "_imagenes.json";
            JArray arrayImagenes = JArray.Parse(File.ReadAllText(rutaFinal, Encoding.UTF8));
            BindingList<Imagenes> imagenes = arrayImagenes.ToObject<BindingList<Imagenes>>();

            return imagenes;
        }

        public static void EscribirJson(BindingList<Imagenes> imagenes, String dificultad)
        {
            String rutaFinal = ruta + dificultad + "_imagenes.json";
            JArray arrayimagenes = (JArray)JToken.FromObject(imagenes);
            File.WriteAllText(rutaFinal, arrayimagenes.ToString());
        }
    }
}
