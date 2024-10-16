namespace Promedio
{
    partial class Promedio
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
            System.Windows.Forms.Button btnContact;
            this.lblName = new System.Windows.Forms.Label();
            this.lblParcial = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.lblLectura = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lbl60 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.cbGuia = new System.Windows.Forms.ComboBox();
            this.cbLectura = new System.Windows.Forms.ComboBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContact
            // 
            btnContact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnContact.Location = new System.Drawing.Point(827, 351);
            btnContact.Name = "btnContact";
            btnContact.Size = new System.Drawing.Size(150, 39);
            btnContact.TabIndex = 13;
            btnContact.Text = "CONTACTO";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "ESTUDIANTE:";
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.Location = new System.Drawing.Point(97, 112);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(105, 31);
            this.lblParcial.TabIndex = 1;
            this.lblParcial.Text = "Parcial:";
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuia.Location = new System.Drawing.Point(97, 181);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(89, 31);
            this.lblGuia.TabIndex = 2;
            this.lblGuia.Text = "GUIA:";
            // 
            // lblLectura
            // 
            this.lblLectura.AutoSize = true;
            this.lblLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectura.Location = new System.Drawing.Point(11, 257);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(336, 31);
            this.lblLectura.TabIndex = 3;
            this.lblLectura.Text = "CONTROL DE LECTURA:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(781, 40);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(224, 31);
            this.lblPorcentaje.TabIndex = 4;
            this.lblPorcentaje.Text = "PORCENTAJES:";
            // 
            // lbl60
            // 
            this.lbl60.AutoSize = true;
            this.lbl60.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl60.Location = new System.Drawing.Point(849, 100);
            this.lbl60.Name = "lbl60";
            this.lbl60.Size = new System.Drawing.Size(68, 31);
            this.lbl60.TabIndex = 5;
            this.lbl60.Text = "60%";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Location = new System.Drawing.Point(381, 36);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(312, 35);
            this.txtEstudiante.TabIndex = 6;
            // 
            // txtParcial
            // 
            this.txtParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcial.Location = new System.Drawing.Point(381, 112);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(312, 35);
            this.txtParcial.TabIndex = 7;
            this.txtParcial.TextChanged += new System.EventHandler(this.txtParcial_TextChanged);
            // 
            // txtGuia
            // 
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuia.Location = new System.Drawing.Point(381, 181);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(312, 35);
            this.txtGuia.TabIndex = 8;
            this.txtGuia.TextChanged += new System.EventHandler(this.txtGuia_TextChanged);
            // 
            // txtLectura
            // 
            this.txtLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectura.Location = new System.Drawing.Point(381, 253);
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(312, 35);
            this.txtLectura.TabIndex = 9;
            this.txtLectura.TextChanged += new System.EventHandler(this.txtLectura_TextChanged);
            // 
            // cbGuia
            // 
            this.cbGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuia.FormattingEnabled = true;
            this.cbGuia.Location = new System.Drawing.Point(787, 190);
            this.cbGuia.Name = "cbGuia";
            this.cbGuia.Size = new System.Drawing.Size(218, 33);
            this.cbGuia.TabIndex = 10;
            this.cbGuia.SelectedIndexChanged += new System.EventHandler(this.cbGuia_SelectedIndexChanged);
            // 
            // cbLectura
            // 
            this.cbLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLectura.FormattingEnabled = true;
            this.cbLectura.Location = new System.Drawing.Point(787, 256);
            this.cbLectura.Name = "cbLectura";
            this.cbLectura.Size = new System.Drawing.Size(218, 33);
            this.cbLectura.TabIndex = 11;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedio.Location = new System.Drawing.Point(405, 351);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(251, 59);
            this.btnPromedio.TabIndex = 12;
            this.btnPromedio.Text = "CALCULAR EL PROMEDIO";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(45, 378);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(184, 35);
            this.txtResult.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "RESULTADO:";
            // 
            // Promedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(btnContact);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.cbLectura);
            this.Controls.Add(this.cbGuia);
            this.Controls.Add(this.txtLectura);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.lbl60);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblLectura);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.lblName);
            this.Name = "Promedio";
            this.Text = "Promedios";
            this.Load += new System.EventHandler(this.lblLectura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lbl60;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.ComboBox cbGuia;
        private System.Windows.Forms.ComboBox cbLectura;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

