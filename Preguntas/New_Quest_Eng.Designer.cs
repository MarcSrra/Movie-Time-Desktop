namespace DesktopWireframe
{
    partial class New_Quest_Eng
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDificultad = new System.Windows.Forms.Label();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelRespuesta1 = new System.Windows.Forms.Label();
            this.textBoxRespuesta1 = new System.Windows.Forms.TextBox();
            this.labelRespuestaCorrecta = new System.Windows.Forms.Label();
            this.textBoxRespuestaCorrecta = new System.Windows.Forms.TextBox();
            this.labelRespuesta3 = new System.Windows.Forms.Label();
            this.textBoxRespuesta3 = new System.Windows.Forms.TextBox();
            this.labelRespuesta2 = new System.Windows.Forms.Label();
            this.textBoxRespuesta2 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBoxEngFlag = new System.Windows.Forms.PictureBox();
            this.comboBoxImagen = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagenPregunta = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panellinea = new System.Windows.Forms.Panel();
            this.labelNuevaPregunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPregunta)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDificultad.Location = new System.Drawing.Point(93, 158);
            this.labelDificultad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(80, 20);
            this.labelDificultad.TabIndex = 2;
            this.labelDificultad.Text = "Dificultad";
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDificultad.Enabled = false;
            this.comboBoxDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxDificultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Infantil",
            "Baja",
            "Media",
            "Alta"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(215, 149);
            this.comboBoxDificultad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(440, 28);
            this.comboBoxDificultad.TabIndex = 3;
            this.comboBoxDificultad.SelectedIndexChanged += new System.EventHandler(this.comboBoxDificultad_SelectedIndexChanged);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Enabled = false;
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "HOLLYWOOD",
            "TERROR",
            "ACTION",
            "SUPERHERO",
            "ROMANCE",
            "THRILLER",
            "SCIFI",
            "WAR",
            "COMEDY",
            "HISTORY",
            "FANTASY",
            "ADVENTURE",
            "INFANTIL",
            "MUSICAL"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(215, 215);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(440, 28);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCategoria.Location = new System.Drawing.Point(93, 219);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(81, 20);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxPregunta.Location = new System.Drawing.Point(97, 370);
            this.textBoxPregunta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPregunta.MaxLength = 125;
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPregunta.Size = new System.Drawing.Size(557, 79);
            this.textBoxPregunta.TabIndex = 7;
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPregunta.Location = new System.Drawing.Point(93, 346);
            this.labelPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(76, 20);
            this.labelPregunta.TabIndex = 8;
            this.labelPregunta.Text = "Pregunta";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelImagen.Location = new System.Drawing.Point(93, 283);
            this.labelImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(63, 20);
            this.labelImagen.TabIndex = 10;
            this.labelImagen.Text = "Imagen";
            // 
            // labelRespuesta1
            // 
            this.labelRespuesta1.AutoSize = true;
            this.labelRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRespuesta1.Location = new System.Drawing.Point(739, 462);
            this.labelRespuesta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRespuesta1.Name = "labelRespuesta1";
            this.labelRespuesta1.Size = new System.Drawing.Size(89, 20);
            this.labelRespuesta1.TabIndex = 14;
            this.labelRespuesta1.Text = "Respuesta";
            // 
            // textBoxRespuesta1
            // 
            this.textBoxRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRespuesta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxRespuesta1.Location = new System.Drawing.Point(743, 484);
            this.textBoxRespuesta1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRespuesta1.MaxLength = 100;
            this.textBoxRespuesta1.Multiline = true;
            this.textBoxRespuesta1.Name = "textBoxRespuesta1";
            this.textBoxRespuesta1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRespuesta1.Size = new System.Drawing.Size(557, 79);
            this.textBoxRespuesta1.TabIndex = 13;
            // 
            // labelRespuestaCorrecta
            // 
            this.labelRespuestaCorrecta.AutoSize = true;
            this.labelRespuestaCorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRespuestaCorrecta.Location = new System.Drawing.Point(93, 462);
            this.labelRespuestaCorrecta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRespuestaCorrecta.Name = "labelRespuestaCorrecta";
            this.labelRespuestaCorrecta.Size = new System.Drawing.Size(156, 20);
            this.labelRespuestaCorrecta.TabIndex = 12;
            this.labelRespuestaCorrecta.Text = "Respuesta correcta";
            // 
            // textBoxRespuestaCorrecta
            // 
            this.textBoxRespuestaCorrecta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(207)))));
            this.textBoxRespuestaCorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRespuestaCorrecta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxRespuestaCorrecta.Location = new System.Drawing.Point(97, 484);
            this.textBoxRespuestaCorrecta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRespuestaCorrecta.MaxLength = 100;
            this.textBoxRespuestaCorrecta.Multiline = true;
            this.textBoxRespuestaCorrecta.Name = "textBoxRespuestaCorrecta";
            this.textBoxRespuestaCorrecta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRespuestaCorrecta.Size = new System.Drawing.Size(557, 79);
            this.textBoxRespuestaCorrecta.TabIndex = 11;
            // 
            // labelRespuesta3
            // 
            this.labelRespuesta3.AutoSize = true;
            this.labelRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRespuesta3.Location = new System.Drawing.Point(739, 571);
            this.labelRespuesta3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRespuesta3.Name = "labelRespuesta3";
            this.labelRespuesta3.Size = new System.Drawing.Size(89, 20);
            this.labelRespuesta3.TabIndex = 18;
            this.labelRespuesta3.Text = "Respuesta";
            // 
            // textBoxRespuesta3
            // 
            this.textBoxRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRespuesta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxRespuesta3.Location = new System.Drawing.Point(743, 593);
            this.textBoxRespuesta3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRespuesta3.MaxLength = 100;
            this.textBoxRespuesta3.Multiline = true;
            this.textBoxRespuesta3.Name = "textBoxRespuesta3";
            this.textBoxRespuesta3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRespuesta3.Size = new System.Drawing.Size(557, 79);
            this.textBoxRespuesta3.TabIndex = 17;
            this.textBoxRespuesta3.TextChanged += new System.EventHandler(this.textBoxRespuesta3_TextChanged);
            // 
            // labelRespuesta2
            // 
            this.labelRespuesta2.AutoSize = true;
            this.labelRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRespuesta2.Location = new System.Drawing.Point(93, 571);
            this.labelRespuesta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRespuesta2.Name = "labelRespuesta2";
            this.labelRespuesta2.Size = new System.Drawing.Size(89, 20);
            this.labelRespuesta2.TabIndex = 16;
            this.labelRespuesta2.Text = "Respuesta";
            // 
            // textBoxRespuesta2
            // 
            this.textBoxRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxRespuesta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxRespuesta2.Location = new System.Drawing.Point(97, 593);
            this.textBoxRespuesta2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRespuesta2.MaxLength = 100;
            this.textBoxRespuesta2.Multiline = true;
            this.textBoxRespuesta2.Name = "textBoxRespuesta2";
            this.textBoxRespuesta2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRespuesta2.Size = new System.Drawing.Size(557, 79);
            this.textBoxRespuesta2.TabIndex = 15;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonGuardar.Location = new System.Drawing.Point(1055, 26);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(208, 49);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonCancelar.Location = new System.Drawing.Point(784, 26);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(208, 49);
            this.buttonCancelar.TabIndex = 19;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBoxEngFlag
            // 
            this.pictureBoxEngFlag.Image = global::DesktopWireframe.Properties.Resources.english_flag;
            this.pictureBoxEngFlag.Location = new System.Drawing.Point(97, 5);
            this.pictureBoxEngFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEngFlag.Name = "pictureBoxEngFlag";
            this.pictureBoxEngFlag.Size = new System.Drawing.Size(91, 90);
            this.pictureBoxEngFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEngFlag.TabIndex = 21;
            this.pictureBoxEngFlag.TabStop = false;
            // 
            // comboBoxImagen
            // 
            this.comboBoxImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxImagen.FormattingEnabled = true;
            this.comboBoxImagen.Location = new System.Drawing.Point(215, 279);
            this.comboBoxImagen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxImagen.Name = "comboBoxImagen";
            this.comboBoxImagen.Size = new System.Drawing.Size(440, 28);
            this.comboBoxImagen.TabIndex = 30;
            this.comboBoxImagen.SelectedIndexChanged += new System.EventHandler(this.comboBoxImagen_SelectedIndexChanged);
            // 
            // pictureBoxImagenPregunta
            // 
            this.pictureBoxImagenPregunta.Location = new System.Drawing.Point(784, 130);
            this.pictureBoxImagenPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImagenPregunta.Name = "pictureBoxImagenPregunta";
            this.pictureBoxImagenPregunta.Size = new System.Drawing.Size(479, 308);
            this.pictureBoxImagenPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenPregunta.TabIndex = 29;
            this.pictureBoxImagenPregunta.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 702);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.panelHeader.Controls.Add(this.panellinea);
            this.panelHeader.Controls.Add(this.labelNuevaPregunta);
            this.panelHeader.Controls.Add(this.pictureBoxEngFlag);
            this.panelHeader.Controls.Add(this.buttonCancelar);
            this.panelHeader.Controls.Add(this.buttonGuardar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1405, 102);
            this.panelHeader.TabIndex = 32;
            // 
            // panellinea
            // 
            this.panellinea.BackColor = System.Drawing.Color.LightGray;
            this.panellinea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panellinea.Location = new System.Drawing.Point(0, 100);
            this.panellinea.Margin = new System.Windows.Forms.Padding(4);
            this.panellinea.Name = "panellinea";
            this.panellinea.Size = new System.Drawing.Size(1405, 2);
            this.panellinea.TabIndex = 27;
            // 
            // labelNuevaPregunta
            // 
            this.labelNuevaPregunta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNuevaPregunta.AutoSize = true;
            this.labelNuevaPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.labelNuevaPregunta.Location = new System.Drawing.Point(209, 37);
            this.labelNuevaPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNuevaPregunta.Name = "labelNuevaPregunta";
            this.labelNuevaPregunta.Size = new System.Drawing.Size(195, 25);
            this.labelNuevaPregunta.TabIndex = 0;
            this.labelNuevaPregunta.Text = "NUEVA PREGUNTA";
            // 
            // New_Quest_Eng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1405, 702);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.comboBoxImagen);
            this.Controls.Add(this.pictureBoxImagenPregunta);
            this.Controls.Add(this.labelRespuesta3);
            this.Controls.Add(this.textBoxRespuesta3);
            this.Controls.Add(this.labelRespuesta2);
            this.Controls.Add(this.textBoxRespuesta2);
            this.Controls.Add(this.labelRespuesta1);
            this.Controls.Add(this.textBoxRespuesta1);
            this.Controls.Add(this.labelRespuestaCorrecta);
            this.Controls.Add(this.textBoxRespuestaCorrecta);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "New_Quest_Eng";
            this.Text = "GestionPreguntas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.New_Quest_Eng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenPregunta)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelRespuesta1;
        private System.Windows.Forms.TextBox textBoxRespuesta1;
        private System.Windows.Forms.Label labelRespuestaCorrecta;
        private System.Windows.Forms.TextBox textBoxRespuestaCorrecta;
        private System.Windows.Forms.Label labelRespuesta3;
        private System.Windows.Forms.TextBox textBoxRespuesta3;
        private System.Windows.Forms.Label labelRespuesta2;
        private System.Windows.Forms.TextBox textBoxRespuesta2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxEngFlag;
        private System.Windows.Forms.ComboBox comboBoxImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagenPregunta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panellinea;
        private System.Windows.Forms.Label labelNuevaPregunta;
    }
}

