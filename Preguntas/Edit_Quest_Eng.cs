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
    public partial class Edit_Quest_Eng : Form
    {
        public String miDificultad;
        public String miCategoria;
        public Pregunta miPreguntaCat = new Pregunta();
        public Pregunta miPreguntaCast = new Pregunta();
        public Pregunta preguntaAEditarEng = new Pregunta();
        BindingList<Pregunta> preguntasEng = new BindingList<Pregunta>();
        BindingList<Pregunta> preguntasCat = new BindingList<Pregunta>();
        BindingList<Pregunta> preguntasCast = new BindingList<Pregunta>();
        DirectoryInfo dirPictures;
        public String ruta = @"..\..\Resources\ImagenesPreguntas\";


        public Edit_Quest_Eng(String dificultad, String categoria, Pregunta preguntaCat, Pregunta preguntaCast)
        {
            miDificultad = dificultad;
            miCategoria = categoria;
            miPreguntaCat = preguntaCat;
            miPreguntaCast = preguntaCast;
            InitializeComponent();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(gestion_Preguntas);
            gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            gestion_Preguntas.Show();

            //Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panel1.BringToFront();
            //this.panel1.Controls.Add(gestion_Preguntas);
            //gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            //gestion_Preguntas.Show();
        }

        private void Edit_Quest_Eng_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.panel1.SendToBack();
            preguntasEng = ManageJsonQuestions.LeerJson(miDificultad, "eng");
            foreach (Pregunta preguntaEng in preguntasEng)
            {
                if (preguntaEng.id == miPreguntaCat.id)
                {
                    preguntaAEditarEng = preguntaEng;
                }
            }

            dirPictures = new DirectoryInfo(ruta);
            cargarComboBox();
            rellenarTextos();

            switch (miDificultad)
            {
                case "Alta":
                    //nombreJson = "alta_cat.json";
                    inhabilitarTextBoxes(4);
                    //comboBoxCategoria.Enabled = true;
                    break;
                case "Media":
                    //nombreJson = "media_cat.json";
                    inhabilitarTextBoxes(3);
                    //comboBoxCategoria.Enabled = true;
                    break;
                case "Baja":
                    //nombreJson = "baja_cat.json";
                    inhabilitarTextBoxes(2);
                    //comboBoxCategoria.Enabled = true;
                    break;
                case "Infantil":
                    //nombreJson = "infantil_cat.json";
                    inhabilitarTextBoxes(3);
                    //comboBoxCategoria.Text = null;
                    //comboBoxCategoria.Enabled = false;
                    break;
            }
        }

        private void rellenarTextos()
        {
            textBoxPregunta.Text = preguntaAEditarEng.pregunta.ToString();
            comboBoxImagen.Text = miPreguntaCast.imagen.ToString();
            comboBoxImagen.Enabled = false;
            textBoxRespuesta1.Text = preguntaAEditarEng.r1.ToString();
            textBoxRespuesta2.Text = preguntaAEditarEng.r2.ToString();
            textBoxRespuesta3.Text = preguntaAEditarEng.r3.ToString();
            textBoxRespuestaCorrecta.Text = preguntaAEditarEng.rcorrecta.ToString();
            comboBoxCategoria.Text = miPreguntaCast.categoria.ToString();
            comboBoxCategoria.Enabled = false;
            comboBoxDificultad.Text = miDificultad;
            pictureBoxImagenPregunta.Load(ruta + comboBoxImagen.Text);
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (erroresCamposVacios() == false)
            {
                preguntaAEditarEng.imagen = comboBoxImagen.Text;
                preguntaAEditarEng.pregunta = textBoxPregunta.Text;
                preguntaAEditarEng.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaAEditarEng.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaAEditarEng.categoria = comboBoxCategoria.Text;
                        preguntaAEditarEng.r3 = "";
                        preguntaAEditarEng.r2 = "";
                        break;
                    case "Media":
                        preguntaAEditarEng.categoria = comboBoxCategoria.Text;
                        preguntaAEditarEng.r3 = "";
                        preguntaAEditarEng.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaAEditarEng.categoria = comboBoxCategoria.Text;
                        preguntaAEditarEng.r3 = textBoxRespuesta3.Text;
                        preguntaAEditarEng.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaAEditarEng.categoria = "INFANTIL";
                        preguntaAEditarEng.r3 = "";
                        preguntaAEditarEng.r2 = textBoxRespuesta2.Text;
                        break;
                }


                guardarPreguntas();

                Panel panel = (Panel)this.Parent;
                Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(gestion_Preguntas);
                gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
                gestion_Preguntas.Show();

                //Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas (comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                //this.panel1.BringToFront();
                //this.panel1.Controls.Add(gestion_Preguntas);
                //gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
                //gestion_Preguntas.Show();
            }



        }

        private void guardarPreguntas()
        {
            preguntasCat = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "cat");
            preguntasCast = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "cast");
            preguntasEng = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "eng");

            preguntasCat[miPreguntaCat.id - 1] = miPreguntaCat;
            preguntasCast[miPreguntaCast.id - 1] = miPreguntaCast;
            preguntasEng[preguntaAEditarEng.id - 1] = preguntaAEditarEng;

            ManageJsonQuestions.EscribirJson(preguntasCat, miDificultad.ToLower(), "cat");
            ManageJsonQuestions.EscribirJson(preguntasCast, miDificultad.ToLower(), "cast");
            ManageJsonQuestions.EscribirJson(preguntasEng, miDificultad.ToLower(), "eng");


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

