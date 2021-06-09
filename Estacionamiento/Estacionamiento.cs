namespace Estacionamiento
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public partial class Estacionamiento : Form
    {
        /// <summary>
        /// List to save all cars parked in parking lot
        /// </summary>
        private readonly List<Parkings> Parkings;

        /// <summary>
        /// Car parked selected.
        /// </summary>
        private Parkings ParkingSelected { get; set; }
        /// <summary>
        /// Earnings obtained.
        /// </summary>
        private int Earnings { get; set; }
        
        public Estacionamiento()
        {
            InitializeComponent();
            Parkings = new List<Parkings>();
            InitParking();
        }
        #region InitParking
        /// <summary>
        /// Function to init all params.
        /// </summary>
        private void InitParking()
        {
            // Set all param to init 
            Reset();

            // Show in screen our  Muestra en pantalla las earnings
            txtTotal.Text = "0";

            // Se posiciona el cursor en el boton nuevo.
            BtnNew.Focus();
            
            // Desactiva botones, panel, y textbox.
            pnlsalida.Enabled = false;
            txtTotal.Enabled = false;

            // Muestra 1 Columnas
            dgvParking.Columns.Add("Placas", "Placas");
        }
        #endregion        
        #region BtnNew_Click
        /// <summary>
        /// Function to create a new car parked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (Parkings.Count >= 20) throw new ArgumentException("Estacionamiento lleno");

                var alta = new carroAlta();
                BtnNew.Enabled = false;
                dgvParking.Enabled = false;

                alta.ShowDialog();
                if (Parkings.Any(x => x.Car.Plate == alta.Plate)) throw new Exception("Este carro ya esta registrado.");

                dgvParking.Rows.Add(alta.Plate);
                var car = new Cars(alta.Plate, alta.CarBrand, alta.Model, alta.Color);
                Parkings.Add(new Parkings(car, DateTime.UtcNow));
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                BtnNew.Enabled = true;
                dgvParking.Enabled = true;
            }
        }
        #endregion
        #region DgvParking_CellDoubleClick
        /// <summary>
        /// Function to select a car when you make double click in one row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvParking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var hasCar = dgvParking.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (hasCar == null) throw new ArgumentException("No hay carro estacionado ahi");
                ParkingSelected  = Parkings.ElementAt(e.RowIndex);
                ParkingSelected.ParkingLotDateOut = DateTime.UtcNow;
                var hour = ParkingSelected.ParkingLotDateOut.Hour - ParkingSelected.ParkingLotDateIn.Hour;
                var mult = hour == 0
                            ? 0
                            : hour % 2 == 0
                               ? hour / 2
                               : (hour / 2) + 1;

                ParkingSelected.Car.ToPay = ParkingSelected.Car.PayInit + (ParkingSelected.ToPayForHr * mult);
                #region SetValues
                txtplacas2.Text = ParkingSelected.Car.Plate;
                txtmarca2.Text = ParkingSelected.Car.CarBrand;
                txtmodelo2.Text = ParkingSelected.Car.Model;
                txtcolor2.Text = ParkingSelected.Car.Color;
                txtPay.Text = ParkingSelected.Car.ToPay.ToString();
                lblHoraI.Text = ParkingSelected.ParkingLotDateIn.Hour.ToString();
                lblMinI.Text = ParkingSelected.ParkingLotDateIn.Minute.ToString();
                lblSegI.Text = ParkingSelected.ParkingLotDateIn.Second.ToString();
                lblHoraS.Text = ParkingSelected.ParkingLotDateOut.Hour.ToString();
                lblMinS.Text = ParkingSelected.ParkingLotDateOut.Minute.ToString();
                lblSegS.Text = ParkingSelected.ParkingLotDateOut.Second.ToString();
                #endregion
                BtnPay.Focus();
                BtnPay.Enabled = true;
                pnlsalida.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Carro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }
        #endregion
        #region BtnSalir_Click
        /// <summary>
        /// Function to drop one car selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Earnings += ParkingSelected.Car.ToPay;
            txtTotal.Text = Earnings.ToString();

            Parkings.Remove(ParkingSelected);
            dgvParking.Rows.Clear();
            foreach(var parking in Parkings)
            {
                dgvParking.Rows.Add(parking.Car.Plate);
            }
            Reset();
            BtnPay.Enabled = false;
            pnlsalida.Enabled = false;
        }
        #endregion
        #region BtnCancelar_Click
        /// <summary>
        /// Function to close all program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e) => Close();
        #endregion
        #region BtnCancelCarSelect_Click
        /// <summary>
        /// Function to cancel operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelCarSelect_Click(object sender, EventArgs e) => Reset();
        #endregion
        #region Reset
        /// <summary>
        /// Function to reset all params.
        /// </summary>
        private void Reset()
        {
            ParkingSelected = null;
            txtplacas2.Text = "";
            txtmarca2.Text = "";
            txtmodelo2.Text = "";
            txtcolor2.Text = "";
            txtPay.Text = "";
            lblHoraI.Text = "0";
            lblMinI.Text = "0";
            lblSegI.Text = "0";
            lblHoraS.Text = "0";
            lblMinS.Text = "0";
            lblSegS.Text = "0";
        }
        #endregion
    }
}