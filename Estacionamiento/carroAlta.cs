using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class carroAlta : Form
    {
        String Placas, Modelo, Marca, Color;

        public string datplacas()
        {
            return Placas;
        }

        public string datmodelo()
        {
            return Modelo;
        }

        public string datmarca()
        {
            return Marca;
        }
        public string datcolor()
        {
            return Color;
        }


        public carroAlta()
        {
            InitializeComponent();
        }

        private void carroAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Placas = txtplacas.Text;
            Modelo = txtmodelo.Text;
            Marca = txtmarca.Text;
            Color = txtcolor.Text;

            txtplacas.Clear();
            txtmodelo.Clear();
            txtmarca.Clear();
            txtcolor.Clear();

            Close();
        }
    }
}
