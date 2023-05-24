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
    public partial class Ranking : Form
    {
        //Carga datos del JSON
        BindingList<JugadorJSON> jugadoresJSON = ManageJsonJugadores.Leer();
        BindingList<Jugador> jugadoresGrid = new BindingList<Jugador>();
        
        public Ranking()
        {
            InitializeComponent();
        }

        private void tablaUsuarios_Load(object sender, EventArgs e)
        {
            GenerarJugadores();
            actualizar();
            textBoxEditarUserName.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user;
            textBoxEditarPuntuacion.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].puntuacion.ToString();
        }

        //Crea una segunda List con los datos que queremos mostrar en GridView
        private void GenerarJugadores()
        {
            jugadoresJSON = ManageJsonJugadores.Leer();

            for (int i = 0; i < jugadoresJSON.Count; i++)
            {
                Jugador jugadorgrid = new Jugador();
                jugadorgrid.user = jugadoresJSON[i].user;
                jugadorgrid.ultimocambiopasswd = jugadoresJSON[i].ultimocambiopasswd;
                jugadorgrid.puntuacion = jugadoresJSON[i].puntuacion;

                jugadoresGrid.Add(jugadorgrid);
            }
        }

        //Refresca datos GridView
        private void actualizar()
        {
            dataGridViewUser.DataSource = null;
            dataGridViewUser.DataSource = jugadoresGrid;
            dataGridViewUser.Columns[0].HeaderText = "Usuario";
            dataGridViewUser.Columns[1].HeaderText = "Puntuación";
            dataGridViewUser.Columns[2].HeaderText = "Contraseña";
        }

        //Hacer click en una celda trae adelante el panel de edición y carga los datos de esa fila
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargar_datos_edit();

        }

        //Trae adelante el panel de edición de jugadores
        private void buttonOpcionEditar_Click(object sender, EventArgs e)
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
            textBoxAnadirPuntuacion.Text = "";
        }


        //Botón borrar jugador
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Comprueba si hay jugadores
            if(jugadoresGrid.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que deseas eliminar al jugador " +
                            dataGridViewUser.Rows[this.dataGridViewUser.CurrentRow.Index].Cells[0].Value + "?",
                            "Eliminar Jugador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                //Mensaje de confirmación afirmativo
                if (dr == DialogResult.Yes)
                {
                    //Borra datos de las 2 listas: Una actualiza el JSON y la otra el GridView
                    jugadoresJSON.Remove(jugadoresJSON[dataGridViewUser.CurrentRow.Index]);
                    jugadoresGrid.Remove(jugadoresGrid[dataGridViewUser.CurrentRow.Index]);

                    ManageJsonJugadores.Escribir(jugadoresJSON);
                    actualizar();

                    textBoxEditarUserName.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user;
                    textBoxEditarPuntuacion.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].puntuacion.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("No hay ningún jugador por eliminar", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                

        //Boton editar un jugador existente
        private void buttonGuardarEdit_Click(object sender, EventArgs e)
        {
            //Comproba que la puntuació sigui un int
            try
            {
                int puntuacion = Int32.Parse(textBoxEditarPuntuacion.Text);

                //Si se ha introducido nueva contraseña se actualiza este dato también
                if (!textBoxEditarContrasenaRegistro.Text.Equals("") && !textBoxEditarConfirmarContrasenaRegistro.Text.Equals(""))
                {

                    //Comprueba que la puntuación teng aun valor correcto (0 o superior), el jugador existe y el nombre no sea vacio
                    if (textBoxEditarUserName.Text != "" && puntuacion >= 0 && !UsuarioExisteActu(textBoxEditarUserName.Text, jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user))
                    {
                        //Comprueba que la contraseña y la confirmación sean iguales
                        if (textBoxEditarContrasenaRegistro.Text.Equals(textBoxEditarConfirmarContrasenaRegistro.Text))
                        {
                            //Edita datos de las 2 listas: Una actualiza el JSON y la otra el GridView

                            jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;
                            jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;

                            jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].puntuacion = puntuacion;
                            jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].puntuacion = puntuacion;

                            jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].passwd = EncriptarContrasena(textBoxEditarUserName.Text);

                            jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].ultimocambiopasswd = DateTime.Now.ToString();
                            jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].ultimocambiopasswd = DateTime.Now.ToString();
                            ManageJsonJugadores.Escribir(jugadoresJSON);

                            textBoxEditarUserName.Text = "";
                            textBoxEditarConfirmarContrasenaRegistro.Text = "";

                            actualizar();
                        }
                        else
                        {
                            MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxEditarConfirmarContrasenaRegistro.Text = "";
                        }
                    }
                    //Mensajes de error
                    else if (textBoxEditarUserName.Text != "" && puntuacion < 0 && !UsuarioExiste(textBoxEditarUserName.Text))
                    {
                        MessageBox.Show("La puntuación tiene que ser 0 o superior", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (textBoxEditarUserName.Text != "" && !UsuarioExiste(textBoxEditarUserName.Text))
                    {
                        MessageBox.Show("El usuario ya existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBoxEditarUserName.Text == "")
                    {
                        MessageBox.Show("Rellena el campo:\n * nombre Usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Editar la contraseña es opcional. Funciona igual sin actualizar ese dato
                else
                {
                    if (textBoxEditarUserName.Text != "" && puntuacion >= 0 && !UsuarioExiste(textBoxEditarUserName.Text))
                    {

                        jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;
                        jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user = textBoxEditarUserName.Text;

                        jugadoresJSON[this.dataGridViewUser.CurrentRow.Index].puntuacion = puntuacion;
                        jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].puntuacion = puntuacion;

                        ManageJsonJugadores.Escribir(jugadoresJSON);

                        textBoxEditarUserName.Text = "";
                        textBoxEditarContrasenaRegistro.Text = "";
                        textBoxEditarConfirmarContrasenaRegistro.Text = "";

                    }
                    else if (textBoxEditarUserName.Text != "" && puntuacion < 0 && !UsuarioExiste(textBoxEditarUserName.Text))
                    {
                        MessageBox.Show("La puntuación tiene que ser 0 o superior", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBoxEditarUserName.Text != "" && !UsuarioExiste(textBoxEditarUserName.Text))
                    {
                        MessageBox.Show("El usuario ya existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBoxEditarUserName.Text == "")
                    {
                        MessageBox.Show("Rellena el campo:\n * nombre Usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de puntuación incorrecto", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizar();
        }

        //Botón crear un nuevo jugador
        private void buttonCrearUser_Click(object sender, EventArgs e)
        {
            JugadorJSON userjson = new JugadorJSON();
            Jugador user = new Jugador();

            //Comprueba que todos los campos estén llenos
            if (AnadirCamposLlenos())
            {
                //Comprueba si el jugador que se quiere crear ya existe
                if (!UsuarioExiste(textBoxAnadirUserNombre.Text))
                {
                    //Comprueba que la contraseña y la confirmación coincidan
                    if (textBoxAnadirUserContrasena.Text.Equals(textBoxAnadirUserConfirmarContrasena.Text))
                    {
                        //Edita datos de las 2 listas: Una actualiza el JSON y la otra el GridView
                        userjson.user = textBoxAnadirUserNombre.Text;
                        userjson.passwd = EncriptarContrasena(textBoxAnadirUserContrasena.Text);
                        userjson.ultimocambiopasswd = DateTime.Now.ToString();
                        userjson.puntuacion = Int32.Parse(textBoxEditarPuntuacion.Text);
                        userjson.nombre = textBoxAnadirUserNombre.Text;
                        userjson.fechanacimiento = 2022;

                        user.user = textBoxAnadirUserNombre.Text;
                        user.ultimocambiopasswd = DateTime.Now.ToString();
                        user.puntuacion = Int32.Parse(textBoxEditarPuntuacion.Text);

                        jugadoresJSON.Add(userjson);
                        jugadoresGrid.Add(user);

                        panelAdd.Visible = false;
                        panelEdit.Visible = true;
                        panelEdit.BringToFront();

                        textBoxEditarUserName.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].user;
                        textBoxEditarPuntuacion.Text = jugadoresGrid[this.dataGridViewUser.CurrentRow.Index].puntuacion.ToString();
                        textBoxAnadirUserContrasena.Text = "";
                        textBoxAnadirUserConfirmarContrasena.Text = "";

                        ManageJsonJugadores.Escribir(jugadoresJSON);
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxAnadirUserConfirmarContrasena.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Carga datos del jugador en el panel de editar
        private void cargar_datos_edit()
        {
            Jugador jugador = (Jugador)dataGridViewUser.CurrentRow.DataBoundItem;
            panelAdd.Visible = false;
            panelEdit.Visible = true;
            panelEdit.BringToFront();

            textBoxEditarUserName.Text = jugador.user;
            textBoxEditarContrasenaRegistro.Text = "";
            textBoxEditarConfirmarContrasenaRegistro.Text = "";
            textBoxEditarPuntuacion.Text = jugador.puntuacion.ToString();
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

            for (int i = 0; i < jugadoresJSON.Count; i++)
            {
                if (nombreExistente.Equals(jugadoresJSON[i].user))
                {
                    existe = true;
                }
            }
            return existe;
        }

        public Boolean UsuarioExisteActu(String nombreExistente, String nombreDataGrid)
        {
            Boolean existe = false;

            for (int i = 0; i < jugadoresJSON.Count; i++)
            {
                
                if (nombreExistente.Equals(jugadoresJSON[i].user) && nombreExistente != nombreDataGrid)
                {
                    existe = true;
                }
                
            }
            return existe;
        }

        //Comprueba que los campos de añadir jugador estén llenos
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
            if(textBoxAnadirPuntuacion.Text == "")
            {
                mensaje += "\n * Puntuación";
                llenos = false;
            }

            try
            {
                int puntuacion = Int32.Parse(textBoxEditarPuntuacion.Text);
                if(puntuacion < 0)
                {
                    mensaje += "\n\nLa puntuación tiene que ser de 0 o superior";
                    llenos = false;
                }
            }
            catch (FormatException)
            {
                mensaje += "\n\nFormato de puntuación incorrecto";
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


