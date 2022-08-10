namespace Presentacion
{
    partial class Login
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
            this.rjTextBox_Usuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_Error = new System.Windows.Forms.Label();
            this.iconButton_Error = new FontAwesome.Sharp.IconButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rjTextBox_Contrasenia = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjTextBox_Usuario
            // 
            this.rjTextBox_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(167)))), ((int)(((byte)(242)))));
            this.rjTextBox_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjTextBox_Usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.rjTextBox_Usuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.rjTextBox_Usuario.BorderRadius = 5;
            this.rjTextBox_Usuario.BorderSize = 2;
            this.rjTextBox_Usuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Usuario.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox_Usuario.Location = new System.Drawing.Point(27, 125);
            this.rjTextBox_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Usuario.Multiline = false;
            this.rjTextBox_Usuario.Name = "rjTextBox_Usuario";
            this.rjTextBox_Usuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Usuario.PasswordChar = false;
            this.rjTextBox_Usuario.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.rjTextBox_Usuario.PlaceholderText = "email@gmail.com";
            this.rjTextBox_Usuario.Size = new System.Drawing.Size(264, 34);
            this.rjTextBox_Usuario.TabIndex = 0;
            this.rjTextBox_Usuario.Texts = "";
            this.rjTextBox_Usuario.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label_Error);
            this.panel1.Controls.Add(this.iconButton_Error);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rjTextBox_Contrasenia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjTextBox_Usuario);
            this.panel1.Location = new System.Drawing.Point(195, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 420);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(66, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(184, 19);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Black;
            this.label_Error.Location = new System.Drawing.Point(65, 252);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(33, 14);
            this.label_Error.TabIndex = 10;
            this.label_Error.Text = "Error";
            this.label_Error.Visible = false;
            // 
            // iconButton_Error
            // 
            this.iconButton_Error.FlatAppearance.BorderSize = 0;
            this.iconButton_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Error.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconButton_Error.IconColor = System.Drawing.Color.Red;
            this.iconButton_Error.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Error.IconSize = 25;
            this.iconButton_Error.Location = new System.Drawing.Point(27, 250);
            this.iconButton_Error.Name = "iconButton_Error";
            this.iconButton_Error.Size = new System.Drawing.Size(37, 25);
            this.iconButton_Error.TabIndex = 9;
            this.iconButton_Error.UseVisualStyleBackColor = true;
            this.iconButton_Error.Visible = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(17, 337);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(286, 40);
            this.rjButton1.TabIndex = 8;
            this.rjButton1.Text = "Ingresar";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Precentacion.Properties.Resources.key_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox2.Location = new System.Drawing.Point(27, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // rjTextBox_Contrasenia
            // 
            this.rjTextBox_Contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(167)))), ((int)(((byte)(242)))));
            this.rjTextBox_Contrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjTextBox_Contrasenia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.rjTextBox_Contrasenia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.rjTextBox_Contrasenia.BorderRadius = 5;
            this.rjTextBox_Contrasenia.BorderSize = 2;
            this.rjTextBox_Contrasenia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox_Contrasenia.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox_Contrasenia.Location = new System.Drawing.Point(27, 204);
            this.rjTextBox_Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox_Contrasenia.Multiline = false;
            this.rjTextBox_Contrasenia.Name = "rjTextBox_Contrasenia";
            this.rjTextBox_Contrasenia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox_Contrasenia.PasswordChar = true;
            this.rjTextBox_Contrasenia.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.rjTextBox_Contrasenia.PlaceholderText = "Contraseña";
            this.rjTextBox_Contrasenia.Size = new System.Drawing.Size(264, 34);
            this.rjTextBox_Contrasenia.TabIndex = 4;
            this.rjTextBox_Contrasenia.Texts = "";
            this.rjTextBox_Contrasenia.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Precentacion.Properties.Resources.person_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox1.Location = new System.Drawing.Point(27, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesion";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(141)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(663, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 25);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(700, 538);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox_Contrasenia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label_Error;
        private FontAwesome.Sharp.IconButton iconButton_Error;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

