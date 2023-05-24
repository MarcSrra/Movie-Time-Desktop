using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCapraboEscritorio
{
    public partial class TUSHUEBOS : Form
    {
        String nuevaContraseña;
        String repetirContraseña;
        public TUSHUEBOS()
        {
            InitializeComponent();
        }


        private void buttonEntra_Click(object sender, EventArgs e)
        {
            if (nuevaContraseña.CompareTo(repetirContraseña) == 1)
            {
                MessageBox.Show("La contraseña no coincide", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }
        }

        private void textBoxNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            nuevaContraseña = textBoxNuevaContraseña.Text;
        }

        private void textBoxRepiteContraseña_TextChanged(object sender, EventArgs e)
        {
            repetirContraseña = textBoxRepiteContraseña.Text;
        }

        private LinkLabel linkLabel1;
        private Label TUSHUEVOS;

        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TUSHUEVOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(307, 113);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // TUSHUEVOS
            // 
            this.TUSHUEVOS.AutoSize = true;
            this.TUSHUEVOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F);
            this.TUSHUEVOS.Location = new System.Drawing.Point(-58, 89);
            this.TUSHUEVOS.Name = "TUSHUEVOS";
            this.TUSHUEVOS.Size = new System.Drawing.Size(1390, 226);
            this.TUSHUEVOS.TabIndex = 1;
            this.TUSHUEVOS.Text = "TUS HUEVOS";
            // 
            // TUSHUEBOS
            // 
            this.ClientSize = new System.Drawing.Size(1253, 458);
            this.Controls.Add(this.TUSHUEVOS);
            this.Controls.Add(this.linkLabel1);
            this.Name = "TUSHUEBOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
