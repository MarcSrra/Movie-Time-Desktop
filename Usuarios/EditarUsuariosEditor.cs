using DesktopWireframe;
using DesktopWireframe.JSON;
using DesktopWireframe.Usuarios;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoCapraboEscritorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class EditarUsuariosEditor : Form
    {
        BindingList<UsuarioJSON> usuariosJSON = ManageJsonUsers.Leer();
        BindingList<Usuario> usuariosGrid = new BindingList<Usuario>();

        public EditarUsuariosEditor()
        {
            InitializeComponent();
        }

        private void GenerarUsuarios()
        {
            usuariosJSON = ManageJsonUsers.Leer();
            
            for (int i = 0; i < usuariosJSON.Count; i++)
            {
                Usuario usuariogrid = new Usuario();
                usuariogrid.user = usuariosJSON[i].user;
                usuariogrid.ultimocambiopasswd = usuariosJSON[i].passwd;
                usuariogrid.type = usuariosJSON[i].type;

                usuariosGrid.Add(usuariogrid);
            }
        }


        private void tablaUsuarios_Load(object sender, EventArgs e)
        {
            GenerarUsuarios();
            actualizar();
            comboBoxAnadirTipoUser.Text = "Normal";
            comboBoxAnadirTipoUser.Enabled = false;
        }

        //Refresca datos GridView
        public void actualizar()
        {
            dataGridViewUser.DataSource = null;
            dataGridViewUser.DataSource = usuariosGrid;
            dataGridViewUser.Columns[0].HeaderText = "Usuario";
            dataGridViewUser.Columns[1].HeaderText = "Tipo";
            dataGridViewUser.Columns[2].HeaderText = "Contraseña";
        }

        //Botón crear un nuevo usuario
        private void buttonCrearUser_Click(object sender, EventArgs e)
        {
            UsuarioJSON userjson = new UsuarioJSON();
            Usuario user = new Usuario();

            //Comprueba que todos los campos estén llenos
            if (AnadirCamposLlenos())
            {
                //Comprueba si el usuario que se quiere crear ya existe
                if (!UsuarioExiste(textBoxAnadirUserNombre.Text) && textBoxAnadirUserNombre.Text != "superadmin")
                {
                    //Comprueba que la contraseña y la confirmación coincidan
                    if (textBoxAnadirUserContrasena.Text.Equals(textBoxAnadirUserConfirmarContrasena.Text))
                    {
                        //Edita datos de las 2 listas: Una actualiza el JSON y la otra el GridView
                        //El Editor solo puede crear usuarios de tipo NORMAL
                        userjson.user = textBoxAnadirUserNombre.Text;
                        userjson.passwd = EncriptarContrasena(textBoxAnadirUserContrasena.Text);
                        userjson.ultimocambiopasswd = DateTime.Now.ToString();
                        userjson.type = "Normal";
                        userjson.nombre = textBoxAnadirUserNombre.Text;
                        userjson.fechanacimiento = DateTime.Now.ToString();
                        userjson.genero = "Otro";

                        user.user = textBoxAnadirUserNombre.Text;
                        user.ultimocambiopasswd = DateTime.Now.ToString();
                        user.type = "Normal";

                        usuariosGrid.Add(user);
                        usuariosJSON.Add(userjson);

                        textBoxAnadirUserNombre.Text = "";
                        textBoxAnadirUserContrasena.Text = "";
                        textBoxAnadirUserConfirmarContrasena.Text = "";

                        ManageJsonUsers.Escribir(usuariosJSON);
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxAnadirUserConfirmarContrasena.Text = "";
                    }
                }
                else if (textBoxAnadirUserNombre.Text == "superadmin")
                {
                    MessageBox.Show("No se pueden eliminar el usuario superadmin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Recibe contrtaseña y la devuelve encriptada en forma de String
        public static String EncriptarContrasena(String contraseña)
        {
            var ContraseñaEncriptada = BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña);

            return ContraseñaEncriptada;
        }


        //Comprueba si el usuario existe
        public Boolean UsuarioExiste(String nombreExistente)
        {
            Boolean existe = false;
            
            for (int i = 0; i < usuariosJSON.Count; i++)
            {
                if (nombreExistente.Equals(usuariosJSON[i].user))
                {
                    existe = true;
                }
            }
            return existe;
        }

        //Comprueba que los campos de añadir usuario estén llenos
        public Boolean AnadirCamposLlenos()
        {
            Boolean llenos = true;
            String mensaje = "Rellena los siguientes campos para poder guardar el nuevo usuario: \n";

            if (textBoxAnadirUserNombre.Text == "")
            {
                mensaje += "\n * nombre de usuario";
                llenos = false;
            }
            if (textBoxAnadirUserContrasena.Text == "")
            {
                mensaje += "\n * Contraseña";
                llenos = false;
            }
            if(textBoxAnadirUserConfirmarContrasena.Text == "")
            {
                mensaje += "\n * Confirmar contraseña";
                llenos = false;
            }
            if(comboBoxAnadirTipoUser.Text == "")
            {
                mensaje += "\n * Tipo de usuario";
                llenos = false;
            }

            if (llenos == false)
            {
                MessageBox.Show(mensaje, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return llenos;
        }
    }
}


