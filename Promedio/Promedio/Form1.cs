using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//int indice = combobox1.SelectedIndex;
//lbl1.Text = indice.ToString();
//

namespace Promedio
{
    public partial class Promedio : Form
    {
        double promedio;
        double Parcial;
        double Guia;
        double Control;

        public Promedio()
        {
            InitializeComponent();
        }

        private void lblLectura_Load(object sender, EventArgs e)
        {
            cbGuia.DataSource = PorGuia();
            cbLectura.DataSource = PorLectura();
            txtResult.Enabled = false;

        }

        public List<string> PorGuia()
        {
            var lista1 = new List<string>() {
                "40%","20%"
            }; return lista1;
        }

        public List<string> PorLectura()
        {
            var lista2 = new List<string>() {
                "20%","0%"
            }; return lista2;
        }

        private void txtParcial_TextChanged(object sender, EventArgs e)
        {
            Parcial = double.Parse(txtParcial.Text) * 0.60;
        }

        private void txtGuia_TextChanged(object sender, EventArgs e)
        {
            

            if (cbGuia.SelectedIndex == 0)
            {
                Guia = double.Parse(txtGuia.Text) * 0.40;
                
            }
            else if (cbGuia.SelectedIndex == 1)
            {
                Guia = double.Parse(txtGuia.Text) * 0.20;
            }
        }

        private void cbGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGuia.SelectedIndex == 0)
            {

                cbLectura.Enabled = false;
                txtLectura.Enabled = false;

            }
            else if (cbGuia.SelectedIndex == 1)
            {
                cbLectura.Enabled = true;
                txtLectura.Enabled = true;

            }
        }

        private void txtLectura_TextChanged(object sender, EventArgs e)
        {
            if (cbLectura.SelectedIndex == 0)
            {
                Control = double.Parse(txtLectura.Text) * 0.20;
            }
            else if (cbLectura.SelectedIndex == 1)
            {
                Control = double.Parse(txtLectura.Text) * 0.0;
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            promedio = Parcial + Guia + Control;
            txtResult.Text = promedio.ToString();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contacto obj = new Contacto();
            obj.Show();
            this.Hide();
        }
    }
}
