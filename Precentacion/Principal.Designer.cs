namespace Precentacion
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_C = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Bienvenida = new System.Windows.Forms.Label();
            this.label_Hora = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton_Form = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Permisos = new System.Windows.Forms.Label();
            this.linkLabel_Perfil = new System.Windows.Forms.LinkLabel();
            this.iconButton_Menu = new FontAwesome.Sharp.IconButton();
            this.rjCircularPictureBox_ImagenP = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_ImagenP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_C);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel_C
            // 
            this.panel_C.BackColor = System.Drawing.Color.White;
            this.panel_C.Controls.Add(this.chart1);
            this.panel_C.Controls.Add(this.label1);
            this.panel_C.Controls.Add(this.label_Bienvenida);
            this.panel_C.Controls.Add(this.label_Hora);
            this.panel_C.Controls.Add(this.label_fecha);
            this.panel_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_C.Location = new System.Drawing.Point(230, 27);
            this.panel_C.Margin = new System.Windows.Forms.Padding(2);
            this.panel_C.Name = "panel_C";
            this.panel_C.Size = new System.Drawing.Size(714, 634);
            this.panel_C.TabIndex = 20;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 103);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(692, 400);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Servicio al cliente";
            // 
            // label_Bienvenida
            // 
            this.label_Bienvenida.AutoSize = true;
            this.label_Bienvenida.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bienvenida.Location = new System.Drawing.Point(5, 13);
            this.label_Bienvenida.Name = "label_Bienvenida";
            this.label_Bienvenida.Size = new System.Drawing.Size(122, 25);
            this.label_Bienvenida.TabIndex = 13;
            this.label_Bienvenida.Text = "Bienvenid@";
            // 
            // label_Hora
            // 
            this.label_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Hora.AutoSize = true;
            this.label_Hora.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hora.ForeColor = System.Drawing.Color.Black;
            this.label_Hora.Location = new System.Drawing.Point(537, 34);
            this.label_Hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Hora.Name = "label_Hora";
            this.label_Hora.Size = new System.Drawing.Size(52, 19);
            this.label_Hora.TabIndex = 12;
            this.label_Hora.Text = "label1";
            // 
            // label_fecha
            // 
            this.label_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.Black;
            this.label_fecha.Location = new System.Drawing.Point(494, 2);
            this.label_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(52, 19);
            this.label_fecha.TabIndex = 11;
            this.label_fecha.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.iconButton_Form);
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 27);
            this.panel3.TabIndex = 19;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // iconButton_Form
            // 
            this.iconButton_Form.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_Form.FlatAppearance.BorderSize = 0;
            this.iconButton_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Form.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Form.ForeColor = System.Drawing.Color.White;
            this.iconButton_Form.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton_Form.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton_Form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Form.IconSize = 20;
            this.iconButton_Form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Form.Location = new System.Drawing.Point(0, 0);
            this.iconButton_Form.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton_Form.Name = "iconButton_Form";
            this.iconButton_Form.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton_Form.Size = new System.Drawing.Size(109, 27);
            this.iconButton_Form.TabIndex = 16;
            this.iconButton_Form.Tag = "Inicio";
            this.iconButton_Form.Text = "   Inicio";
            this.iconButton_Form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Form.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Form.UseVisualStyleBackColor = true;
            this.iconButton_Form.Click += new System.EventHandler(this.iconButton_Form_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(673, 3);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(23, 18);
            this.iconButton3.TabIndex = 12;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(695, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(19, 18);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 20;
            this.iconButton4.Location = new System.Drawing.Point(656, 1);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(17, 18);
            this.iconButton4.TabIndex = 13;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.panel_Menu.Controls.Add(this.iconButton7);
            this.panel_Menu.Controls.Add(this.iconButton1);
            this.panel_Menu.Controls.Add(this.iconButton8);
            this.panel_Menu.Controls.Add(this.iconButton6);
            this.panel_Menu.Controls.Add(this.iconButton5);
            this.panel_Menu.Controls.Add(this.panel4);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(230, 661);
            this.panel_Menu.TabIndex = 18;
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 250);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton7.Size = new System.Drawing.Size(230, 60);
            this.iconButton7.TabIndex = 20;
            this.iconButton7.Tag = "Revisión Asignaciones";
            this.iconButton7.Text = "   Revisión Asignaciones";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 190);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(230, 60);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Tag = "Asignar Solicitud";
            this.iconButton1.Text = "   Asignar Solicitud";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.White;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 30;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(0, 619);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton8.Size = new System.Drawing.Size(230, 42);
            this.iconButton8.TabIndex = 18;
            this.iconButton8.Tag = "Salir";
            this.iconButton8.Text = "   Salir";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 130);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton6.Size = new System.Drawing.Size(230, 60);
            this.iconButton6.TabIndex = 16;
            this.iconButton6.Tag = "Soporte Técnico";
            this.iconButton6.Text = "   Soporte Técnico";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 70);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(230, 60);
            this.iconButton5.TabIndex = 15;
            this.iconButton5.Tag = "Agregar Perfil";
            this.iconButton5.Text = "   Agregar Perfil";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_Nombre);
            this.panel4.Controls.Add(this.label_Permisos);
            this.panel4.Controls.Add(this.linkLabel_Perfil);
            this.panel4.Controls.Add(this.iconButton_Menu);
            this.panel4.Controls.Add(this.rjCircularPictureBox_ImagenP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 70);
            this.panel4.TabIndex = 14;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.ForeColor = System.Drawing.Color.White;
            this.label_Nombre.Location = new System.Drawing.Point(76, 27);
            this.label_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(51, 14);
            this.label_Nombre.TabIndex = 7;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Permisos
            // 
            this.label_Permisos.AutoSize = true;
            this.label_Permisos.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Permisos.ForeColor = System.Drawing.Color.White;
            this.label_Permisos.Location = new System.Drawing.Point(76, 7);
            this.label_Permisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Permisos.Name = "label_Permisos";
            this.label_Permisos.Size = new System.Drawing.Size(58, 14);
            this.label_Permisos.TabIndex = 6;
            this.label_Permisos.Text = "Permisos";
            // 
            // linkLabel_Perfil
            // 
            this.linkLabel_Perfil.AutoSize = true;
            this.linkLabel_Perfil.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Perfil.ForeColor = System.Drawing.Color.White;
            this.linkLabel_Perfil.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel_Perfil.Location = new System.Drawing.Point(76, 51);
            this.linkLabel_Perfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Perfil.Name = "linkLabel_Perfil";
            this.linkLabel_Perfil.Size = new System.Drawing.Size(51, 14);
            this.linkLabel_Perfil.TabIndex = 5;
            this.linkLabel_Perfil.TabStop = true;
            this.linkLabel_Perfil.Text = "Mi Perfil";
            this.linkLabel_Perfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // iconButton_Menu
            // 
            this.iconButton_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton_Menu.FlatAppearance.BorderSize = 0;
            this.iconButton_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Menu.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.iconButton_Menu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Menu.IconSize = 30;
            this.iconButton_Menu.Location = new System.Drawing.Point(194, 0);
            this.iconButton_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton_Menu.Name = "iconButton_Menu";
            this.iconButton_Menu.Size = new System.Drawing.Size(36, 70);
            this.iconButton_Menu.TabIndex = 5;
            this.iconButton_Menu.Tag = "iconButton_Menu";
            this.iconButton_Menu.UseVisualStyleBackColor = true;
            this.iconButton_Menu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // rjCircularPictureBox_ImagenP
            // 
            this.rjCircularPictureBox_ImagenP.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox_ImagenP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(89)))));
            this.rjCircularPictureBox_ImagenP.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.rjCircularPictureBox_ImagenP.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox_ImagenP.BorderSize = 2;
            this.rjCircularPictureBox_ImagenP.GradientAngle = 50F;
            this.rjCircularPictureBox_ImagenP.Location = new System.Drawing.Point(0, 3);
            this.rjCircularPictureBox_ImagenP.Margin = new System.Windows.Forms.Padding(2);
            this.rjCircularPictureBox_ImagenP.Name = "rjCircularPictureBox_ImagenP";
            this.rjCircularPictureBox_ImagenP.Size = new System.Drawing.Size(65, 65);
            this.rjCircularPictureBox_ImagenP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox_ImagenP.TabIndex = 5;
            this.rjCircularPictureBox_ImagenP.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel_C.ResumeLayout(false);
            this.panel_C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox_ImagenP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_C;
        private System.Windows.Forms.Label label_Hora;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Permisos;
        private System.Windows.Forms.LinkLabel linkLabel_Perfil;
        private FontAwesome.Sharp.IconButton iconButton_Menu;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox_ImagenP;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton_Form;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label_Bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton iconButton7;
    }
}