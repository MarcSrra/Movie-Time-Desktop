using Newtonsoft.Json.Linq;
using ProyectoCapraboEscritorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWireframe.JSON
{
    public class ManageJsonJugadores
    {
        private const String NameFileJ = "jugadores.json";
        private const String DefPathJ = @"..\..\JSON\";
        private const String pathJ = DefPathJ + NameFileJ;

        public static BindingList<JugadorJSON> Leer()
        {
            JArray arrayJugadores = JArray.Parse(File.ReadAllText(pathJ, Encoding.Default));
            BindingList<JugadorJSON> jugadores = arrayJugadores.ToObject<BindingList<JugadorJSON>>();

            return jugadores;
        }

        public static void Escribir(BindingList<JugadorJSON> jugadores)
        {
            JArray arrayJugadores = (JArray)JToken.FromObject(jugadores);
            File.WriteAllText(pathJ, arrayJugadores.ToString());
        }
    }
}
