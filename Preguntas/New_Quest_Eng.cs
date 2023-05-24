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
    public partial class New_Quest_Eng : Form
    {
        public String nombreJson;
        public String miDificultad;
        public String miCategoria;
        public Pregunta miPreguntaCat = new Pregunta();
        public Pregunta miPreguntaCast = new Pregunta();
        public Pregunta preguntaEng = new Pregunta();
        BindingList<Pregunta> preguntasCat = new BindingList<Pregunta>();
        BindingList<Pregunta> preguntasCast = new BindingList<Pregunta>();
        BindingList<Pregunta> preguntasEng = new BindingList<Pregunta>();
        public String ruta = @"..\..\Resources\ImagenesPreguntas\";
        DirectoryInfo dirPictures;

        public New_Quest_Eng(String dificultad, String categoria, Pregunta preguntaCat, Pregunta preguntaCast)
        {
            miPreguntaCast = preguntaCast;
            miPreguntaCat = preguntaCat;

            miCategoria = categoria;
            miDificultad = dificultad;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRespuesta3_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBoxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void New_Quest_Eng_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            panel1.SendToBack();
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

        private void rellenarTextos()
        {
            comboBoxImagen.Text = miPreguntaCast.imagen.ToString();
            comboBoxImagen.Enabled = false;
            textBoxPregunta.Text = miPreguntaCast.pregunta.ToString();
            textBoxRespuesta1.Text = miPreguntaCast.r1.ToString();
            textBoxRespuesta2.Text = miPreguntaCast.r2.ToString();
            textBoxRespuesta3.Text = miPreguntaCast.r3.ToString();
            textBoxRespuestaCorrecta.Text = miPreguntaCast.rcorrecta.ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (erroresCamposVacios() == false)
            {
                preguntaEng.imagen = comboBoxImagen.Text;
                preguntaEng.pregunta = textBoxPregunta.Text;
                preguntaEng.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaEng.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaEng.categoria = comboBoxCategoria.Text;
                        preguntaEng.r3 = "";
                        preguntaEng.r2 = "";
                        break;
                    case "Media":
                        preguntaEng.categoria = comboBoxCategoria.Text;
                        preguntaEng.r3 = "";
                        preguntaEng.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaEng.categoria = comboBoxCategoria.Text;
                        preguntaEng.r3 = textBoxRespuesta3.Text;
                        preguntaEng.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaEng.categoria = "INFANTIL";
                        preguntaEng.r3 = "";
                        preguntaEng.r2 = textBoxRespuesta2.Text;
                        break;
                }

                preguntaEng.id = ManageJsonQuestions.LeerJson(comboBoxDificultad.Text.ToLower(), "eng").Count + 1;
                guardarPreguntas();

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

        }


        private void guardarPreguntas () {
            preguntasCat = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "cat");
            preguntasCast = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "cast");
            preguntasEng = ManageJsonQuestions.LeerJson(miDificultad.ToLower(), "eng");

            preguntasCat.Add(miPreguntaCat);
            preguntasCast.Add(miPreguntaCast);
            preguntasEng.Add(preguntaEng);

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

        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxImagenPregunta.Load(ruta + comboBoxImagen.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

