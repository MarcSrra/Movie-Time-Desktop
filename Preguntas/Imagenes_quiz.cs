using DesktopWireframe.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DesktopWireframe
{
    public partial class Imagenes_quiz : Form
    {  
        public String dificultad;
        public String ruta = @"..\..\Resources\ImagenesResultado\";
        DirectoryInfo directoryimagenes;


        public Imagenes_quiz()
        {
            InitializeComponent();
        }

        private void Imagenes_quiz_Load(object sender, EventArgs e)
        {
            directoryimagenes = new DirectoryInfo(ruta);
        }

        //Carga los JSON de imagenes de resultado y los textos de la dificultad seleccionada y rellena los datos
        private void comboBoxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombobox();

            switch (comboBoxDificultad.Text.ToString())
            {
                case "Alta":
                    dificultad = "alta";
                    break;
                case "Media":
                    dificultad = "media";
                    break;
                case "Baja":
                    dificultad = "baja";
                    break;
                case "Infantil":
                    dificultad = "infantil";
                    break;
            }

            CargarJSON(dificultad);
        }

        //Se cambia la imagen de la PictureBox al cambiar el item de la ComboBox
        private void comboBox025_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox025.Load(ruta + comboBox025.Text);
        }
        private void comboBox2550_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2550.Load(ruta + comboBox2550.Text);
        }
        private void comboBox5075_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox5075.Load(ruta + comboBox5075.Text);
        }
        private void comboBox75100_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox75100.Load(ruta + comboBox75100.Text);
        }

        //Guarda los cambios realizados para esa dificultad
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Comprueba que no se intente guardar sin antes seleccionar un documento
            if (comboBoxDificultad.Text != "")
            {
                BindingList<Imagenes> listaImagenes = ManageJsonImagenes.LeerJson(dificultad);

                //Comprueba que todos los campos estén rellenados correctamente
                if (!ErroresGuardar())
                {
                    Imagenes imagen025 = new Imagenes(1, 25, comboBox025.Text, textBox025cast.Text, textBox025cat.Text, textBox025eng.Text);
                    Imagenes imagen2550 = new Imagenes(2, 50, comboBox2550.Text, textBox2550cast.Text, textBox2550cat.Text, textBox2550eng.Text);
                    Imagenes imagen5075 = new Imagenes(3, 75, comboBox5075.Text, textBox5075cast.Text, textBox5075cat.Text, textBox5075eng.Text);
                    Imagenes imagen75100 = new Imagenes(4, 100, comboBox75100.Text, textBox75100cast.Text, textBox75100cat.Text, textBox75100eng.Text);

                    listaImagenes[0] = imagen025;
                    listaImagenes[1] = imagen2550;
                    listaImagenes[2] = imagen5075;
                    listaImagenes[3] = imagen75100;

                    ManageJsonImagenes.EscribirJson(listaImagenes, comboBoxDificultad.Text);
                    MessageBox.Show("Imágenes actualizadas", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna dificultad", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Se le pasa la dificultad y se rellenan todos los campos con los datos
        private void CargarJSON(String dificultad)
        {
            BindingList<Imagenes> listaImagenes = ManageJsonImagenes.LeerJson(dificultad);

            foreach(Imagenes imagen in listaImagenes)
            {
                //Rango de acierto 0 % / 25 %
                if(imagen.acierto <= 25)
                {
                    textBox025cast.Text = imagen.textocast;
                    textBox025cat.Text = imagen.textocat;
                    textBox025eng.Text = imagen.textoeng;

                    for (int i = 0; i < comboBox025.Items.Count; i++)
                    {
                        if (imagen.imagen.Equals(comboBox025.Items[i]))
                        {
                            comboBox025.SelectedIndex = comboBox025.FindStringExact(imagen.imagen);
                        }
                    }

                    pictureBox025.Load(ruta + comboBox025.Text);
                }
                //Rango de acierto 25 % / 50 %
                else if (imagen.acierto <= 50)
                {
                    textBox2550cast.Text = imagen.textocast;
                    textBox2550cat.Text = imagen.textocat;
                    textBox2550eng.Text = imagen.textoeng;

                    for (int i = 0; i < comboBox2550.Items.Count; i++)
                    {
                        if (imagen.imagen.Equals(comboBox2550.Items[i]))
                        {
                            comboBox2550.SelectedIndex = comboBox2550.FindStringExact(imagen.imagen);
                        }
                    }

                    pictureBox2550.Load(ruta + comboBox2550.Text);
                }
                //Rango de acierto 50 % / 75 %
                else if (imagen.acierto <= 75)
                {
                    textBox5075cast.Text = imagen.textocast;
                    textBox5075cat.Text = imagen.textocat;
                    textBox5075eng.Text = imagen.textoeng;

                    for (int i = 0; i < comboBox5075.Items.Count; i++)
                    {
                        if (imagen.imagen.Equals(comboBox5075.Items[i]))
                        {
                            comboBox5075.SelectedIndex = comboBox5075.FindStringExact(imagen.imagen);
                        }
                    }

                    pictureBox5075.Load(ruta + comboBox5075.Text);
                }
                //Rango de acierto 75 % / 100 %
                else if (imagen.acierto <= 100)
                {
                    textBox75100cast.Text = imagen.textocast;
                    textBox75100cat.Text = imagen.textocat;
                    textBox75100eng.Text = imagen.textoeng;

                    for (int i = 0; i < comboBox75100.Items.Count; i++)
                    {
                        if (imagen.imagen.Equals(comboBox75100.Items[i]))
                        {
                            comboBox75100.SelectedIndex = comboBox75100.FindStringExact(imagen.imagen);
                        }
                    }

                    pictureBox75100.Load(ruta + comboBox75100.Text);
                }
            }
        }

        //Lee la carpeta con las imagenes de final de partida y las carga en el combobox
        private void CargarCombobox()
        {
            comboBox025.Items.Clear();
            comboBox2550.Items.Clear();
            comboBox5075.Items.Clear();
            comboBox75100.Items.Clear();

            foreach (FileInfo fitx in directoryimagenes.GetFiles())
            {
                comboBox025.Items.Add(fitx.Name);
                comboBox2550.Items.Add(fitx.Name);
                comboBox5075.Items.Add(fitx.Name);
                comboBox75100.Items.Add(fitx.Name);
            }
        }  

        //Comprueba todos los campos e informa sobre si alguno se tiene que modificar
        private Boolean ErroresGuardar()
        {
            Boolean error = false;
            String mensaje = "Rellena los siguientes campos para poder guardar los cambios: \n";

            if(textBox025cast.Text == "")
            {
                mensaje += "\n * Texto Castellano (0 % / 25 %)";
                error = true;
            }
            if (textBox025cat.Text == "")
            {
                mensaje += "\n * Texto Catalàn (0 % / 25 %)";
                error = true;
            }
            if (textBox025eng.Text == "")
            {
                mensaje += "\n * Texto Inglés (0 % / 25 %)";
                error = true;
            }
            if (textBox2550cast.Text == "")
            {
                mensaje += "\n * Texto Castellano (25 % / 50 %)";
                error = true;
            }
            if (textBox2550cat.Text == "")
            {
                mensaje += "\n * Texto Catalàn (25 % / 50 %)";
                error = true;
            }
            if (textBox2550eng.Text == "")
            {
                mensaje += "\n * Texto Inglés (25 % / 50 %)";
                error = true;
            }
            if (textBox5075cast.Text == "")
            {
                mensaje += "\n * Texto Castellano (50 % / 75 %)";
                error = true;
            }
            if (textBox5075cat.Text == "")
            {
                mensaje += "\n * Texto Catalàn (50 % / 75 %)";
                error = true;
            }
            if (textBox5075eng.Text == "")
            {
                mensaje += "\n * Texto Inglés (50 % / 75 %)";
                error = true;
            }
            if (textBox75100cast.Text == "")
            {
                mensaje += "\n * Texto Castellano (75 % / 100 %)";
                error = true;
            }
            if (textBox75100cat.Text == "")
            {
                mensaje += "\n * Texto Catalàn (75 % / 100 %)";
                error = true;
            }
            if (textBox75100eng.Text == "")
            {
                mensaje += "\n * Texto Inglés (75 % / 100 %)";
                error = true;
            }

            if(error)
            {
                MessageBox.Show(mensaje, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return error;
        }


    }
}
