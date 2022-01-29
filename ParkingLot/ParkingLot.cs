using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ParkingLot.Models;
using ZAExtensions;

namespace ParkingLot
{
    public partial class ParkingLot : Form
    {
        /// <summary>
        /// List to save all cars parked in parking lot
        /// </summary>
        private readonly List<ParkingLots> _parkingLots;

        /// <summary>
        /// Car parked selected.
        /// </summary>
        private ParkingLots ParkingLotSelected { get; set; }

        /// <summary>
        /// Earnings obtained.
        /// </summary>
        private int Earnings { get; set; }

        private int MaxPlaceParking = 20;
        
        public ParkingLot()
        {
            InitializeComponent();

            // Set parking
            _parkingLots = new List<ParkingLots>();

            // Set all param to init 
            Reset();

            // Show in screen our  Muestra en pantalla las earnings
            TxtTotal.Text = @"0";

            // Se posiciona el cursor en el boton nuevo.
            BtnNew.Focus();

            // Desactiva botones, panel, y textbox.
            PnlExit.Enabled = false;
            TxtTotal.Enabled = false;

            // Muestra 1 Columnas
            DgvParking.Columns.Add("Placas", "Placas");
        }
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
                if (_parkingLots.Count >= MaxPlaceParking) throw new ArgumentException("Estacionamiento lleno");

                var register = new Register();
                BtnNew.Enabled = false;
                DgvParking.Enabled = false;

                register.ShowDialog();

                // Valid if register screen only closed.
                if (register.Plate.IsEmpty() && register.Color.IsEmpty() && register.CarBrand.IsEmpty() && register.Model.IsEmpty()) return;

                if (_parkingLots.Any(x => x.Car.Plate == register.Plate)) throw new Exception("Este carro ya esta registrado.");

                var car = new Cars(register.Plate, register.CarBrand, register.Model, register.Color);
                _parkingLots.Add(new ParkingLots(car, DateTime.UtcNow));
                DgvParking.Rows.Add(register.Plate);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                BtnNew.Enabled = true;
                DgvParking.Enabled = true;
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
                var hasCar = DgvParking.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (hasCar.IsEmpty()) throw new ArgumentException("No hay carro estacionado ahi");
                ParkingLotSelected  = _parkingLots.ElementAt(e.RowIndex);
                ParkingLotSelected.ParkingLotDateOut = DateTime.UtcNow;
                var hour = ParkingLotSelected.ParkingLotDateOut.Hour - ParkingLotSelected.ParkingLotDateIn.Hour;
                var multiple = hour == 0
                            ? 0
                            : hour % 2 == 0
                               ? hour / 2
                               : hour / 2 + 1;

                ParkingLotSelected.Car.ToPay = ParkingLotSelected.Car.PayInit + (ParkingLotSelected.ToPayForHr * multiple);
                #region SetValues
                txtplacas2.Text = ParkingLotSelected.Car.Plate;
                txtmarca2.Text = ParkingLotSelected.Car.CarBrand;
                txtmodelo2.Text = ParkingLotSelected.Car.Model;
                txtcolor2.Text = ParkingLotSelected.Car.Color;
                txtPay.Text = ParkingLotSelected.Car.ToPay.ToString();
                lblHoraI.Text = ParkingLotSelected.ParkingLotDateIn.Hour.ToString();
                lblMinI.Text = ParkingLotSelected.ParkingLotDateIn.Minute.ToString();
                lblSegI.Text = ParkingLotSelected.ParkingLotDateIn.Second.ToString();
                lblHoraS.Text = ParkingLotSelected.ParkingLotDateOut.Hour.ToString();
                lblMinS.Text = ParkingLotSelected.ParkingLotDateOut.Minute.ToString();
                lblSegS.Text = ParkingLotSelected.ParkingLotDateOut.Second.ToString();
                #endregion
                BtnPay.Focus();
                BtnPay.Enabled = true;
                PnlExit.Enabled = true;
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
        private void BtnPay_Click(object sender, EventArgs e)
        {
            Earnings += ParkingLotSelected.Car.ToPay;
            TxtTotal.Text = Earnings.ToString();

            _parkingLots.Remove(ParkingLotSelected);
            DgvParking.Rows.Clear();
            foreach(var parking in _parkingLots)
            {
                DgvParking.Rows.Add(parking.Car.Plate);
            }
            Reset();
            BtnPay.Enabled = false;
            PnlExit.Enabled = false;
        }
        #endregion
        #region BtnCancelar_Click
        /// <summary>
        /// Function to close all program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e) => Close();
        #endregion
        #region BtnCancelCarSelect_Click
        /// <summary>
        /// Function to cancel operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelCarSelected_Click(object sender, EventArgs e) => Reset();
        #endregion
        #region Reset
        /// <summary>
        /// Function to reset all params.
        /// </summary>
        private void Reset()
        {
            ParkingLotSelected = null;
            txtplacas2.Text = "";
            txtmarca2.Text = "";
            txtmodelo2.Text = "";
            txtcolor2.Text = "";
            txtPay.Text = "";
            lblHoraI.Text = @"0";
            lblMinI.Text = @"0";
            lblSegI.Text = @"0";
            lblHoraS.Text = @"0";
            lblMinS.Text = @"0";
            lblSegS.Text = @"0";
        }
        #endregion
    }
}