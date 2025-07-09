namespace SistemaClinica
{
    partial class App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcPanel = new System.Windows.Forms.TabControl();
            this.tbPage1 = new System.Windows.Forms.TabPage();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarDNI = new System.Windows.Forms.TextBox();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.btnCitaAtendida = new System.Windows.Forms.Button();
            this.btnSubirCita = new System.Windows.Forms.Button();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.btnBajarCita = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.AgendaDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaSintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgendaEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbEspecialidadAgenda = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.textSintomas = new System.Windows.Forms.TextBox();
            this.textNumeroCelular = new System.Windows.Forms.TextBox();
            this.textFechaCita = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPage3 = new System.Windows.Forms.TabPage();
            this.lblLugarActual = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbInicio = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtApellidosIns = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNombresIns = new System.Windows.Forms.TextBox();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tcPanel.SuspendLayout();
            this.tbPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.panel3.SuspendLayout();
            this.tbPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.panel4.SuspendLayout();
            this.tbPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tcPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 719);
            this.panel1.TabIndex = 0;
            // 
            // tcPanel
            // 
            this.tcPanel.Controls.Add(this.tbPage1);
            this.tcPanel.Controls.Add(this.tbPage2);
            this.tcPanel.Controls.Add(this.tbPage3);
            this.tcPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPanel.Location = new System.Drawing.Point(17, 79);
            this.tcPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcPanel.Name = "tcPanel";
            this.tcPanel.SelectedIndex = 0;
            this.tcPanel.Size = new System.Drawing.Size(1341, 638);
            this.tcPanel.TabIndex = 0;
            // 
            // tbPage1
            // 
            this.tbPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPage1.Controls.Add(this.btnContar);
            this.tbPage1.Controls.Add(this.btnVaciar);
            this.tbPage1.Controls.Add(this.btnPrimero);
            this.tbPage1.Controls.Add(this.btnAtender);
            this.tbPage1.Controls.Add(this.dgvCola);
            this.tbPage1.Controls.Add(this.panel3);
            this.tbPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPage1.Location = new System.Drawing.Point(4, 28);
            this.tbPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage1.Name = "tbPage1";
            this.tbPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage1.Size = new System.Drawing.Size(1333, 606);
            this.tbPage1.TabIndex = 1;
            this.tbPage1.Text = "Sala de Espera (Cola)";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(1125, 551);
            this.btnContar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(195, 28);
            this.btnContar.TabIndex = 14;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(923, 551);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(195, 28);
            this.btnVaciar.TabIndex = 13;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(723, 551);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(192, 28);
            this.btnPrimero.TabIndex = 12;
            this.btnPrimero.Text = "Ver Primero en Cola";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(473, 551);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(241, 28);
            this.btnAtender.TabIndex = 11;
            this.btnAtender.Text = "Atender Paciente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // dgvCola
            // 
            this.dgvCola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Prioridad,
            this.Nombres,
            this.Apellidos,
            this.Sintomas,
            this.Especialidad,
            this.Edad});
            this.dgvCola.Location = new System.Drawing.Point(473, 37);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(847, 492);
            this.dgvCola.TabIndex = 1;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            this.Prioridad.Width = 125;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.MinimumWidth = 6;
            this.Sintomas.Name = "Sintomas";
            this.Sintomas.ReadOnly = true;
            this.Sintomas.Width = 125;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbEspecialidad);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtSintomas);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.rbNo);
            this.panel3.Controls.Add(this.rbSi);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Controls.Add(this.txtDNI);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtEdad);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtApellidos);
            this.panel3.Controls.Add(this.txtNombres);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 591);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Label de Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.ForeColor = System.Drawing.Color.Gray;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Pediatria",
            "Cirugia",
            "Medicina Interna",
            "Dermatologia"});
            this.cbEspecialidad.Location = new System.Drawing.Point(120, 401);
            this.cbEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(297, 27);
            this.cbEspecialidad.TabIndex = 17;
            this.cbEspecialidad.Text = "Seleccionar...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Especialidad";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(120, 308);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(297, 62);
            this.txtSintomas.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sintomas";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(244, 251);
            this.rbNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 23);
            this.rbNo.TabIndex = 13;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(129, 251);
            this.rbSi.Margin = new System.Windows.Forms.Padding(4);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(42, 23);
            this.rbSi.TabIndex = 12;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prioridad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 546);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(399, 28);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Paciente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDNI.Location = new System.Drawing.Point(120, 28);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(297, 27);
            this.txtDNI.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(120, 199);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(297, 27);
            this.txtEdad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(120, 144);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(297, 27);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(120, 87);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(297, 27);
            this.txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num. DNI";
            // 
            // tbPage2
            // 
            this.tbPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPage2.Controls.Add(this.panel5);
            this.tbPage2.Controls.Add(this.label18);
            this.tbPage2.Controls.Add(this.dgvListaDoble);
            this.tbPage2.Controls.Add(this.cbEspecialidadAgenda);
            this.tbPage2.Controls.Add(this.label19);
            this.tbPage2.Controls.Add(this.panel4);
            this.tbPage2.Controls.Add(this.textSintomas);
            this.tbPage2.Controls.Add(this.textNumeroCelular);
            this.tbPage2.Controls.Add(this.textFechaCita);
            this.tbPage2.Controls.Add(this.textDireccion);
            this.tbPage2.Controls.Add(this.textApellido);
            this.tbPage2.Controls.Add(this.textNombre);
            this.tbPage2.Controls.Add(this.textDNI);
            this.tbPage2.Controls.Add(this.label17);
            this.tbPage2.Controls.Add(this.label16);
            this.tbPage2.Controls.Add(this.label15);
            this.tbPage2.Controls.Add(this.label14);
            this.tbPage2.Controls.Add(this.label13);
            this.tbPage2.Controls.Add(this.label12);
            this.tbPage2.Controls.Add(this.label11);
            this.tbPage2.Controls.Add(this.label10);
            this.tbPage2.ForeColor = System.Drawing.Color.Black;
            this.tbPage2.Location = new System.Drawing.Point(4, 28);
            this.tbPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage2.Size = new System.Drawing.Size(1333, 606);
            this.tbPage2.TabIndex = 0;
            this.tbPage2.Text = "Agendar Citas (Lista Doble)";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.txtEliminarDNI);
            this.panel5.Controls.Add(this.txtBuscarDNI);
            this.panel5.Controls.Add(this.btnCitaAtendida);
            this.panel5.Controls.Add(this.btnSubirCita);
            this.panel5.Controls.Add(this.btnBuscarDNI);
            this.panel5.Controls.Add(this.btnBajarCita);
            this.panel5.Location = new System.Drawing.Point(967, 293);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 264);
            this.panel5.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(209, 221);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 28);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarDNI
            // 
            this.txtEliminarDNI.AcceptsTab = true;
            this.txtEliminarDNI.ForeColor = System.Drawing.Color.Black;
            this.txtEliminarDNI.Location = new System.Drawing.Point(23, 221);
            this.txtEliminarDNI.Name = "txtEliminarDNI";
            this.txtEliminarDNI.Size = new System.Drawing.Size(179, 24);
            this.txtEliminarDNI.TabIndex = 21;
            this.txtEliminarDNI.Tag = "";
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.AcceptsTab = true;
            this.txtBuscarDNI.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarDNI.Location = new System.Drawing.Point(23, 175);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(179, 24);
            this.txtBuscarDNI.TabIndex = 20;
            this.txtBuscarDNI.Tag = "";
            // 
            // btnCitaAtendida
            // 
            this.btnCitaAtendida.Location = new System.Drawing.Point(23, 123);
            this.btnCitaAtendida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitaAtendida.Name = "btnCitaAtendida";
            this.btnCitaAtendida.Size = new System.Drawing.Size(295, 28);
            this.btnCitaAtendida.TabIndex = 19;
            this.btnCitaAtendida.Text = "Marcar como Atendido";
            this.btnCitaAtendida.UseVisualStyleBackColor = true;
            this.btnCitaAtendida.Click += new System.EventHandler(this.btnCitaAtendida_Click);
            // 
            // btnSubirCita
            // 
            this.btnSubirCita.Location = new System.Drawing.Point(23, 21);
            this.btnSubirCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubirCita.Name = "btnSubirCita";
            this.btnSubirCita.Size = new System.Drawing.Size(295, 28);
            this.btnSubirCita.TabIndex = 16;
            this.btnSubirCita.Text = "Subir Cita";
            this.btnSubirCita.UseVisualStyleBackColor = true;
            this.btnSubirCita.Click += new System.EventHandler(this.btnSubirCita_Click);
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.Location = new System.Drawing.Point(209, 173);
            this.btnBuscarDNI.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(109, 28);
            this.btnBuscarDNI.TabIndex = 17;
            this.btnBuscarDNI.Text = "Buscar";
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // btnBajarCita
            // 
            this.btnBajarCita.Location = new System.Drawing.Point(23, 74);
            this.btnBajarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajarCita.Name = "btnBajarCita";
            this.btnBajarCita.Size = new System.Drawing.Size(295, 28);
            this.btnBajarCita.TabIndex = 18;
            this.btnBajarCita.Text = "Bajar Cita";
            this.btnBajarCita.UseVisualStyleBackColor = true;
            this.btnBajarCita.Click += new System.EventHandler(this.btnBajarCita_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1070, 260);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "Controles de la Lista";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgendaDNI,
            this.AgendaNombres,
            this.AgendaApellidos,
            this.AgendaDireccion,
            this.AgendaFecha,
            this.AgendaCel,
            this.AgendaSintomas,
            this.AgendaEspecialidad});
            this.dgvListaDoble.Location = new System.Drawing.Point(44, 258);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.Size = new System.Drawing.Size(892, 315);
            this.dgvListaDoble.TabIndex = 23;
            // 
            // AgendaDNI
            // 
            this.AgendaDNI.HeaderText = "DNI";
            this.AgendaDNI.MinimumWidth = 6;
            this.AgendaDNI.Name = "AgendaDNI";
            this.AgendaDNI.ReadOnly = true;
            this.AgendaDNI.Width = 125;
            // 
            // AgendaNombres
            // 
            this.AgendaNombres.HeaderText = "Nombres";
            this.AgendaNombres.MinimumWidth = 6;
            this.AgendaNombres.Name = "AgendaNombres";
            this.AgendaNombres.ReadOnly = true;
            this.AgendaNombres.Width = 125;
            // 
            // AgendaApellidos
            // 
            this.AgendaApellidos.HeaderText = "Apellidos";
            this.AgendaApellidos.MinimumWidth = 6;
            this.AgendaApellidos.Name = "AgendaApellidos";
            this.AgendaApellidos.ReadOnly = true;
            this.AgendaApellidos.Width = 125;
            // 
            // AgendaDireccion
            // 
            this.AgendaDireccion.HeaderText = "Direccion";
            this.AgendaDireccion.MinimumWidth = 6;
            this.AgendaDireccion.Name = "AgendaDireccion";
            this.AgendaDireccion.ReadOnly = true;
            this.AgendaDireccion.Width = 125;
            // 
            // AgendaFecha
            // 
            this.AgendaFecha.HeaderText = "Fecha";
            this.AgendaFecha.MinimumWidth = 6;
            this.AgendaFecha.Name = "AgendaFecha";
            this.AgendaFecha.ReadOnly = true;
            this.AgendaFecha.Width = 125;
            // 
            // AgendaCel
            // 
            this.AgendaCel.HeaderText = "Celular";
            this.AgendaCel.MinimumWidth = 6;
            this.AgendaCel.Name = "AgendaCel";
            this.AgendaCel.ReadOnly = true;
            this.AgendaCel.Width = 125;
            // 
            // AgendaSintomas
            // 
            this.AgendaSintomas.HeaderText = "Sintomas";
            this.AgendaSintomas.MinimumWidth = 6;
            this.AgendaSintomas.Name = "AgendaSintomas";
            this.AgendaSintomas.ReadOnly = true;
            this.AgendaSintomas.Width = 125;
            // 
            // AgendaEspecialidad
            // 
            this.AgendaEspecialidad.HeaderText = "Especialidad";
            this.AgendaEspecialidad.MinimumWidth = 6;
            this.AgendaEspecialidad.Name = "AgendaEspecialidad";
            this.AgendaEspecialidad.ReadOnly = true;
            this.AgendaEspecialidad.Width = 125;
            // 
            // cbEspecialidadAgenda
            // 
            this.cbEspecialidadAgenda.FormattingEnabled = true;
            this.cbEspecialidadAgenda.Items.AddRange(new object[] {
            "Pediatria",
            "Cirugia",
            "Medicina Interna",
            "Dermatologia"});
            this.cbEspecialidadAgenda.Location = new System.Drawing.Point(635, 193);
            this.cbEspecialidadAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.cbEspecialidadAgenda.Name = "cbEspecialidadAgenda";
            this.cbEspecialidadAgenda.Size = new System.Drawing.Size(300, 27);
            this.cbEspecialidadAgenda.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1052, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 19);
            this.label19.TabIndex = 21;
            this.label19.Text = "Controles del Formulario";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnAgendarCita);
            this.panel4.Controls.Add(this.btnLimpiarFormulario);
            this.panel4.Controls.Add(this.btnActualizarLista);
            this.panel4.Location = new System.Drawing.Point(967, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 176);
            this.panel4.TabIndex = 19;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(23, 23);
            this.btnAgendarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(295, 28);
            this.btnAgendarCita.TabIndex = 16;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnLimpiarFormulario
            // 
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(23, 129);
            this.btnLimpiarFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(295, 28);
            this.btnLimpiarFormulario.TabIndex = 17;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(23, 74);
            this.btnActualizarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(295, 28);
            this.btnActualizarLista.TabIndex = 18;
            this.btnActualizarLista.Text = "Actualizar Lista";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // textSintomas
            // 
            this.textSintomas.Location = new System.Drawing.Point(635, 140);
            this.textSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.textSintomas.Name = "textSintomas";
            this.textSintomas.Size = new System.Drawing.Size(300, 24);
            this.textSintomas.TabIndex = 14;
            // 
            // textNumeroCelular
            // 
            this.textNumeroCelular.Location = new System.Drawing.Point(635, 79);
            this.textNumeroCelular.Margin = new System.Windows.Forms.Padding(4);
            this.textNumeroCelular.Name = "textNumeroCelular";
            this.textNumeroCelular.Size = new System.Drawing.Size(300, 24);
            this.textNumeroCelular.TabIndex = 13;
            // 
            // textFechaCita
            // 
            this.textFechaCita.Location = new System.Drawing.Point(635, 31);
            this.textFechaCita.Margin = new System.Windows.Forms.Padding(4);
            this.textFechaCita.Name = "textFechaCita";
            this.textFechaCita.Size = new System.Drawing.Size(300, 24);
            this.textFechaCita.TabIndex = 12;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(143, 197);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(316, 24);
            this.textDireccion.TabIndex = 11;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(143, 140);
            this.textApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(316, 24);
            this.textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(143, 85);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(316, 24);
            this.textNombre.TabIndex = 9;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(143, 31);
            this.textDNI.Margin = new System.Windows.Forms.Padding(4);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(316, 24);
            this.textDNI.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 197);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "Dirección";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(504, 197);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Especialidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 140);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Sintomas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Núm. Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fecha de Cita";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Apellidos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "DNI";
            // 
            // tbPage3
            // 
            this.tbPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPage3.Controls.Add(this.lblLugarActual);
            this.tbPage3.Controls.Add(this.panel7);
            this.tbPage3.Controls.Add(this.label26);
            this.tbPage3.Controls.Add(this.label20);
            this.tbPage3.Controls.Add(this.panel6);
            this.tbPage3.Controls.Add(this.dgvGrafo);
            this.tbPage3.Location = new System.Drawing.Point(4, 28);
            this.tbPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage3.Name = "tbPage3";
            this.tbPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPage3.Size = new System.Drawing.Size(1333, 606);
            this.tbPage3.TabIndex = 2;
            this.tbPage3.Text = "Inscripción para Rutas Medicas (Grafos)";
            // 
            // lblLugarActual
            // 
            this.lblLugarActual.AutoSize = true;
            this.lblLugarActual.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarActual.ForeColor = System.Drawing.Color.Red;
            this.lblLugarActual.Location = new System.Drawing.Point(17, 25);
            this.lblLugarActual.Name = "lblLugarActual";
            this.lblLugarActual.Size = new System.Drawing.Size(108, 20);
            this.lblLugarActual.TabIndex = 6;
            this.lblLugarActual.Text = "Lugar Actual: ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnNavegar);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Location = new System.Drawing.Point(836, 475);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(471, 76);
            this.panel7.TabIndex = 5;
            // 
            // btnNavegar
            // 
            this.btnNavegar.Location = new System.Drawing.Point(244, 23);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(204, 30);
            this.btnNavegar.TabIndex = 4;
            this.btnNavegar.Text = "Navegar";
            this.btnNavegar.UseVisualStyleBackColor = true;
            this.btnNavegar.Click += new System.EventHandler(this.btnNavegar_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(196, 19);
            this.label28.TabIndex = 3;
            this.label28.Text = "Seleccione un lugar en la tabla";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1021, 436);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(119, 19);
            this.label26.TabIndex = 4;
            this.label26.Text = "Controles de Ruta";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(991, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 19);
            this.label20.TabIndex = 3;
            this.label20.Text = "Inscripción del Encargado";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.cbInicio);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.cbRol);
            this.panel6.Controls.Add(this.btnInscribir);
            this.panel6.Controls.Add(this.cbServicio);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.txtApellidosIns);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.txtNombresIns);
            this.panel6.Location = new System.Drawing.Point(836, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(471, 328);
            this.panel6.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(205, 32);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbInicio
            // 
            this.cbInicio.FormattingEnabled = true;
            this.cbInicio.Items.AddRange(new object[] {
            "MegaPlaza",
            "RealPlaza",
            "UPN",
            "Ovalo Musical",
            "Recoleta",
            "Puente Amarillo",
            "Plaza de Armas"});
            this.cbInicio.Location = new System.Drawing.Point(159, 202);
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(289, 27);
            this.cbInicio.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 19);
            this.label25.TabIndex = 11;
            this.label25.Text = "Punto de Inicio";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 161);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 19);
            this.label24.TabIndex = 10;
            this.label24.Text = "Rol del Encargado";
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Pediatra",
            "Psicologo",
            "Cardiólogo",
            "Enfermero/a"});
            this.cbRol.Location = new System.Drawing.Point(159, 157);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(289, 27);
            this.cbRol.TabIndex = 9;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(22, 269);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(215, 32);
            this.btnInscribir.TabIndex = 1;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Distribución de medicamentos",
            "Campañas de salud pública",
            "Atención comunitaria",
            "Visitas domiciliarias"});
            this.cbServicio.Location = new System.Drawing.Point(159, 109);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(288, 27);
            this.cbServicio.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 19);
            this.label23.TabIndex = 7;
            this.label23.Text = "Tipo de Servicio";
            // 
            // txtApellidosIns
            // 
            this.txtApellidosIns.Location = new System.Drawing.Point(159, 67);
            this.txtApellidosIns.Name = "txtApellidosIns";
            this.txtApellidosIns.Size = new System.Drawing.Size(288, 24);
            this.txtApellidosIns.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 19);
            this.label22.TabIndex = 5;
            this.label22.Text = "Apellidos";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 19);
            this.label21.TabIndex = 4;
            this.label21.Text = "Nombres";
            // 
            // txtNombresIns
            // 
            this.txtNombresIns.Location = new System.Drawing.Point(159, 26);
            this.txtNombresIns.Name = "txtNombresIns";
            this.txtNombresIns.Size = new System.Drawing.Size(288, 24);
            this.txtNombresIns.TabIndex = 0;
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lugar,
            this.Distancia,
            this.Servicio,
            this.NombresApellidos,
            this.Rol});
            this.dgvGrafo.Location = new System.Drawing.Point(21, 62);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.Size = new System.Drawing.Size(794, 489);
            this.dgvGrafo.TabIndex = 0;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugares Disponibles";
            this.Lugar.MinimumWidth = 6;
            this.Lugar.Name = "Lugar";
            this.Lugar.Width = 175;
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Distancia (KM)";
            this.Distancia.MinimumWidth = 6;
            this.Distancia.Name = "Distancia";
            this.Distancia.ReadOnly = true;
            this.Distancia.Width = 125;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Tipo de Servicio";
            this.Servicio.MinimumWidth = 6;
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Width = 175;
            // 
            // NombresApellidos
            // 
            this.NombresApellidos.HeaderText = "Nombres del Encargado";
            this.NombresApellidos.MinimumWidth = 6;
            this.NombresApellidos.Name = "NombresApellidos";
            this.NombresApellidos.ReadOnly = true;
            this.NombresApellidos.Width = 185;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 110;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1373, 74);
            this.panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(419, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Citas Medicas";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 719);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación";
            this.panel1.ResumeLayout(false);
            this.tcPanel.ResumeLayout(false);
            this.tbPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbPage2.ResumeLayout(false);
            this.tbPage2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tbPage3.ResumeLayout(false);
            this.tbPage3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tbPage1;
        public System.Windows.Forms.TabPage tbPage2;
        public System.Windows.Forms.TabPage tbPage3;
        private System.Windows.Forms.TabControl tcPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.TextBox textSintomas;
        private System.Windows.Forms.TextBox textNumeroCelular;
        private System.Windows.Forms.TextBox textFechaCita;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.ComboBox cbEspecialidadAgenda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSubirCita;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.Button btnBajarCita;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaSintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgendaEspecialidad;
        private System.Windows.Forms.Button btnCitaAtendida;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminarDNI;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombresIns;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtApellidosIns;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbInicio;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblLugarActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}

