namespace DesktopWireframe
{
    partial class MenuEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGestionPreguntas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAnadirPregunta = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemImagenesResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(182)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 39);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preguntasToolStripMenuItem,
            this.ToolStripMenuItemUsuarios,
            this.jugadoresToolStripMenuItem});
            this.rankingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rankingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.rankingToolStripMenuItem.Text = "Gestión";
            // 
            // preguntasToolStripMenuItem
            // 
            this.preguntasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemGestionPreguntas,
            this.ToolStripMenuItemAnadirPregunta,
            this.ToolStripMenuItemImagenesResultado});
            this.preguntasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.preguntasToolStripMenuItem.Name = "preguntasToolStripMenuItem";
            this.preguntasToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.preguntasToolStripMenuItem.Text = "Preguntas";
            // 
            // ToolStripMenuItemGestionPreguntas
            // 
            this.ToolStripMenuItemGestionPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.ToolStripMenuItemGestionPreguntas.Name = "ToolStripMenuItemGestionPreguntas";
            this.ToolStripMenuItemGestionPreguntas.Size = new System.Drawing.Size(230, 24);
            this.ToolStripMenuItemGestionPreguntas.Text = "Gestión de las preguntas";
            this.ToolStripMenuItemGestionPreguntas.Click += new System.EventHandler(this.ToolStripMenuItemGestionPreguntas_Click);
            // 
            // ToolStripMenuItemAnadirPregunta
            // 
            this.ToolStripMenuItemAnadirPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.ToolStripMenuItemAnadirPregunta.Name = "ToolStripMenuItemAnadirPregunta";
            this.ToolStripMenuItemAnadirPregunta.Size = new System.Drawing.Size(230, 24);
            this.ToolStripMenuItemAnadirPregunta.Text = "Añadir pregunta";
            this.ToolStripMenuItemAnadirPregunta.Click += new System.EventHandler(this.ToolStripMenuItemAnadirPregunta_Click);
            // 
            // ToolStripMenuItemImagenesResultado
            // 
            this.ToolStripMenuItemImagenesResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.ToolStripMenuItemImagenesResultado.Name = "ToolStripMenuItemImagenesResultado";
            this.ToolStripMenuItemImagenesResultado.Size = new System.Drawing.Size(230, 24);
            this.ToolStripMenuItemImagenesResultado.Text = "Imágenes resultado";
            this.ToolStripMenuItemImagenesResultado.Click += new System.EventHandler(this.ToolStripMenuItemImagenesResultado_Click);
            // 
            // ToolStripMenuItemUsuarios
            // 
            this.ToolStripMenuItemUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.ToolStripMenuItemUsuarios.Name = "ToolStripMenuItemUsuarios";
            this.ToolStripMenuItemUsuarios.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItemUsuarios.Text = "Gestión de Usuarios";
            this.ToolStripMenuItemUsuarios.Click += new System.EventHandler(this.ToolStripMenuItemUsuarios_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Enabled = false;
            this.jugadoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.jugadoresToolStripMenuItem.Text = "Gestión de Jugadores";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(825, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Editor";
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.AutoSize = true;
            this.panelForm.Location = new System.Drawing.Point(0, 38);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1054, 574);
            this.panelForm.TabIndex = 21;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(182)))));
            this.pictureBoxUsuario.Image = global::DesktopWireframe.Properties.Resources.usuario;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(878, 5);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 20;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(191)))), ((int)(((byte)(182)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(924, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cerrar sesión";
            this.label1.Click += new System.EventHandler(this.ToolStripMenuItemCerrarSesion_Click);
            // 
            // MenuEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1054, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.Location = new System.Drawing.Point(1070, 650);
            this.MaximumSize = new System.Drawing.Size(1070, 650);
            this.MinimumSize = new System.Drawing.Size(1070, 650);
            this.Name = "MenuEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Editor";
            this.Load += new System.EventHandler(this.MenuEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGestionPreguntas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAnadirPregunta;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImagenesResultado;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label1;
    }
}