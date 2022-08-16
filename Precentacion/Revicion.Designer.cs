namespace Precentacion
{
    partial class Revicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Realizadas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.label_Descripcion = new System.Windows.Forms.Label();
            this.label_Requisitos = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Realizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes Realizadas";
            // 
            // dataGridView_Realizadas
            // 
            this.dataGridView_Realizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Realizadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Realizadas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Realizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Realizadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Realizadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Realizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Realizadas.ColumnHeadersHeight = 30;
            this.dataGridView_Realizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Realizadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Realizadas.EnableHeadersVisualStyles = false;
            this.dataGridView_Realizadas.Location = new System.Drawing.Point(17, 48);
            this.dataGridView_Realizadas.Name = "dataGridView_Realizadas";
            this.dataGridView_Realizadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Realizadas.Size = new System.Drawing.Size(401, 418);
            this.dataGridView_Realizadas.TabIndex = 9;
            this.dataGridView_Realizadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Realizadas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Solicitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha Envio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Requisitos del técnico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Asignar un total a pagar de la solicitud";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(491, 392);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 16;
            this.textBox_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Total_KeyPress);
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
            this.rjButton1.Location = new System.Drawing.Point(597, 386);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(73, 26);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.Text = "Enviar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label_Descripcion
            // 
            this.label_Descripcion.AutoSize = true;
            this.label_Descripcion.Location = new System.Drawing.Point(441, 106);
            this.label_Descripcion.Name = "label_Descripcion";
            this.label_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_Descripcion.TabIndex = 18;
            this.label_Descripcion.Text = "Descripcion";
            // 
            // label_Requisitos
            // 
            this.label_Requisitos.AutoSize = true;
            this.label_Requisitos.Location = new System.Drawing.Point(441, 240);
            this.label_Requisitos.Name = "label_Requisitos";
            this.label_Requisitos.Size = new System.Drawing.Size(56, 13);
            this.label_Requisitos.TabIndex = 19;
            this.label_Requisitos.Text = "Requisitos";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(542, 54);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 20;
            this.Fecha.Text = "Fecha";
            // 
            // Revicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 478);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label_Requisitos);
            this.Controls.Add(this.label_Descripcion);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_Realizadas);
            this.Controls.Add(this.label1);
            this.Name = "Revicion";
            this.Text = "Revicion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Realizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Realizadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Total;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label_Descripcion;
        private System.Windows.Forms.Label label_Requisitos;
        private System.Windows.Forms.Label Fecha;
    }
}