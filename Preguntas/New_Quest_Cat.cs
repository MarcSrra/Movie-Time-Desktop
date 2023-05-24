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
    public partial class New_Quest_Cat : Form
    {
        public String nombreJson;
        public Pregunta preguntaCat = new Pregunta();
        public String ruta = @"..\..\Resources\ImagenesPreguntas\";
        DirectoryInfo dirPictures;
        public New_Quest_Cat()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRespuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas(comboBoxDificultad.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel.Controls.Clear();
            panel.Controls.Add(gestion_Preguntas);
            gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            gestion_Preguntas.Show();

            //Gestion_Preguntas gestion_Preguntas = new Gestion_Preguntas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panelForm.BringToFront();
            //this.panelForm.Controls.Add(gestion_Preguntas);
            //gestion_Preguntas.FormBorderStyle = FormBorderStyle.None;
            //gestion_Preguntas.Show();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {

            if (erroresCamposVacios() == false)
            {
                preguntaCat.imagen = comboBoxImagen.Text;
                preguntaCat.pregunta = textBoxPregunta.Text;
                preguntaCat.rcorrecta = textBoxRespuestaCorrecta.Text;
                preguntaCat.r1 = textBoxRespuesta1.Text;

                switch (comboBoxDificultad.Text)
                {
                    case "Baja":
                        preguntaCat.categoria = comboBoxCategoria.Text;
                        preguntaCat.r3 = "";
                        preguntaCat.r2 = "";
                        break;
                    case "Media":
                        preguntaCat.categoria = comboBoxCategoria.Text;
                        preguntaCat.r3 = "";
                        preguntaCat.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Alta":
                        preguntaCat.categoria = comboBoxCategoria.Text;
                        preguntaCat.r3 = textBoxRespuesta3.Text;
                        preguntaCat.r2 = textBoxRespuesta2.Text;
                        break;
                    case "Infantil":
                        preguntaCat.categoria = "INFANTIL";
                        preguntaCat.r3 = "";
                        preguntaCat.r2 = textBoxRespuesta2.Text;
                        break;
                }

                preguntaCat.id = ManageJsonQuestions.LeerJson(comboBoxDificultad.Text.ToLower(), "cat").Count + 1;

                Panel panel = (Panel)this.Parent;
                New_Quest_Cast questCast = new New_Quest_Cast(comboBoxDificultad.Text, comboBoxCategoria.Text, preguntaCat) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(questCast);
                questCast.FormBorderStyle = FormBorderStyle.None;
                questCast.Show();

            }

            
        }

        private void comboBoxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDificultad.Text)
            {
                case "Alta":
                    //nombreJson = "alta_cat.json";
                    inhabilitarTextBoxes(4);
                    comboBoxCategoria.Enabled = true;
                    break;
                case "Media":
                    //nombreJson = "media_cat.json";
                    inhabilitarTextBoxes(3);
                    comboBoxCategoria.Enabled = true;
                    break;
                case "Baja":
                    //nombreJson = "baja_cat.json";
                    inhabilitarTextBoxes(2);
                    comboBoxCategoria.Enabled = true;
                    break;
                case "Infantil":
                    //nombreJson = "infantil_cat.json";
                    inhabilitarTextBoxes(3);
                    comboBoxCategoria.Text = "INFANTIL";
                    comboBoxCategoria.Enabled = false;
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

            if (comboBoxDificultad.Text.Equals(""))
            {
                mensajeError += "\n * Dificultad";
                camposVacios = true;
            }

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

        private void New_Quest_Cat_Load(object sender, EventArgs e)
        {
            panelForm.SendToBack();
            this.MaximizeBox = false;
            dirPictures = new DirectoryInfo(ruta);
            cargarComboBox();
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
    }
}
