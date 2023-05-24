namespace DesktopWireframe
{
    partial class Gestion_Preguntas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.dataGridViewPreguntas = new System.Windows.Forms.DataGridView();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonEditar.Location = new System.Drawing.Point(449, 22);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(156, 37);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonBorrar.Location = new System.Drawing.Point(633, 22);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(156, 37);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxDificultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Infantil",
            "Baja",
            "Media",
            "Alta"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(181, 29);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(233, 24);
            this.comboBoxDificultad.TabIndex = 2;
            this.comboBoxDificultad.SelectedIndexChanged += new System.EventHandler(this.comboBoxDificultad_SelectedIndexChanged);
            // 
            // dataGridViewPreguntas
            // 
            this.dataGridViewPreguntas.AllowUserToAddRows = false;
            this.dataGridViewPreguntas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPreguntas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPreguntas.Location = new System.Drawing.Point(48, 82);
            this.dataGridViewPreguntas.MultiSelect = false;
            this.dataGridViewPreguntas.Name = "dataGridViewPreguntas";
            this.dataGridViewPreguntas.ReadOnly = true;
            this.dataGridViewPreguntas.RowHeadersWidth = 51;
            this.dataGridViewPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPreguntas.Size = new System.Drawing.Size(961, 467);
            this.dataGridViewPreguntas.TabIndex = 5;
            // 
            // labelDificultad
            // 
            this.labelDificultad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDificultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.labelDificultad.Location = new System.Drawing.Point(110, 32);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(66, 17);
            this.labelDificultad.TabIndex = 1;
            this.labelDificultad.Text = "Dificultad";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.buttonSettings);
            this.panelForm.Location = new System.Drawing.Point(-1, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1056, 570);
            this.panelForm.TabIndex = 6;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonSettings.Location = new System.Drawing.Point(817, 22);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(156, 37);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "OPCIONES";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // Gestion_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1054, 570);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.dataGridViewPreguntas);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.panelForm);
            this.MaximumSize = new System.Drawing.Size(1070, 609);
            this.MinimumSize = new System.Drawing.Size(1070, 609);
            this.Name = "Gestion_Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Gestion_Preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.DataGridView dataGridViewPreguntas;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonSettings;
    }
}

