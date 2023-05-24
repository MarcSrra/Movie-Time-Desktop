using DesktopWireframe.Usuarios;
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
    public class ManageJsonUsers
    {
        private const String NameFile = "usuarios.json";
        private const String DefPath = @"..\..\JSON\";
        private const String path = DefPath + NameFile;

        public static BindingList<UsuarioJSON> Leer()
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(path, Encoding.UTF8));
            BindingList<UsuarioJSON> users = arrayUsers.ToObject<BindingList<UsuarioJSON>>();

            return users;
        }

        public static void Escribir(BindingList<UsuarioJSON> usuarios)
        {
            JArray arrayUsers = (JArray)JToken.FromObject(usuarios);
            File.WriteAllText(path, arrayUsers.ToString());
        }
    }
}
