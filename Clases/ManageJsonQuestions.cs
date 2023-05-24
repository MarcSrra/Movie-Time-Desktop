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
    internal class ManageJsonQuestions
    {
        
        //public const String NameFile = "media_cast.json";
        private const String ruta = @"..\..\JSON\";
        //public const String rutaFinal = ruta + NameFile;

        public static BindingList<Pregunta> LeerJson(String dificultad, String idioma)
        {
            String rutaFinal = ruta + dificultad + "_" + idioma + ".json";
            JArray arrayPreguntas = JArray.Parse(File.ReadAllText(rutaFinal, Encoding.UTF8));
            BindingList<Pregunta> preguntas = arrayPreguntas.ToObject<BindingList<Pregunta>>();

            return preguntas;
        }

        public static void EscribirJson(BindingList<Pregunta> preguntas, String dificultad, String idioma)
        {
            String rutaFinal = ruta + dificultad + "_" + idioma + ".json";
            JArray arrayPreguntas = (JArray)JToken.FromObject(preguntas);
            File.WriteAllText(rutaFinal, arrayPreguntas.ToString());
        }
    }
}
