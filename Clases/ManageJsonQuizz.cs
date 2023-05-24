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
    internal class ManageJsonQuizz
    {
        private const String ruta = @"..\..\JSON\opciones_quizz.json";

        public static BindingList<Opciones> LeerJson()
        {
            JArray arrayopciones = JArray.Parse(File.ReadAllText(ruta, Encoding.UTF8));
            BindingList<Opciones> Opciones = arrayopciones.ToObject<BindingList<Opciones>>();

            return Opciones;
        }

        public static void EscribirJson(BindingList<Opciones> Opciones)
        {
            JArray arrayopciones = (JArray)JToken.FromObject(Opciones);
            File.WriteAllText(ruta, arrayopciones.ToString());
        }
    }
}
