using System;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Register : Form
    {
        /// <summary>
        /// Variable to save plate of car.
        /// </summary>
        internal string Plate { get; set; }
        /// <summary>
        /// Variable to save model of car.
        /// </summary>
        internal string Model { get; set; }
        /// <summary>
        /// Variable to save brand of car.
        /// </summary>
        internal string CarBrand { get; set; }
        /// <summary>
        /// Variable to save color of car.
        /// </summary>
        internal string Color { get; set; }

        public Register() => InitializeComponent();

        #region BtnSave_Click
        /// <summary>
        /// Function to save car in parking lot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Plate = TxtPlate.Text;
            Model = TxtModel.Text;
            CarBrand = TxtCarBrand.Text;
            Color = TxtColor.Text;

            TxtPlate.Clear();
            TxtModel.Clear();
            TxtCarBrand.Clear();
            TxtColor.Clear();

            Close();
        }
        #endregion
    }
}