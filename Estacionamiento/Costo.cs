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
    public partial class Costo : Form
    {
        /*int horaSalida, Dinero;

        Estacionamiento Parking = new Estacionamiento();

        public int datcobrar()
        {
            return Dinero;
        }*/
    

        public Costo()
        {
            InitializeComponent();

            txtplaca.Enabled = false;
            txtmarca.Enabled = false;
            txtmodelo.Enabled = false;
            txtcolor.Enabled = false;
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           /* DateTime date = new DateTime(1987, 2, 12);
            DateTime Date = DateTime.Now;
            TimeSpan span = Date - date;
            
            Date = Date.AddDays(30d);

            horaSalida = Date.Hour;

            
            if (Hora >= 0) //Si el conductor lleva de 0 a 2 hr. se le cobra 12
            {
                Dinero = 12;
            }

            if (Hora >= 3)//Si el conductor lleva de 3 a 4 hr. se le cobra 20
            {
                Dinero = 20;
            }

            if (Hora >= 5)//Si el conductor lleva de 5 a 6 hr. se le cobra 28
            {
                Dinero = 28;
            }

            if (Hora >= 7)//Si el conductor lleva de 7 a 8 hr. se le cobra 36
            {
                Dinero = 36;
            }

            if (Hora >= 9)//Si el conductor lleva de 9 a 10 hr. se le cobra 44
            {
                Dinero = 44;
            }

            if (Hora >= 11)//Si el conductor lleva de 11 a 12 hr. se le cobra 52
            {
                Dinero = 52;
            }

            if (Hora >= 13)//Si el conductor lleva de 13 a 14 hr. se le cobra 60
            {
                Dinero = 60;
            }

            if (Hora >= 15)//Si el conductor lleva de 15 a 16 hr. se le cobra 68
            {
                Dinero = 68;
            }

            if (Hora >= 17)//Si el conductor lleva de 17 a 18 hr. se le cobra 76
            {
                Dinero = 76;
            }

            if (Hora >= 19)//Si el conductor lleva de 19 a 20 hr. se le cobra 84
            {
                Dinero = 84;
            }

            if (Hora >= 21)//Si el conductor lleva de 21 a 22 hr. se le cobra 92
            {
                Dinero = 92;
            }

            if (Hora >= 23)//Si el conductor lleva de 23 a 24 hr. se le cobra 100
            {
                Dinero = 100;
            }
            Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }
    }
}
