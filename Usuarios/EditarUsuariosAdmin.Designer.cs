namespace WindowsFormsApp2
{
    partial class EditarUsuariosAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.buttonOpcionDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEditarTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEditarUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEditarConfirmarContrasenaRegistro = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxEditarContrasenaRegistro = new System.Windows.Forms.TextBox();
            this.buttonGuardarEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
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
            this.buttonOpcionEditar = new System.Windows.Forms.Button();
            this.buttonOpcionAnadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelAdd.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(526, 352);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // buttonOpcionDelete
            // 
            this.buttonOpcionDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpcionDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonOpcionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpcionDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonOpcionDelete.Location = new System.Drawing.Point(429, 423);
            this.buttonOpcionDelete.Name = "buttonOpcionDelete";
            this.buttonOpcionDelete.Size = new System.Drawing.Size(156, 37);
            this.buttonOpcionDelete.TabIndex = 2;
            this.buttonOpcionDelete.Text = "ELIMINAR USUARIO";
            this.buttonOpcionDelete.UseVisualStyleBackColor = false;
            this.buttonOpcionDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.comboBoxEditarTipoUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEditarUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEditarConfirmarContrasenaRegistro);
            this.groupBox1.Controls.Add(this.labelContraseña);
            this.groupBox1.Controls.Add(this.textBoxEditarContrasenaRegistro);
            this.groupBox1.Controls.Add(this.buttonGuardarEdit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 362);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar usuario";
            // 
            // comboBoxEditarTipoUsuario
            // 
            this.comboBoxEditarTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEditarTipoUsuario.BackColor = System.Drawing.Color.Silver;
            this.comboBoxEditarTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditarTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.comboBoxEditarTipoUsuario.FormattingEnabled = true;
            this.comboBoxEditarTipoUsuario.Items.AddRange(new object[] {
            "Admin",
            "Editor",
            "Normal"});
            this.comboBoxEditarTipoUsuario.Location = new System.Drawing.Point(45, 243);
            this.comboBoxEditarTipoUsuario.Name = "comboBoxEditarTipoUsuario";
            this.comboBoxEditarTipoUsuario.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEditarTipoUsuario.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(42, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tipo de usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(42, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre Usuario";
            // 
            // textBoxEditarUserName
            // 
            this.textBoxEditarUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEditarUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxEditarUserName.Location = new System.Drawing.Point(45, 83);
            this.textBoxEditarUserName.Name = "textBoxEditarUserName";
            this.textBoxEditarUserName.Size = new System.Drawing.Size(200, 23);
            this.textBoxEditarUserName.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(42, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // textBoxEditarConfirmarContrasenaRegistro
            // 
            this.textBoxEditarConfirmarContrasenaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEditarConfirmarContrasenaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxEditarConfirmarContrasenaRegistro.Location = new System.Drawing.Point(45, 192);
            this.textBoxEditarConfirmarContrasenaRegistro.Name = "textBoxEditarConfirmarContrasenaRegistro";
            this.textBoxEditarConfirmarContrasenaRegistro.Size = new System.Drawing.Size(200, 23);
            this.textBoxEditarConfirmarContrasenaRegistro.TabIndex = 42;
            this.textBoxEditarConfirmarContrasenaRegistro.UseSystemPasswordChar = true;
            // 
            // labelContraseña
            // 
            this.labelContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelContraseña.Location = new System.Drawing.Point(42, 116);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(81, 17);
            this.labelContraseña.TabIndex = 40;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxEditarContrasenaRegistro
            // 
            this.textBoxEditarContrasenaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEditarContrasenaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.textBoxEditarContrasenaRegistro.Location = new System.Drawing.Point(45, 136);
            this.textBoxEditarContrasenaRegistro.Name = "textBoxEditarContrasenaRegistro";
            this.textBoxEditarContrasenaRegistro.Size = new System.Drawing.Size(200, 23);
            this.textBoxEditarContrasenaRegistro.TabIndex = 39;
            this.textBoxEditarContrasenaRegistro.UseSystemPasswordChar = true;
            // 
            // buttonGuardarEdit
            // 
            this.buttonGuardarEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGuardarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonGuardarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonGuardarEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonGuardarEdit.Location = new System.Drawing.Point(140, 302);
            this.buttonGuardarEdit.Name = "buttonGuardarEdit";
            this.buttonGuardarEdit.Size = new System.Drawing.Size(105, 30);
            this.buttonGuardarEdit.TabIndex = 7;
            this.buttonGuardarEdit.Text = "ACTUALIZAR";
            this.buttonGuardarEdit.UseVisualStyleBackColor = false;
            this.buttonGuardarEdit.Click += new System.EventHandler(this.buttonGuardarEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Controls.Add(this.panelAdd);
            this.panel1.Controls.Add(this.buttonOpcionEditar);
            this.panel1.Controls.Add(this.buttonOpcionAnadir);
            this.panel1.Controls.Add(this.buttonOpcionDelete);
            this.panel1.Controls.Add(this.dataGridViewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 570);
            this.panel1.TabIndex = 20;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEdit.Controls.Add(this.groupBox1);
            this.panelEdit.Location = new System.Drawing.Point(652, 46);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(293, 375);
            this.panelEdit.TabIndex = 20;
            // 
            // panelAdd
            // 
            this.panelAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAdd.Controls.Add(this.groupBox2);
            this.panelAdd.Location = new System.Drawing.Point(652, 46);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(306, 386);
            this.panelAdd.TabIndex = 21;
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
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
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
            "Admin",
            "Editor",
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
            // buttonOpcionEditar
            // 
            this.buttonOpcionEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpcionEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonOpcionEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpcionEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonOpcionEditar.Location = new System.Drawing.Point(105, 423);
            this.buttonOpcionEditar.Name = "buttonOpcionEditar";
            this.buttonOpcionEditar.Size = new System.Drawing.Size(156, 37);
            this.buttonOpcionEditar.TabIndex = 23;
            this.buttonOpcionEditar.Text = "EDITAR USUARIO";
            this.buttonOpcionEditar.UseVisualStyleBackColor = false;
            this.buttonOpcionEditar.Click += new System.EventHandler(this.buttonOpcionEditar_Click);
            // 
            // buttonOpcionAnadir
            // 
            this.buttonOpcionAnadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpcionAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(158)))));
            this.buttonOpcionAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonOpcionAnadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.buttonOpcionAnadir.Location = new System.Drawing.Point(267, 423);
            this.buttonOpcionAnadir.Name = "buttonOpcionAnadir";
            this.buttonOpcionAnadir.Size = new System.Drawing.Size(156, 37);
            this.buttonOpcionAnadir.TabIndex = 22;
            this.buttonOpcionAnadir.Text = "AÑADIR USUARIO";
            this.buttonOpcionAnadir.UseVisualStyleBackColor = false;
            this.buttonOpcionAnadir.Click += new System.EventHandler(this.buttonOpcionAnadir_Click);
            // 
            // EditarUsuariosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1054, 570);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(27)))), ((int)(((byte)(25)))));
            this.Name = "EditarUsuariosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuariosAdmin";
            this.Load += new System.EventHandler(this.tablaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button buttonOpcionDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEditarTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEditarUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEditarConfirmarContrasenaRegistro;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxEditarContrasenaRegistro;
        private System.Windows.Forms.Button buttonGuardarEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonOpcionEditar;
        private System.Windows.Forms.Button buttonOpcionAnadir;
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