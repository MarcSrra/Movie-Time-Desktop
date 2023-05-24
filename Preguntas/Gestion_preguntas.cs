using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopWireframe.JSON;
using DesktopWireframe.Preguntas;
using WindowsFormsApp2;

namespace DesktopWireframe
{
    public partial class Gestion_Preguntas : Form
    {
        public Pregunta preguntaSeleccionada = new Pregunta();
        public String dificultad, idioma = "cat";
        public BindingList<Pregunta> preguntasCat = new BindingList<Pregunta>();
        public BindingList<Pregunta> preguntasCast = new BindingList<Pregunta>();
        public BindingList<Pregunta> preguntasEng = new BindingList<Pregunta>();


        public Gestion_Preguntas()
        {
            InitializeComponent();
        }

        public Gestion_Preguntas(String dificultad)
        {
            InitializeComponent();
            comboBoxDificultad.Text = dificultad;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //compruebo si hay alguna pregunta seleccionada para proceder a guardar
            if (dataGridViewPreguntas.SelectedRows.Count > 0)
            {
                
                //me guardo el valor de la fila actual y voy guardando los valores de cada celda en su
                //correspondiente campo de la pregunta que he creado para guardar los valores de la
                //pregunta que he escogido para editar
                int filaActual = dataGridViewPreguntas.CurrentRow.Index;
                preguntaSeleccionada.id = (int) dataGridViewPreguntas.Rows[filaActual].Cells[0].Value;
                preguntaSeleccionada.pregunta = dataGridViewPreguntas.Rows[filaActual].Cells[1].Value.ToString();
                preguntaSeleccionada.categoria = dataGridViewPreguntas.Rows[filaActual].Cells[2].Value.ToString();
                preguntaSeleccionada.rcorrecta = dataGridViewPreguntas.Rows[filaActual].Cells[3].Value.ToString();
                preguntaSeleccionada.r1 = dataGridViewPreguntas.Rows[filaActual].Cells[4].Value.ToString();
                preguntaSeleccionada.r2 = dataGridViewPreguntas.Rows[filaActual].Cells[5].Value.ToString();
                preguntaSeleccionada.r3 = dataGridViewPreguntas.Rows[filaActual].Cells[6].Value.ToString();
                preguntaSeleccionada.imagen = dataGridViewPreguntas.Rows[filaActual].Cells[7].Value.ToString();



                //aquí paso a la primera pantalla de edición pasándole como parámetros la dificultad y la pregunta
                //que quiero seleccionar para operar con ellos más adelante
                Panel panel = (Panel)this.Parent;
                Edit_Quest_Cat questCat = new Edit_Quest_Cat(comboBoxDificultad.Text, preguntaSeleccionada) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                panel.Controls.Clear();
                panel.Controls.Add(questCat);
                questCat.FormBorderStyle = FormBorderStyle.None;
                questCat.Show();

            }
            else
            {
                MessageBox.Show("Error. Ninguna pregunta seleccionada", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comboBoxDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //en este switch guardo el valor de la dificultad escogida cada vez que cambia
            switch (comboBoxDificultad.Text)
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

            //aquí recurro a ese valor que acabo de guardar para usarlo de parámetro cuando lea el json
            //en cuestión y actualizo la tabla cada vez que cambia
            dataGridViewPreguntas.DataSource = null;
            BindingList<Pregunta> listaPreguntas = ManageJsonQuestions.LeerJson(dificultad, idioma);
            listaPreguntas.OrderBy(x => x.id).ToList();
            dataGridViewPreguntas.DataSource = listaPreguntas;
           
        }

        private void Gestion_Preguntas_Load(object sender, EventArgs e)
        {
            this.panelForm.SendToBack();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Opciones_preguntas opciones = new Opciones_preguntas();
            opciones.Show();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {


            //con esta línea compruebo que haya alguna fila (pregunta) seleccionada para saber qué borrar
            if (dataGridViewPreguntas.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que deseas eliminar la pregunta " +
                            dataGridViewPreguntas.Rows[this.dataGridViewPreguntas.CurrentRow.Index].Cells[0].Value + "?",
                            "Eliminar Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    //aquí guardo el valor de la fila seleccionada en un int y leo los 3 json en lists
                    int filaActual = dataGridViewPreguntas.CurrentRow.Index;
                    preguntasCat = ManageJsonQuestions.LeerJson(dificultad, "cat");
                    preguntasCast = ManageJsonQuestions.LeerJson(dificultad, "cast");
                    preguntasEng = ManageJsonQuestions.LeerJson(dificultad, "eng");

                    //aquí me guardo el ID de la pregunta seleccionada y después la borro de las 3 listas
                    int idPregunta = preguntasCat[filaActual].id;
                    preguntasCat.Remove(preguntasCat[filaActual]);
                    preguntasCast.Remove(preguntasCast[filaActual]);
                    preguntasEng.Remove(preguntasEng[filaActual]);

                    //aquí me guardo la cantidad de preguntas que quedan después de haber borrado una
                    int finalList = preguntasCat.ToList().Count;

                    //for (int i = idPregunta + 1; i < finalList; i++)
                    //{
                    //    preguntasCat[i].id = i - 1;
                    //    preguntasCast[i].id = i - 1;
                    //    preguntasEng[i].id = i - 1;

                    //}

                    //con este for sobreescribo los ID de todas las preguntas de forma ordenada
                    for (int i = 0; i < finalList; i++)
                    {
                        preguntasCat[i].id = i + 1;
                        preguntasCast[i].id = i + 1;
                        preguntasEng[i].id = i + 1;

                    }

                    //aquí sobreescribo los json con las listas y actualizo la tabla con la pregunta ya borrada
                    ManageJsonQuestions.EscribirJson(preguntasCat, dificultad, "cat");
                    ManageJsonQuestions.EscribirJson(preguntasCast, dificultad, "cast");
                    ManageJsonQuestions.EscribirJson(preguntasEng, dificultad, "eng");

                    dataGridViewPreguntas.DataSource = null;
                    dataGridViewPreguntas.DataSource = preguntasCat;
                }
                


            }
        }
    }
}
