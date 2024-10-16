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
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void Contacto_Load(object sender, EventArgs e)
        {

        }

        public List<string> PorGuia()
        {
            var lista1 = new List<string>() {
                "40%","20%"
            }; return lista1;
        }

        private void lblNombre1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre4_Click(object sender, EventArgs e)
        {

        }
    }
}
