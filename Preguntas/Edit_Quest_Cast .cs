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
    public partial class Edit_Quest_Cast : Form
    {
        public String miDificultad;
        public String miCategoria;
        public Pregunta miPreguntaCat = new Pregunta();
        public Pregunta preguntaAEditarCast = new Pregunta();
        public BindingList<Pregunta> preguntasCast = new BindingList<Pregunta>();
        DirectoryInfo dirPictures;
        public String ruta = @"..\..\Resources\ImagenesPreguntas\";


        public Edit_Quest_Cast(String dificultad, String categoria, Pregunta preguntaCat)
        {
            miDificultad = dificultad;
            miCategoria = categoria;
            miPreguntaCat = preguntaCat;
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

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (erroresCamposVacios() == false)
            {
                preguntaAEditarCast.imagen = comboBoxImagen.Text;
                preguntaAEditarCast.pregunta = textBoxPregunta.Text;
                preguntaAEditarCast.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaAEditarCast.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaAEditarCast.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCast.r3 = "";
                        preguntaAEditarCast.r2 = "";
                        break;
                    case "Media":
                        preguntaAEditarCast.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCast.r3 = "";
                        preguntaAEditarCast.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaAEditarCast.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCast.r3 = textBoxRespuesta3.Text;
                        preguntaAEditarCast.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaAEditarCast.categoria = "INFANTIL";
                        preguntaAEditarCast.r3 = "";
                        preguntaAEditarCast.r2 = textBoxRespuesta2.Text;
                        break;
                }

                Panel panel = (Panel)this.Parent;
                Edit_Quest_Eng questEng = new Edit_Quest_Eng(comboBoxDificultad.Text, comboBoxCategoria.Text, miPreguntaCat, preguntaAEditarCast) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(questEng);
                questEng.FormBorderStyle = FormBorderStyle.None;
                questEng.Show();
            }

            

        }
        

        private void Edit_Quest_Cast_Load(object sender, EventArgs e)
        {
            panel1.SendToBack();
            this.MaximizeBox = false;
            preguntasCast = ManageJsonQuestions.LeerJson(miDificultad, "cast");
            foreach (Pregunta preguntaCast in preguntasCast)
            {
                if (preguntaCast.id == miPreguntaCat.id)
                {
                    preguntaAEditarCast = preguntaCast;
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
            textBoxPregunta.Text = preguntaAEditarCast.pregunta.ToString();
            comboBoxImagen.Text = miPreguntaCat.imagen.ToString();
            comboBoxImagen.Enabled = false;
            textBoxRespuesta1.Text = preguntaAEditarCast.r1.ToString();
            textBoxRespuesta2.Text = preguntaAEditarCast.r2.ToString();
            textBoxRespuesta3.Text = preguntaAEditarCast.r3.ToString();
            textBoxRespuestaCorrecta.Text = preguntaAEditarCast.rcorrecta.ToString();
            comboBoxCategoria.Text = miPreguntaCat.categoria.ToString();
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

        private void panelDesign_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
