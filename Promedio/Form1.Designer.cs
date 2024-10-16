namespace Promedio
{
    partial class Form1
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnContacto = new System.Windows.Forms.Button();
            this.btnCalcularProm = new System.Windows.Forms.Button();
            this.cmbPorcentLectura = new System.Windows.Forms.ComboBox();
            this.cmbPorcentGuia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotaLectura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaGuia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotaParcial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMensaje.Location = new System.Drawing.Point(163, 211);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 15);
            this.lblMensaje.TabIndex = 29;
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(491, 280);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(94, 22);
            this.btnContacto.TabIndex = 28;
            this.btnContacto.Text = "CONTACTO";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // btnCalcularProm
            // 
            this.btnCalcularProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularProm.Location = new System.Drawing.Point(166, 242);
            this.btnCalcularProm.Name = "btnCalcularProm";
            this.btnCalcularProm.Size = new System.Drawing.Size(248, 33);
            this.btnCalcularProm.TabIndex = 27;
            this.btnCalcularProm.Text = "CALCULAR PROMEDIO";
            this.btnCalcularProm.UseVisualStyleBackColor = true;
            this.btnCalcularProm.Click += new System.EventHandler(this.btnCalcularProm_Click);
            // 
            // cmbPorcentLectura
            // 
            this.cmbPorcentLectura.FormattingEnabled = true;
            this.cmbPorcentLectura.Location = new System.Drawing.Point(452, 178);
            this.cmbPorcentLectura.Name = "cmbPorcentLectura";
            this.cmbPorcentLectura.Size = new System.Drawing.Size(121, 21);
            this.cmbPorcentLectura.TabIndex = 26;
            this.cmbPorcentLectura.SelectedIndexChanged += new System.EventHandler(this.cmbPorcentLectura_SelectedIndexChanged);
            // 
            // cmbPorcentGuia
            // 
            this.cmbPorcentGuia.FormattingEnabled = true;
            this.cmbPorcentGuia.Location = new System.Drawing.Point(452, 127);
            this.cmbPorcentGuia.Name = "cmbPorcentGuia";
            this.cmbPorcentGuia.Size = new System.Drawing.Size(121, 21);
            this.cmbPorcentGuia.TabIndex = 25;
            this.cmbPorcentGuia.SelectedIndexChanged += new System.EventHandler(this.cmbPorcentGuia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "60%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "PORCENTAJES:";
            // 
            // txtNotaLectura
            // 
            this.txtNotaLectura.Location = new System.Drawing.Point(166, 178);
            this.txtNotaLectura.Name = "txtNotaLectura";
            this.txtNotaLectura.Size = new System.Drawing.Size(248, 20);
            this.txtNotaLectura.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CONTROL DE LECTURA";
            // 
            // txtNotaGuia
            // 
            this.txtNotaGuia.Location = new System.Drawing.Point(166, 127);
            this.txtNotaGuia.Name = "txtNotaGuia";
            this.txtNotaGuia.Size = new System.Drawing.Size(248, 20);
            this.txtNotaGuia.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "GUIA";
            // 
            // txtNotaParcial
            // 
            this.txtNotaParcial.Location = new System.Drawing.Point(166, 78);
            this.txtNotaParcial.Name = "txtNotaParcial";
            this.txtNotaParcial.Size = new System.Drawing.Size(248, 20);
            this.txtNotaParcial.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "PARCIAL";
            // 
            // txtNomAlumno
            // 
            this.txtNomAlumno.Location = new System.Drawing.Point(166, 28);
            this.txtNomAlumno.Name = "txtNomAlumno";
            this.txtNomAlumno.Size = new System.Drawing.Size(248, 20);
            this.txtNomAlumno.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOMBRE ALUMNO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 318);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.btnCalcularProm);
            this.Controls.Add(this.cmbPorcentLectura);
            this.Controls.Add(this.cmbPorcentGuia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotaLectura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotaGuia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaParcial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guia #3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.Button btnCalcularProm;
        private System.Windows.Forms.ComboBox cmbPorcentLectura;
        private System.Windows.Forms.ComboBox cmbPorcentGuia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotaLectura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaGuia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaParcial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomAlumno;
        private System.Windows.Forms.Label label1;
    }
}

