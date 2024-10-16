using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    public partial class Form1 : Form
    {
        double promedio, parcial, guia, lectura;
        //double porcetGuia, porcentLectura;
        string alumno, estado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPorcentGuia.DataSource = listaGuia();
            cmbPorcentLectura.DataSource = listaLectura();

            if(cmbPorcentGuia.SelectedIndex == 0)
            {
                txtNotaLectura.Enabled = false;
                cmbPorcentLectura.SelectedIndex = 1;
                cmbPorcentLectura.Enabled = false;
            }
        }

        private void btnCalcularProm_Click(object sender, EventArgs e)
        {
            alumno = txtNomAlumno.Text;
            parcial = double.Parse(txtNotaParcial.Text);
            guia = double.Parse(txtNotaGuia.Text);

            if(cmbPorcentGuia.SelectedIndex == 0)
            {
                promedio = parcial * 0.6 + guia * 0.4;
                EstadoAlumno();
                MessageBox.Show(alumno + "\nNota Final: " + promedio.ToString() + "\nResultado: " + estado, "Promedio del Alumno");
            }
            else
            {
                lectura = double.Parse(txtNotaLectura.Text);
                promedio = (parcial * 0.6) + guia * 0.2 + lectura * 0.2;
                EstadoAlumno();
                MessageBox.Show(alumno + "\nNota Final: " + promedio.ToString() + "\nResultado: " + estado, "Promedio del Alumno");
            }
        }

        public List<string> listaGuia()
        {
            var porcentajes = new List<string>() {
                "40%","20%"
            }; 
            return porcentajes;
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            Contacto obj = new Contacto();
            obj.Show();
            this.Hide();
        }

        public List<string> listaLectura()
        {
            var porcentajes = new List<string>() {
                "20%","0%"
            }; 
            return porcentajes;
        }

        private void cmbPorcentGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPorcentGuia.SelectedIndex == 1)
            {
                txtNotaLectura.Enabled = true;
                cmbPorcentLectura.SelectedIndex = 0;
                cmbPorcentLectura.Enabled = true;
            }
            else
            {
                txtNotaLectura.Enabled = false;
                cmbPorcentLectura.SelectedIndex = 1;
                cmbPorcentLectura.Enabled = false;
            }
        }

        private void EstadoAlumno()
        {
            if (promedio > 6)
            {
                estado = "APROBADO";
            }
            else
            {
                estado = "REPROBADO";
            }
        }

        private void cmbPorcentLectura_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
