namespace Precentacion
{
    partial class Asignacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Solicitudes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.dataGridView_Tecnicos = new System.Windows.Forms.DataGridView();
            this.dataGridView_Asignadas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Tecnico = new System.Windows.Forms.Label();
            this.dataGridView_SolicitudesTec = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Solicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tecnicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SolicitudesTec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes pendientes";
            // 
            // dataGridView_Solicitudes
            // 
            this.dataGridView_Solicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Solicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Solicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Solicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Solicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Solicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Solicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Solicitudes.ColumnHeadersHeight = 30;
            this.dataGridView_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Solicitudes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Solicitudes.EnableHeadersVisualStyles = false;
            this.dataGridView_Solicitudes.Location = new System.Drawing.Point(359, 37);
            this.dataGridView_Solicitudes.Name = "dataGridView_Solicitudes";
            this.dataGridView_Solicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Solicitudes.Size = new System.Drawing.Size(438, 175);
            this.dataGridView_Solicitudes.TabIndex = 2;
            this.dataGridView_Solicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Solicitudes_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asignar a:";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(679, 395);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(139, 35);
            this.rjButton1.TabIndex = 5;
            this.rjButton1.Text = "Aceptar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Cedula.Location = new System.Drawing.Point(126, 9);
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(210, 20);
            this.textBox_Cedula.TabIndex = 7;
            // 
            // dataGridView_Tecnicos
            // 
            this.dataGridView_Tecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Tecnicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Tecnicos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Tecnicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Tecnicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Tecnicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Tecnicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Tecnicos.ColumnHeadersHeight = 30;
            this.dataGridView_Tecnicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Tecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Tecnicos.EnableHeadersVisualStyles = false;
            this.dataGridView_Tecnicos.Location = new System.Drawing.Point(12, 37);
            this.dataGridView_Tecnicos.Name = "dataGridView_Tecnicos";
            this.dataGridView_Tecnicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Tecnicos.Size = new System.Drawing.Size(324, 175);
            this.dataGridView_Tecnicos.TabIndex = 8;
            this.dataGridView_Tecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tecnicos_CellClick);
            // 
            // dataGridView_Asignadas
            // 
            this.dataGridView_Asignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Asignadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Asignadas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Asignadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Asignadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Asignadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Asignadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Asignadas.ColumnHeadersHeight = 30;
            this.dataGridView_Asignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Asignadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Asignadas.EnableHeadersVisualStyles = false;
            this.dataGridView_Asignadas.Location = new System.Drawing.Point(359, 249);
            this.dataGridView_Asignadas.Name = "dataGridView_Asignadas";
            this.dataGridView_Asignadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Asignadas.Size = new System.Drawing.Size(302, 175);
            this.dataGridView_Asignadas.TabIndex = 10;
            this.dataGridView_Asignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Asignadas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Solicitudes Asignadas a:";
            // 
            // label_Tecnico
            // 
            this.label_Tecnico.AutoSize = true;
            this.label_Tecnico.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tecnico.Location = new System.Drawing.Point(597, 227);
            this.label_Tecnico.Name = "label_Tecnico";
            this.label_Tecnico.Size = new System.Drawing.Size(64, 19);
            this.label_Tecnico.TabIndex = 11;
            this.label_Tecnico.Text = "Tecnico";
            // 
            // dataGridView_SolicitudesTec
            // 
            this.dataGridView_SolicitudesTec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_SolicitudesTec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SolicitudesTec.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SolicitudesTec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_SolicitudesTec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_SolicitudesTec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SolicitudesTec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_SolicitudesTec.ColumnHeadersHeight = 30;
            this.dataGridView_SolicitudesTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_SolicitudesTec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_SolicitudesTec.EnableHeadersVisualStyles = false;
            this.dataGridView_SolicitudesTec.Location = new System.Drawing.Point(17, 249);
            this.dataGridView_SolicitudesTec.Name = "dataGridView_SolicitudesTec";
            this.dataGridView_SolicitudesTec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_SolicitudesTec.Size = new System.Drawing.Size(324, 181);
            this.dataGridView_SolicitudesTec.TabIndex = 12;
            this.dataGridView_SolicitudesTec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SolicitudesTec_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Solicitudes del tecnico seleccionado";
            // 
            // Asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_SolicitudesTec);
            this.Controls.Add(this.label_Tecnico);
            this.Controls.Add(this.dataGridView_Asignadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Tecnicos);
            this.Controls.Add(this.textBox_Cedula);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Solicitudes);
            this.Controls.Add(this.label1);
            this.Name = "Asignacion";
            this.Text = "Asignacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Solicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tecnicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Asignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SolicitudesTec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Solicitudes;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.DataGridView dataGridView_Tecnicos;
        private System.Windows.Forms.DataGridView dataGridView_Asignadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Tecnico;
        private System.Windows.Forms.DataGridView dataGridView_SolicitudesTec;
        private System.Windows.Forms.Label label4;
    }
}