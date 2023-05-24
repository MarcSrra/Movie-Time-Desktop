using DesktopWireframe.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWireframe.Preguntas
{
    public partial class Opciones_preguntas : Form
    {
        int maxPregutnas;

        BindingList<Opciones> opciones;
        BindingList<Pregunta> Infantil;
        BindingList<Pregunta> Baja; 
        BindingList<Pregunta> Media; 
        BindingList<Pregunta> Alta;

        public Opciones_preguntas()
        {
            InitializeComponent();
        }

        private void Opciones_preguntas_Load(object sender, EventArgs e)
        {
            opciones = ManageJsonQuizz.LeerJson();
            Infantil = ManageJsonQuestions.LeerJson("infantil", "cat");
            Baja = ManageJsonQuestions.LeerJson("baja", "cat");
            Media = ManageJsonQuestions.LeerJson("media", "cat");
            Alta = ManageJsonQuestions.LeerJson("alta", "cat");

            maxPregutnas = setmaxpreguntas(Infantil, Baja, Media, Alta);

            numericUpDownPreguntas.Maximum = maxPregutnas;

            numericUpDownPreguntas.Value = opciones[0].preguntas;

            numericUpDownPuntuacionInfantil.Value = opciones[0].puntuacioninfantil;
            numericUpDownPuntuacionBaja.Value = opciones[0].puntuacionbaja;
            numericUpDownPuntuacionMedia.Value = opciones[0].puntuacionmedia;
            numericUpDownPuntuacionAlta.Value = opciones[0].puntuacionalta;

            numericUpDownTiempoInfantil.Value = opciones[0].tiempoinfantil / 1000;
            numericUpDownTiempoBaja.Value = opciones[0].tiempobaja / 1000;
            numericUpDownTiempoMedia.Value = opciones[0].tiempomedia / 1000;
            numericUpDownTiempoAlta.Value = opciones[0].tiempoalta / 1000;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            opciones[0].preguntas = (int)numericUpDownPreguntas.Value;
            
            opciones[0].puntuacioninfantil = (int)numericUpDownPuntuacionInfantil.Value;
            opciones[0].puntuacionbaja = (int)numericUpDownPuntuacionBaja.Value;
            opciones[0].puntuacionmedia = (int)numericUpDownPuntuacionMedia.Value;
            opciones[0].puntuacionalta = (int)numericUpDownPuntuacionAlta.Value;

            opciones[0].tiempoinfantil = (int)numericUpDownTiempoInfantil.Value * 1000;
            opciones[0].tiempobaja = (int)numericUpDownTiempoBaja.Value * 1000;
            opciones[0].tiempomedia = (int)numericUpDownTiempoMedia.Value * 1000;
            opciones[0].tiempoalta = (int)numericUpDownTiempoAlta.Value * 1000;

            ManageJsonQuizz.EscribirJson(opciones);

            this.Close();
        }

        private int setmaxpreguntas(BindingList<Pregunta> infantil, BindingList<Pregunta> baja, BindingList<Pregunta> media, BindingList<Pregunta> alta)
        {
            int maxPregutnas;

            if(infantil.Count < baja.Count && infantil.Count < media.Count && infantil.Count < alta.Count)
            {
                maxPregutnas = infantil.Count;
            }
            else if(baja.Count < infantil.Count && baja.Count < media.Count && baja.Count < alta.Count)
            {
                maxPregutnas = baja.Count;
            }
            else if(media.Count < infantil.Count && media.Count < baja.Count && media.Count < alta.Count)
            {
                maxPregutnas = media.Count;
            }
            else
            {
                maxPregutnas = alta.Count;
            }

            return maxPregutnas;
        }


    }
}
