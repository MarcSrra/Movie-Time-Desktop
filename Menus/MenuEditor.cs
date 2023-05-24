using ProyectoCapraboEscritorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace DesktopWireframe
{
    public partial class MenuEditor : Form
    {
        Icon icon = Icon.ExtractAssociatedIcon(@"..\..\Resources\logocirculoancho.ico");

        public MenuEditor()
        {
            InitializeComponent();
        }

        private void MenuEditor_Load(object sender, EventArgs e)
        {
            this.Icon = icon;
            this.MaximizeBox = false;
        }

        //Botón cerrar sesión
        private void ToolStripMenuItemCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que deseas cerrar sesión?",
                            "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Espera confirmación y devuelve a la pantalla de inicio de sesión
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /*
        La pantalla de menú èstá siempre presente, todos los forms se mostrarán en un panel situado
        de la barra del menú
        */

        //Carga la pantalla de crear nueva pregunta en el panel
        private void ToolStripMenuItemAnadirPregunta_Click(object sender, EventArgs e)
        {
            New_Quest_Cat preguntas = new New_Quest_Cat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(preguntas);
            preguntas.FormBorderStyle = FormBorderStyle.None;
            preguntas.Show();
        }

        //Carga la pantalla de gestionar preguntas en el panel
        private void ToolStripMenuItemGestionPreguntas_Click(object sender, EventArgs e)
        {
            Gestion_Preguntas preguntas = new Gestion_Preguntas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(preguntas);
            preguntas.FormBorderStyle = FormBorderStyle.None;
            preguntas.Show();
        }

        //Carga la pantalla de gestionar usuarios en el panel
        private void ToolStripMenuItemUsuarios_Click(object sender, EventArgs e)
        {
            EditarUsuariosEditor usuarios = new EditarUsuariosEditor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(usuarios);
            usuarios.FormBorderStyle = FormBorderStyle.None;
            usuarios.Show();
        }

        //Carga la pantalla de crear nueva pregunta en el panel
        private void ToolStripMenuItemRanking_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(ranking);
            ranking.FormBorderStyle = FormBorderStyle.None;
            ranking.Show();
        }

        //Carga la pantalla de gestionar preguntas de final de partida en el panel
        private void ToolStripMenuItemImagenesResultado_Click(object sender, EventArgs e)
        {
            Imagenes_quiz imagenes = new Imagenes_quiz() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelForm.Controls.Clear();
            this.panelForm.Controls.Add(imagenes);
            imagenes.FormBorderStyle = FormBorderStyle.None;
            imagenes.Show();
        }
    }
}
