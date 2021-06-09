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
    public partial class Estacionamiento : Form
    {
        int Total = 0, Ren = 0, Dinero, renglon, HoraS, MinS, SegS, HoraI, MinI, SegI;
        String Placas, Marca, Modelo, Color, Celda;

        public struct Carros
        {
            public string placas;
            public int IT;
	        public int OT; 
            public string marca;
            public string modelo;
            public string color;
            public string horaI;
            public string minI;
            public string segI;
        };

        Carros[] Parking = new Carros[20];

        public Estacionamiento()
        {
            InitializeComponent();
        }


        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(1987, 2, 12);
            DateTime Date = DateTime.Now;
            TimeSpan span = Date - date;
            Date = Date.AddDays(30d);
             
            lblHora.Text = Convert.ToString(Date.Hour);
            lblMinutos.Text = Convert.ToString(Date.Minute);
            lblSegundos.Text = Convert.ToString(Date.Second);
            lblHoraI.Text = Convert.ToString(0);
            lblMinI.Text = Convert.ToString(0);
            lblSegI.Text = Convert.ToString(0);
            lblHoraS.Text = Convert.ToString(0);
            lblMinS.Text = Convert.ToString(0);
            lblSegS.Text = Convert.ToString(0);

            //Muestra en pantalla las ganancias
            txtTotal.Text = Convert.ToString(Total);

            //Se posiciona el cursor en el boton nuevo.
            btnNew.Focus();
            
            //Desactiva botones, panel, y textbox.
            pnlsalida.Enabled = false;
            txtTotal.Enabled = false;

            //Muestra 1 Columnas
            dgvParking.Columns.Add("0", "");//1

            //Muestra 20 renglones 
            dgvParking.Rows.Add(20);
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvParking.Enabled = false;
            btnNew.Enabled = false;
            
            if (Ren < 20)
            {
                carroAlta alta = new carroAlta();
                alta.ShowDialog();

                try
                {
                    DateTime date = new DateTime(1987, 2, 12);
                    DateTime Date = DateTime.Now;
                    TimeSpan span = Date - date;
                    Date = Date.AddDays(30d);

                    Parking[Ren].placas = alta.datplacas();
                    Parking[Ren].marca = alta.datmarca();
                    Parking[Ren].modelo = alta.datmodelo();
                    Parking[Ren].color = alta.datcolor();
                    Parking[Ren].horaI = Convert.ToString(Date.Hour);
                    Parking[Ren].minI = Convert.ToString(Date.Minute);
                    Parking[Ren].segI = Convert.ToString(Date.Second);

                    dgvParking.Rows[Ren].Cells[0].Value = alta.datplacas();
                    
                    Ren++;
                    
                    HoraI = Date.Hour;
                    MinI = Date.Minute;
                    SegI = Date.Second;

                    btnNew.Enabled = true;
                    dgvParking.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos invalidos; Revice bien los datos ingresados", "Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Estacionamiento lleno", "Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvParking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvParking.Rows[e.RowIndex];
                renglon = dgvParking.CurrentCell.ColumnIndex;
                Costo salida = new Costo();

                DateTime date = new DateTime(1987, 2, 12);
                DateTime Date = DateTime.Now;
                TimeSpan span = Date - date;
                Date = Date.AddDays(30d);

                switch (e.RowIndex)
                {
                    case 0:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[0].placas;
                            Marca = Parking[0].marca;
                            Modelo = Parking[0].modelo;
                            Color = Parking[0].color;
                            HoraI = Convert.ToInt32(Parking[0].horaI);
                            MinI = Convert.ToInt32(Parking[0].minI);
                            SegI = Convert.ToInt32(Parking[0].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 1:
                        {

                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[1].placas;
                            Marca = Parking[1].marca;
                            Modelo = Parking[1].modelo;
                            Color = Parking[1].color;
                            HoraI = Convert.ToInt32(Parking[1].horaI);
                            MinI = Convert.ToInt32(Parking[1].minI);
                            SegI = Convert.ToInt32(Parking[1].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 2:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[2].placas;
                            Marca = Parking[2].marca;
                            Modelo = Parking[2].modelo;
                            Color = Parking[2].color;
                            HoraI = Convert.ToInt32(Parking[2].horaI);
                            MinI = Convert.ToInt32(Parking[2].minI);
                            SegI = Convert.ToInt32(Parking[2].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 3:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[3].placas;
                            Marca = Parking[3].marca;
                            Modelo = Parking[3].modelo;
                            Color = Parking[3].color;
                            HoraI = Convert.ToInt32(Parking[3].horaI);
                            MinI = Convert.ToInt32(Parking[3].minI);
                            SegI = Convert.ToInt32(Parking[3].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 4:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[4].placas;
                            Marca = Parking[4].marca;
                            Modelo = Parking[4].modelo;
                            Color = Parking[4].color;
                            HoraI = Convert.ToInt32(Parking[4].horaI);
                            MinI = Convert.ToInt32(Parking[4].minI);
                            SegI = Convert.ToInt32(Parking[4].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 5:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[5].placas;
                            Marca = Parking[5].marca;
                            Modelo = Parking[5].modelo;
                            Color = Parking[5].color;
                            HoraI = Convert.ToInt32(Parking[5].horaI);
                            MinI = Convert.ToInt32(Parking[5].minI);
                            SegI = Convert.ToInt32(Parking[5].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;

                            break;
                        }

                    case 6:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[6].placas;
                            Marca = Parking[6].marca;
                            Modelo = Parking[6].modelo;
                            Color = Parking[6].color;
                            HoraI = Convert.ToInt32(Parking[6].horaI);
                            MinI = Convert.ToInt32(Parking[6].minI);
                            SegI = Convert.ToInt32(Parking[6].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 7:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[7].placas;
                            Marca = Parking[7].marca;
                            Modelo = Parking[7].modelo;
                            Color = Parking[7].color;
                            HoraI = Convert.ToInt32(Parking[7].horaI);
                            MinI = Convert.ToInt32(Parking[7].minI);
                            SegI = Convert.ToInt32(Parking[7].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 8:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[8].placas;
                            Marca = Parking[8].marca;
                            Modelo = Parking[8].modelo;
                            Color = Parking[8].color;
                            HoraI = Convert.ToInt32(Parking[8].horaI);
                            MinI = Convert.ToInt32(Parking[8].minI);
                            SegI = Convert.ToInt32(Parking[8].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 9:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[9].placas;
                            Marca = Parking[9].marca;
                            Modelo = Parking[9].modelo;
                            Color = Parking[9].color;
                            HoraI = Convert.ToInt32(Parking[9].horaI);
                            MinI = Convert.ToInt32(Parking[9].minI);
                            SegI = Convert.ToInt32(Parking[9].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 10:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[10].placas;
                            Marca = Parking[10].marca;
                            Modelo = Parking[10].modelo;
                            Color = Parking[10].color;
                            HoraI = Convert.ToInt32(Parking[10].horaI);
                            MinI = Convert.ToInt32(Parking[10].minI);
                            SegI = Convert.ToInt32(Parking[10].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 11:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[11].placas;
                            Marca = Parking[11].marca;
                            Modelo = Parking[11].modelo;
                            Color = Parking[11].color;
                            HoraI = Convert.ToInt32(Parking[11].horaI);
                            MinI = Convert.ToInt32(Parking[11].minI);
                            SegI = Convert.ToInt32(Parking[11].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }
                    case 12:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[12].placas;
                            Marca = Parking[12].marca;
                            Modelo = Parking[12].modelo;
                            Color = Parking[12].color;
                            HoraI = Convert.ToInt32(Parking[12].horaI);
                            MinI = Convert.ToInt32(Parking[12].minI);
                            SegI = Convert.ToInt32(Parking[12].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }
                    case 13:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[13].placas;
                            Marca = Parking[13].marca;
                            Modelo = Parking[13].modelo;
                            Color = Parking[13].color;
                            HoraI = Convert.ToInt32(Parking[13].horaI);
                            MinI = Convert.ToInt32(Parking[13].minI);
                            SegI = Convert.ToInt32(Parking[13].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 14:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[14].placas;
                            Marca = Parking[14].marca;
                            Modelo = Parking[14].modelo;
                            Color = Parking[14].color; 
                            HoraI = Convert.ToInt32(Parking[14].horaI);
                            MinI = Convert.ToInt32(Parking[14].minI);
                            SegI = Convert.ToInt32(Parking[14].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 15:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[15].placas;
                            Marca = Parking[15].marca;
                            Modelo = Parking[15].modelo;
                            Color = Parking[15].color;
                            HoraI = Convert.ToInt32(Parking[15].horaI);
                            MinI = Convert.ToInt32(Parking[15].minI);
                            SegI = Convert.ToInt32(Parking[15].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 16:
                        {

                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[16].placas;
                            Marca = Parking[16].marca;
                            Modelo = Parking[16].modelo;
                            Color = Parking[16].color;
                            HoraI = Convert.ToInt32(Parking[16].horaI);
                            MinI = Convert.ToInt32(Parking[16].minI);
                            SegI = Convert.ToInt32(Parking[16].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 17:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[17].placas;
                            Marca = Parking[17].marca;
                            Modelo = Parking[17].modelo;
                            Color = Parking[17].color;
                            HoraI = Convert.ToInt32(Parking[17].horaI);
                            MinI = Convert.ToInt32(Parking[17].minI);
                            SegI = Convert.ToInt32(Parking[17].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 18:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[18].placas;
                            Marca = Parking[18].marca;
                            Modelo = Parking[18].modelo;
                            Color = Parking[18].color;
                            HoraI = Convert.ToInt32(Parking[18].horaI);
                            MinI = Convert.ToInt32(Parking[18].minI);
                            SegI = Convert.ToInt32(Parking[18].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;
                            
                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }

                    case 19:
                        {
                            Celda = row.Cells[0].Value.ToString();

                            Placas = Parking[19].placas;
                            Marca = Parking[19].marca;
                            Modelo = Parking[19].modelo;
                            Color = Parking[19].color;
                            HoraI = Convert.ToInt32(Parking[19].horaI);
                            MinI = Convert.ToInt32(Parking[19].minI);
                            SegI = Convert.ToInt32(Parking[19].segI);
                            HoraS = Date.Hour;
                            MinS = Date.Minute;
                            SegS = Date.Second;

                            btnSalir.Focus();
                            btnSalir.Enabled = true;
                            pnlsalida.Enabled = true;
                            break;
                        }
                }

            }
            catch (Exception )
            {
                MessageBox.Show("No hay carro estacionado ahi", "Carro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {   
                int Hora = HoraS - HoraI;

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

                Total = Total + Dinero;
                txtTotal.Text = Convert.ToString(Total);

                Placas = "";
                Marca = "";
                Modelo = "";
                Color = "";
                HoraI = 0;
                MinI = 0;
                SegI = 0;
                HoraS = 0;
                MinS = 0;
                SegS = 0;


                renglon = dgvParking.CurrentRow.Index;

                for (int z = renglon; z < 19; z++)
                {
                    Parking[z].placas = Parking[z + 1].placas;
                    Parking[z].marca = Parking[z + 1].marca;
                    Parking[z].modelo = Parking[z + 1].modelo;
                    Parking[z].color = Parking[z + 1].color;
                    dgvParking.Rows[z].Cells[0].Value = Parking[z].placas;
                }

                Ren--;
                
                if (Ren == 19)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (dgvParking.Rows[i].Cells[0].Equals(""))
                        {
                            Ren--;
                        }
                    }
                }


                btnSalir.Enabled = false;
                pnlsalida.Enabled = false;
            }
            catch (Exception )
            {
                MessageBox.Show("Este carro ya pago", "Carro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlsalida_Paint(object sender, PaintEventArgs e)
        {   
            txtplacas2.Text = Placas;
            txtmarca2.Text = Marca;
            txtmodelo2.Text = Modelo;
            txtcolor2.Text = Color;
            lblHoraI.Text = Convert.ToString(HoraI);
            lblMinI.Text = Convert.ToString(MinI);
            lblSegI.Text = Convert.ToString(SegI);
            lblHoraS.Text = Convert.ToString(HoraS);
            lblMinS.Text = Convert.ToString(MinS);
            lblSegS.Text = Convert.ToString(SegS);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
