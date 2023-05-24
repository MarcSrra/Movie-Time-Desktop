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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class EditarUsuariosAdmin : Form
    {
        //Carga datos del JSON
        BindingList<UsuarioJSON> usuariosJSON = ManageJsonUsers.Leer();
        BindingList<Usuario> usuariosGrid = new BindingList<Usuario>();


        public EditarUsuariosAdmin()
        {
            InitializeComponent();
        }


        private void tablaUsuarios_Load(object sender, EventArgs e)
        {
            GenerarUsuarios();
            actualizar();
            cargar_datos_edit();
        }

        //Crea una segunda List con los datos que queremos mostrar en GridView
        private void GenerarUsuarios()
        {
            usuariosJSON = ManageJsonUsers.Leer();

            for (int i = 0; i < usuariosJSON.Count; i++)
            {
                Usuario usuariogrid = new Usuario();
                usuariogrid.user = usuariosJSON[i].user;
                usuariogrid.ultimocambiopasswd = usuariosJSON[i].ultimocambiopasswd;
                usuariogrid.type = usuariosJSON[i].type;

                usuariosGrid.Add(usuariogrid);
            }
        }

        //Refresca datos GridView
        private void actualizar()
        {
            dataGridViewUser.DataSource = null;
            dataGridViewUser.DataSource = usuariosGrid;
            dataGridViewUser.Columns[0].HeaderText = "Usuario";
            dataGridViewUser.Columns[1].HeaderText = "Tipo";
            dataGridViewUser.Columns[2].HeaderText = "Contraseña";
        }

        //Trae adelante el panel de edición de jugadores
        private void buttonOpcionEditar_Click(object sender, EventArgs e)
        {
            cargar_datos_edit();
        }

        //Hacer click en una celda trae adelante el panel de edición y carga los datos de esa fila
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar_datos_edit();
        }

        //Trae adelante el panel de creación de jugadores
        private void buttonOpcionAnadir_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelAdd.Visible = true;
            panelAdd.BringToFront();
            textBoxAnadirUserNombre.Text = "";
            textBoxAnadirUserContrasena.Text = "";
            textBoxAnadirUserConfirmarContrasena.Text = "";
            comboBoxAnadirTipoUser.SelectedIndex = -1;
        }

        //Botón borrar usuario
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Comprueba si el usuario es superadmin. Superadmin no se puede borrar
            if(usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user != "superadmin")
            {
                //No se pueden borrar todos los usuarios administrador                
                if (ComprobarNumeroAdmins())
                {
                    DialogResult dr = MessageBox.Show("¿Seguro que deseas eliminar el usuario " +
                        dataGridViewUser.Rows[this.dataGridViewUser.CurrentRow.Index].Cells[0].Value + "?",
                        "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //Mensaje de confirmación afirmativo
                    if (dr == DialogResult.Yes)
                    {
                        //Borra datos de las 2 listas: Una actualiza el JSON y la otra el GridView
                        usuariosJSON.Remove(usuariosJSON[dataGridViewUser.CurrentRow.Index]);
                        usuariosGrid.Remove(usuariosGrid[this.dataGridViewUser.CurrentRow.Index]);
                        ManageJsonUsers.Escribir(usuariosJSON);
                        actualizar();

                        textBoxEditarUserName.Text = usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user;
                        comboBoxEditarTipoUsuario.Text = usuariosGrid[this.dataGridViewUser.CurrentRow.Index].type;
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden eliminar todos los usuarios administrador", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pueden eliminar el usuario superadmin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Boton editar un usuario existente
        private void buttonGuardarEdit_Click(object sender, EventArgs e)
        {
            //No se puede editar el usuario superadmin
            if (usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user != "superadmin")
            {
                //Si se ha introducido nueva contraseña se actualiza este dato también
                if (!textBoxEditarContrasenaRegistro.Text.Equals("") && !textBoxEditarConfirmarContrasenaRegistro.Text.Equals(""))
                {
                    //COmprueba que el campo del nombre no esté vacio
                    if (textBoxEditarUserName.Text != "")
                    {
                        //Comprueba que la contraseña y la confirmación sean iguales
                        if (textBoxEditarContrasenaRegistro.Text.Equals(textBoxEditarConfirmarContrasenaRegistro.Text))
                        {
                            //Edita datos de las 2 listas: Una actualiza el JSON y la otra el GridView

                            usuariosJSON[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;
                            usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;

                            usuariosJSON[this.dataGridViewUser.CurrentRow.Index].type = comboBoxEditarTipoUsuario.Text;
                            usuariosGrid[this.dataGridViewUser.CurrentRow.Index].type = comboBoxEditarTipoUsuario.Text;

                            usuariosJSON[this.dataGridViewUser.CurrentRow.Index].passwd = EncriptarContrasena(textBoxEditarUserName.Text);
                            
                            usuariosJSON[this.dataGridViewUser.CurrentRow.Index].ultimocambiopasswd = DateTime.Now.ToString();
                            usuariosGrid[this.dataGridViewUser.CurrentRow.Index].ultimocambiopasswd = DateTime.Now.ToString();

                            ManageJsonUsers.Escribir(usuariosJSON);
                            textBoxEditarUserName.Text = "";
                            textBoxEditarContrasenaRegistro.Text = "";
                            textBoxEditarConfirmarContrasenaRegistro.Text = "";

                        }
                        else
                        {

                            MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxEditarConfirmarContrasenaRegistro.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellena el campo:\n * nombre Usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                //Editar la contraseña es opcional. Funciona igual sin actualizar ese dato
                else
                {
                    if (textBoxEditarUserName.Text != "" && textBoxEditarUserName.Text != null)
                    {
                        usuariosJSON[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;
                        usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;

                        usuariosJSON[this.dataGridViewUser.CurrentRow.Index].type = comboBoxEditarTipoUsuario.Text;
                        usuariosGrid[this.dataGridViewUser.CurrentRow.Index].type = comboBoxEditarTipoUsuario.Text;

                        ManageJsonUsers.Escribir(usuariosJSON);
                        textBoxEditarUserName.Text = "";
                        textBoxEditarConfirmarContrasenaRegistro.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un usuario a editar", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede editar el usuario superadmin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizar();
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
                if (!UsuarioExiste(textBoxAnadirUserNombre.Text))
                {
                    //Comprueba que la contraseña y la confirmación coincidan
                    if (textBoxAnadirUserContrasena.Text.Equals(textBoxAnadirUserConfirmarContrasena.Text))
                    {
                        //Edita datos de las 2 listas: Una actualiza el JSON y la otra el GridView
                        userjson.user = textBoxAnadirUserNombre.Text;
                        userjson.passwd = EncriptarContrasena(textBoxAnadirUserContrasena.Text);
                        userjson.ultimocambiopasswd = DateTime.Now.ToString();
                        userjson.type = comboBoxAnadirTipoUser.Text;
                        userjson.nombre = textBoxAnadirUserNombre.Text;
                        userjson.fechanacimiento = DateTime.Now.ToString();
                        userjson.genero = "Otro";

                        user.user = textBoxAnadirUserNombre.Text;
                        user.ultimocambiopasswd = DateTime.Now.ToString();
                        user.type = comboBoxAnadirTipoUser.Text;

                        usuariosGrid.Add(user);
                        usuariosJSON.Add(userjson);
                        ManageJsonUsers.Escribir(usuariosJSON);
                        actualizar();

                        panelAdd.Visible = false;
                        panelEdit.Visible = true;
                        panelEdit.BringToFront();

                        textBoxEditarUserName.Text = usuariosGrid[this.dataGridViewUser.CurrentRow.Index].user;
                        comboBoxEditarTipoUsuario.Text = usuariosGrid[this.dataGridViewUser.CurrentRow.Index].type;
                        textBoxAnadirUserContrasena.Text = "";
                        textBoxAnadirUserConfirmarContrasena.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxAnadirUserConfirmarContrasena.Text = "";
                    }
                }
                else if (textBoxAnadirUserNombre.Text == "Superadmin" || textBoxAnadirUserNombre.Text == "superadmin")
                {
                    MessageBox.Show("No se pueden crear más usuarios superadmin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Comprueba que al menos exista más de un admin
        private Boolean ComprobarNumeroAdmins()
        {
            Boolean result = true;
            int admins = 0;

            for (int i = 0; i < usuariosGrid.Count; i++)
            {
                if (usuariosGrid[i].type.Equals("Admin"))
                {
                    admins++;
                }
            }

            if(admins <= 1)
            {
                result = false;
            }

            return result;
        }

        //Recibe contrtaseña y la devuelve encriptada en forma de String
        private static String EncriptarContrasena(String contraseña)
        {
            var ContraseñaEncriptada = BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña);

            return ContraseñaEncriptada;
        }


        //Carga datos del usuario en el panel de editar
        private void cargar_datos_edit()
        {
            Usuario usuario = (Usuario)dataGridViewUser.CurrentRow.DataBoundItem;

            //Superadmin no se puede editar, no carga los datos de superadmin el pulsar el botón
            if (usuario.user != "superadmin")
            {
                panelAdd.Visible = false;
                panelEdit.Visible = true;
                panelEdit.BringToFront();

                textBoxEditarUserName.Text = usuario.user;
                textBoxEditarUserName.ReadOnly = false;
                comboBoxEditarTipoUsuario.Text = usuario.type;
                comboBoxEditarTipoUsuario.Enabled = true;
                textBoxEditarContrasenaRegistro.Text = "";
                textBoxEditarContrasenaRegistro.ReadOnly = false;
                textBoxEditarConfirmarContrasenaRegistro.Text = "";
                textBoxEditarConfirmarContrasenaRegistro.ReadOnly = false;
            }
            else
            {
                panelAdd.Visible = false;
                panelEdit.Visible = true;
                panelEdit.BringToFront();

                textBoxEditarUserName.Text = usuario.user;
                textBoxEditarUserName.ReadOnly = true;
                comboBoxEditarTipoUsuario.SelectedIndex = -1;
                comboBoxEditarTipoUsuario.Enabled = false;
                textBoxEditarContrasenaRegistro.Text = "";
                textBoxEditarContrasenaRegistro.ReadOnly = true;
                textBoxEditarConfirmarContrasenaRegistro.Text = "";
                textBoxEditarConfirmarContrasenaRegistro.ReadOnly = true;
            }
        }


        //Comprueba si el usuario existe
        private Boolean UsuarioExiste(String nombreExistente)
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
        private Boolean AnadirCamposLlenos()
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


