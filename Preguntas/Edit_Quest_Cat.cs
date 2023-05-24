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
    public partial class Edit_Quest_Cat : Form
    {
        public Pregunta preguntaAEditarCat = new Pregunta();
        public String miDificultad;
        public String ruta = @"..\..\Resources\ImagenesPreguntas\";
        DirectoryInfo dirPictures;

        public Edit_Quest_Cat(String dificultad, Pregunta preguntaRecibidaCat)
        {
            miDificultad = dificultad;
            preguntaAEditarCat = preguntaRecibidaCat;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolverTabla_Click(object sender, EventArgs e)
        {
            Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.BringToFront();
            this.panelForm.Controls.Add(gestion_Preguntas);
            gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            gestion_Preguntas.Show();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (erroresCamposVacios() == false)
            {
                preguntaAEditarCat.imagen = comboBoxImagen.Text;
                preguntaAEditarCat.pregunta = textBoxPregunta.Text;
                preguntaAEditarCat.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaAEditarCat.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaAEditarCat.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCat.r3 = "";
                        preguntaAEditarCat.r2 = "";
                        break;
                    case "Media":
                        preguntaAEditarCat.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCat.r3 = "";
                        preguntaAEditarCat.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaAEditarCat.categoria = comboBoxCategoria.Text;
                        preguntaAEditarCat.r3 = textBoxRespuesta3.Text;
                        preguntaAEditarCat.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaAEditarCat.categoria = "INFANTIL";
                        preguntaAEditarCat.r3 = "";
                        preguntaAEditarCat.r2 = textBoxRespuesta2.Text;
                        break;
                }
                Panel panel = (Panel)this.Parent;
                Edit_Quest_Cast questCast = new Edit_Quest_Cast(comboBoxDificultad.Text, comboBoxCategoria.Text, preguntaAEditarCat) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(questCast);
                questCast.FormBorderStyle = FormBorderStyle.None;
                questCast.Show();
            }
        }


        

        private void Edit_Quest_Cat_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            panelForm.SendToBack();
            dirPictures = new DirectoryInfo(ruta);
            cargarComboBox();

            textBoxPregunta.Text = preguntaAEditarCat.pregunta.ToString();
            comboBoxImagen.Text = preguntaAEditarCat.imagen.ToString();
            textBoxRespuesta1.Text = preguntaAEditarCat.r1.ToString();
            textBoxRespuesta2.Text = preguntaAEditarCat.r2.ToString();
            textBoxRespuesta3.Text = preguntaAEditarCat.r3.ToString();
            textBoxRespuestaCorrecta.Text = preguntaAEditarCat.rcorrecta.ToString();
            comboBoxCategoria.Text = preguntaAEditarCat.categoria.ToString();
            comboBoxDificultad.Text = miDificultad;
            if (comboBoxDificultad.Text.Equals ("Infantil"))
            {
                comboBoxCategoria.Enabled = false;
            }

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


        private void cargarComboBox ()
        {
            comboBoxImagen.Items.Clear();

            foreach(FileInfo filename in dirPictures.GetFiles())
            {
                comboBoxImagen.Items.Add(filename.Name);
            }
        }

        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxImagenPregunta.Load(ruta + comboBoxImagen.Text);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(gestion_Preguntas);
            gestion_Preguntas.FormBorderStyle= FormBorderStyle.None;
            gestion_Preguntas.Show();
        }
    }
}
