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
using DesktopWireframe.JSON;

namespace DesktopWireframe
{

    public partial class New_Quest_Cast : Form
    {
        public String nombreJson;
        public String miDificultad;
        public Pregunta miPreguntaCat = new Pregunta();
        public String miCategoria;
        public Pregunta preguntaCast = new Pregunta();

        public String ruta = @"..\..\Resources\ImagenesPreguntas\";
        DirectoryInfo dirPictures;
        public New_Quest_Cast(String dificultad, String categoria, Pregunta preguntaCat)
        {
            miDificultad = dificultad;
            miCategoria = categoria;
            miPreguntaCat = preguntaCat;
            InitializeComponent();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (erroresCamposVacios() == false)
            {
                preguntaCast.imagen = comboBoxImagen.Text;
                preguntaCast.pregunta = textBoxPregunta.Text;
                preguntaCast.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaCast.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaCast.categoria = comboBoxCategoria.Text;
                        preguntaCast.r3 = "";
                        preguntaCast.r2 = "";
                        break;
                    case "Media":
                        preguntaCast.categoria = comboBoxCategoria.Text;
                        preguntaCast.r3 = "";
                        preguntaCast.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaCast.categoria = comboBoxCategoria.Text;
                        preguntaCast.r3 = textBoxRespuesta3.Text;
                        preguntaCast.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaCast.categoria = "INFANTIL";
                        preguntaCast.r3 = "";
                        preguntaCast.r2 = textBoxRespuesta2.Text;
                        break;
                }

                preguntaCast.id = ManageJsonQuestions.LeerJson(comboBoxDificultad.Text.ToLower(), "cast").Count + 1;

                Panel panel = (Panel)this.Parent;
                New_Quest_Eng questEng = new New_Quest_Eng(miDificultad, miCategoria, miPreguntaCat, preguntaCast) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(questEng);
                questEng.FormBorderStyle = FormBorderStyle.None;
                questEng.Show();

            }

            

            

        }
        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(gestion_Preguntas);
            gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            gestion_Preguntas.Show();

            //Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panel1.BringToFront();
            //this.panel1.Controls.Add(gestion_Preguntas);
            //gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            //gestion_Preguntas.Show();
        }

        private void New_Quest_Cast_Load(object sender, EventArgs e)
        {
            panel1.SendToBack();
            this.MaximizeBox = false;
            dirPictures = new DirectoryInfo(ruta);
            cargarComboBox();
            comboBoxCategoria.Text = miCategoria;
            comboBoxDificultad.Text = miDificultad;
            rellenarTextos();
            switch (miDificultad)
            {
                case "Alta":
                    //nombreJson = "alta_cast.json";
                    inhabilitarTextBoxes(4);
                    break;
                case "Media":
                    //nombreJson = "media_cast.json";
                    inhabilitarTextBoxes(3);
                    break;
                case "Baja":
                    //nombreJson = "baja_cast.json";
                    inhabilitarTextBoxes(2);
                    break;
                case "Infantil":
                    //nombreJson = "infantil_cast.json";
                    inhabilitarTextBoxes(3);
                    break;
            }
        }

        private void comboBoxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rellenarTextos()
        {
            comboBoxImagen.Text = miPreguntaCat.imagen.ToString();
            comboBoxImagen.Enabled = false;
            textBoxPregunta.Text = miPreguntaCat.pregunta.ToString();
            textBoxRespuesta1.Text = miPreguntaCat.r1.ToString();
            textBoxRespuesta2.Text = miPreguntaCat.r2.ToString();
            textBoxRespuesta3.Text = miPreguntaCat.r3.ToString();
            textBoxRespuestaCorrecta.Text = miPreguntaCat.rcorrecta.ToString();
        }

        private void inhabilitarTextBoxes(int cantidadRespuestas)
        {
            switch (cantidadRespuestas)
            {
                case 2:
                    textBoxRespuesta1.Enabled = true;
                    textBoxRespuesta2.Enabled = false;
                    textBoxRespuesta2.Clear();
                    textBoxRespuesta3.Enabled = false;
                    textBoxRespuesta3.Clear();
                    break;
                case 3:
                    textBoxRespuesta1.Enabled = true;
                    textBoxRespuesta2.Enabled = true;
                    textBoxRespuesta3.Enabled = false;
                    textBoxRespuesta3.Clear();
                    break;
                case 4:
                    textBoxRespuesta1.Enabled = true;
                    textBoxRespuesta2.Enabled = true;
                    textBoxRespuesta3.Enabled = true;
                    break;
            }
        }


        private Boolean erroresCamposVacios()
        {
            bool camposVacios = false;
            String mensajeError = "Rellena correctamente los siguientes campos para continuar: \n";

            if (comboBoxCategoria.Text.Equals("") && !comboBoxDificultad.Text.Equals("Infantil"))
            {
                mensajeError += "\n * Categoría";
                camposVacios = true;
            }




            if (comboBoxImagen.Text.Equals(""))
            {
                mensajeError += "\n * imagen";
                camposVacios = true;
            }



            if (textBoxPregunta.Text.Equals(""))
            {
                mensajeError += "\n * Pregunta";
                camposVacios = true;
            }



            if (textBoxRespuestaCorrecta.Text.Equals(""))
            {
                mensajeError += "\n * Respuesta correcta";
                camposVacios = true;
            }



            if (textBoxRespuesta1.Text.Equals(""))
            {
                mensajeError += "\n * Respuesta adicional 1";
                camposVacios = true;
            }



            if (textBoxRespuesta2.Text.Equals("") && !comboBoxDificultad.Text.Equals("Baja"))
            {
                mensajeError += "\n * Respuesta adicional 2";
                camposVacios = true;
            }



            if (textBoxRespuesta3.Text.Equals("") && comboBoxDificultad.Text.Equals("Alta"))
            {
                mensajeError += "\n * Respuesta adicional 3";
                camposVacios = true;
            }

            if (comboBoxCategoria.Text.Equals("INFANTIL") && !comboBoxDificultad.Text.Equals("Infantil"))
            {
                mensajeError += "\n * Las preguntas para adultos no pueden ser de categoría 'INFANTIL'";
                camposVacios = true;
            }

            if (camposVacios == true)
            {
                MessageBox.Show(mensajeError, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return camposVacios;
        }

        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxImagenPregunta.Load(ruta + comboBoxImagen.Text);
        }

        private void cargarComboBox()
        {
            comboBoxImagen.Items.Clear();

            foreach (FileInfo filename in dirPictures.GetFiles())
            {
                comboBoxImagen.Items.Add(filename.Name);
            }
        }
    }
}
