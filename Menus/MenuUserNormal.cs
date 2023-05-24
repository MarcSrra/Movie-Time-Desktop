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
    public partial class MenuUserNormal : Form
    {
        Icon icon = Icon.ExtractAssociatedIcon(@"..\..\Resources\logocirculoancho.ico");

        public MenuUserNormal()
        {
            InitializeComponent();
        }

        private void MenuUserNormal_Load(object sender, EventArgs e)
        {
            this.Icon = icon;
            this.MaximizeBox = false;
        }

        //Botón de cerrar sesión
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
    }
}
