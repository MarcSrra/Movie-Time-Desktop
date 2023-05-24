using DesktopWireframe;
using DesktopWireframe.JSON;
using DesktopWireframe.Usuarios;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace ProyectoCapraboEscritorio
{
    public partial class LogSign : Form
    {
        BindingList<UsuarioJSON> usuariosJSON = new BindingList<UsuarioJSON>();

        Icon icon = Icon.ExtractAssociatedIcon(@"..\..\Resources\logocirculoancho.ico");

        String contraseña;
        String nombreUsuario;



        public LogSign()
        {
            InitializeComponent();
        }

        public LogSign(String contr)
        {
            this.contraseña = contr;
            textBoxContraseña.Text = contraseña;
            textBoxNomUs.Text = nombreUsuario;
        }

        private void PantallaInicioSesion_Load(object sender, EventArgs e)
        {
            this.Icon = icon;
            
            VisualReset();
        }

        //Botón Log in. Comprueba tus datos y asigna un tipo de menú en función del rol del usuario
        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            Boolean comprobar = false;
            foreach (UsuarioJSON user in usuariosJSON)
            {
                if (user.user.Equals(textBoxNomUs.Text) && ValidarContrasena(textBoxContraseña.Text, user.passwd))
                {
                    comprobar = true;
                    if (comprobar == true)
                    {

                        switch (user.type)
                        {
                            case "Normal":
                                this.Hide();
                                MenuUserNormal normal = new MenuUserNormal();
                                normal.ShowDialog();
                                normal = null;
                                VisualReset();
                                this.Show();
                                break;
                            case "Admin":
                            case "Superadmin":
                                this.Hide();
                                MenuAdmin admin = new MenuAdmin();
                                admin.ShowDialog();
                                admin = null;
                                VisualReset();
                                this.Show();
                                break;
                            case "Editor":
                                this.Hide();
                                MenuEditor editor = new MenuEditor();
                                editor.ShowDialog();
                                editor = null;
                                VisualReset();
                                this.Show();
                                break;
                            default:
                                MessageBox.Show("Tipo incorrecto, contacte con un administrador", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }



                    }
                }
            }
            if (comprobar == false)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Registra un nuevo usuario
        private void buttonCrear_Click(object sender, EventArgs e)
        {

            Boolean coincide, existe, puesto;

            //Comprobar que el usuario no existe
            existe = UsuarioExiste(textBoxUserName.Text);

            //Coinciden las contraseñas
            coincide = ConfirmarContrasena(textBoxContraseñaRegistro.Text, textBoxConfirmarContraseñaRegistro.Text);

            //Confirmar que los campos estan rellenados
            puesto = DatosRellenos(textBoxUserName.Text, textBoxNomRegistre.Text, BtnSexoHombre.Checked, BtnSexoMujer.Checked);

            if (coincide == true && puesto == true && existe == false)
            {
                UsuarioJSON usuario = new UsuarioJSON();
                usuario.user = textBoxUserName.Text;
                usuario.passwd = EncriptarContrasena(textBoxContraseñaRegistro.Text);
                usuario.ultimocambiopasswd = DateTime.Now.ToString();
                usuario.type = "Normal";
                usuario.nombre = textBoxNomRegistre.Text;
                usuario.fechanacimiento = dateTimePicker1.Text;
                usuario.genero = Genero();
                
                usuariosJSON.Add(usuario);

                ManageJsonUsers.Escribir(usuariosJSON);
                this.Hide();
                MenuUserNormal normal = new MenuUserNormal();
                normal.ShowDialog();
                normal = null;
                VisualReset();
                this.Show();
                
            }
            else
            {
                //Mensaje contraseña no coincide
                if (coincide == false)
                {
                    MessageBox.Show("La contraseña no coincide", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Mensaje campos no rellenados
                if (puesto == false)
                {
                    MessageBox.Show("Rellena todos los campos", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Mensaje usuario existe
                if (existe == true)
                {
                    MessageBox.Show("El usuario ya exite", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
        public static String EncriptarContrasena(String contraseña)
        {
            var ContraseñaEncriptada = BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña);

            return ContraseñaEncriptada;
        }
        public static Boolean ValidarContrasena(String contraseñaNormal, String ContraseñaEncriptada)
        {
            var ValidarContraseña = BCrypt.Net.BCrypt.EnhancedVerify(contraseñaNormal, ContraseñaEncriptada);
            return ValidarContraseña;
        }

        public static Boolean ConfirmarContrasena (String contrasena, String confirmacio)
        {
            Boolean conf;
            if (contrasena == confirmacio)
            {
                conf = true;
            }
            else
            {
                conf = false;
            }
            return conf;
        }

        public string Genero()
        {
            string genero = "";

            if (radioButtonNB.Checked)
            {
                genero = radioButtonNB.Text;
            }
            else if (radioButtonOtro.Checked)
            {
                genero = radioButtonOtro.Text;
            }
            else if(BtnSexoHombre.Checked)
            {
                genero = BtnSexoHombre.Text;
            }
            else
            {
                genero = BtnSexoMujer.Text;
            }

            return genero;
        }
        public Boolean UsuarioExiste(String nombreExistente)
        {
            Boolean existe = false;
            int i = 0;
           
            do
            {
                if (nombreExistente == usuariosJSON[i].user)
                {
                    existe = true;
                }
                i++;
            }
            while (i < usuariosJSON.Count);
            return existe;
        }
        public Boolean DatosRellenos(String nomUs, String nomReg, Boolean botonHombre, Boolean botonMujer)
        {
            Boolean puesto; 

            if (nomReg != "" && nomReg != null && nomUs != "" && nomUs != null && (botonHombre == true || botonMujer == true || radioButtonNB.Checked == true || radioButtonOtro.Checked == true ))
            {
                puesto = true;
            }
            else
            {
                puesto = false;
            }
            return puesto;
        }

        //Muestra Panel inicio de sesión
        private void labelAInicioSesion_Click(object sender, EventArgs e)
        {
            groupBoxRegistrar.Visible = false;
            groupBoxContrasenaOlvidada.Visible = false;
            groupBoxIniciarSesion.Visible = true;
            textBoxNomUs.Text = "";
            textBoxContraseña.Text = "";
        }

        //Muestra panel de reguistro
        private void labelInicioSesionARegistro_Click(object sender, EventArgs e)
        {
            groupBoxRegistrar.Visible = true;
            groupBoxContrasenaOlvidada.Visible = false;
            groupBoxIniciarSesion.Visible = false;
            dateTimePicker1.Value = DateTime.Now;
            textBoxNomRegistre.Text = "";
            textBoxUserName.Text = "";
            textBoxContraseñaRegistro.Text = "";
            textBoxConfirmarContraseñaRegistro.Text = "";
            BtnSexoHombre.Checked = false;
            BtnSexoMujer.Checked = false;
            radioButtonNB.Checked = false;
            radioButtonOtro.Checked = false;
        }

        //Muestra panel de contraseña olvidada si el usuario existo y NO es superadmin
        private void labelContrasenOlvidada_Click(object sender, EventArgs e)
        {
            if(textBoxNomUs.Text != "" && textBoxNomUs.Text != "superadmin")
            {
                if(UsuarioExiste(textBoxNomUs.Text))
                {
                    groupBoxIniciarSesion.Visible = false;
                    groupBoxRegistrar.Visible = false;
                    groupBoxContrasenaOlvidada.Visible = true;
                    textBoxCambioContrasena.Text = "";
                    textBoxConfirmarCambioContrasena.Text = "";

                    labelUsuarioACambiar.Text = textBoxNomUs.Text;
                }
                else
                {
                    MessageBox.Show("Este usuario no existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBoxNomUs.Text != "superadmin")
            {
                MessageBox.Show("No se puede cambiar la contraseña del usuario superadmin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se ha indicado el usuario", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Modifica contraeña
        private void buttonConfrimrarCambioContrasena_Click(object sender, EventArgs e)
        {
            if(textBoxCambioContrasena.Text != "" && textBoxConfirmarCambioContrasena.Text != "")
            {
                if(textBoxCambioContrasena.Text == textBoxConfirmarCambioContrasena.Text)
                {
                    for (int i = 0; i < usuariosJSON.Count; i++)
                    {
                        if (textBoxNomUs.Text == usuariosJSON[i].user)
                        {
                            usuariosJSON[i].passwd = EncriptarContrasena(textBoxCambioContrasena.Text);
                            usuariosJSON[i].ultimocambiopasswd = DateTime.Now.ToString();
                            ManageJsonUsers.Escribir(usuariosJSON);
                            
                            groupBoxRegistrar.Visible = false;
                            groupBoxContrasenaOlvidada.Visible = false;
                            groupBoxIniciarSesion.Visible = true;
                            textBoxContraseña.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La confirmación no coincide con la contraseña", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Se tienen que rellenar todos los campos", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Permitehacer login con ENTER en contraseña
        private void textBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 buttonAcceder.PerformClick();
            }
        }

        private void VisualReset()
        {
            usuariosJSON = ManageJsonUsers.Leer();
            groupBoxRegistrar.Visible = false;
            groupBoxIniciarSesion.Visible = true;
            this.MaximizeBox = false;
            textBoxNomUs.Text = "";
            textBoxContraseña.Text = "";
        }
    }
}