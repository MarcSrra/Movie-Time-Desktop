namespace WindowsFormsApp2
{
    partial class EditarUsuariosEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAnadirTipoUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnadirUserNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAnadirUserConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAnadirUserContrasena = new System.Windows.Forms.TextBox();
            this.buttonCrearUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUser.Location = new System.Drawing.Point(59, 56);
            this.dataGridViewUser.MultiSelect = false;
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(526, 352);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dataGridViewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 570);
            this.panel1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.comboBoxAnadirTipoUser);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxAnadirUserNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxAnadirUserConfirmarContrasena);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxAnadirUserContrasena);
            this.groupBox2.Controls.Add(this.buttonCrearUser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.groupBox2.Location = new System.Drawing.Point(652, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 362);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir usuario";
            // 
            // comboBoxAnadirTipoUser
            // 
            this.comboBoxAnadirTipoUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAnadirTipoUser.BackColor = System.Drawing.Color.Silver;
            this.comboBoxAnadirTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnadirTipoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxAnadirTipoUser.FormattingEnabled = true;
            this.comboBoxAnadirTipoUser.Items.AddRange(new object[] {
            "Normal"});
            this.comboBoxAnadirTipoUser.Location = new System.Drawing.Point(45, 243);
            this.comboBoxAnadirTipoUser.Name = "comboBoxAnadirTipoUser";
            this.comboBoxAnadirTipoUser.Size = new System.Drawing.Size(200, 24);
            this.comboBoxAnadirTipoUser.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(42, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tipo de usuario";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(42, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nombre Usuario";
            // 
            // textBoxAnadirUserNombre
            // 
            this.textBoxAnadirUserNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnadirUserNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxAnadirUserNombre.Location = new System.Drawing.Point(45, 83);
            this.textBoxAnadirUserNombre.Name = "textBoxAnadirUserNombre";
            this.textBoxAnadirUserNombre.Size = new System.Drawing.Size(200, 23);
            this.textBoxAnadirUserNombre.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(42, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // textBoxAnadirUserConfirmarContrasena
            // 
            this.textBoxAnadirUserConfirmarContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnadirUserConfirmarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxAnadirUserConfirmarContrasena.Location = new System.Drawing.Point(45, 192);
            this.textBoxAnadirUserConfirmarContrasena.Name = "textBoxAnadirUserConfirmarContrasena";
            this.textBoxAnadirUserConfirmarContrasena.Size = new System.Drawing.Size(200, 23);
            this.textBoxAnadirUserConfirmarContrasena.TabIndex = 42;
            this.textBoxAnadirUserConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.label7.Location = new System.Drawing.Point(42, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Contraseña";
            // 
            // textBoxAnadirUserContrasena
            // 
            this.textBoxAnadirUserContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnadirUserContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxAnadirUserContrasena.Location = new System.Drawing.Point(45, 136);
            this.textBoxAnadirUserContrasena.Name = "textBoxAnadirUserContrasena";
            this.textBoxAnadirUserContrasena.Size = new System.Drawing.Size(200, 23);
            this.textBoxAnadirUserContrasena.TabIndex = 39;
            this.textBoxAnadirUserContrasena.UseSystemPasswordChar = true;
            // 
            // buttonCrearUser
            // 
            this.buttonCrearUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCrearUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonCrearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCrearUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonCrearUser.Location = new System.Drawing.Point(140, 302);
            this.buttonCrearUser.Name = "buttonCrearUser";
            this.buttonCrearUser.Size = new System.Drawing.Size(105, 30);
            this.buttonCrearUser.TabIndex = 7;
            this.buttonCrearUser.Text = "AÑADIR";
            this.buttonCrearUser.UseVisualStyleBackColor = false;
            this.buttonCrearUser.Click += new System.EventHandler(this.buttonCrearUser_Click);
            // 
            // EditarUsuariosEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1054, 570);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.Name = "EditarUsuariosEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuariosAdmin";
            this.Load += new System.EventHandler(this.tablaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAnadirTipoUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAnadirUserNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAnadirUserConfirmarContrasena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAnadirUserContrasena;
        private System.Windows.Forms.Button buttonCrearUser;
    }
}