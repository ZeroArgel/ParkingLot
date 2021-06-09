namespace Estacionamiento
{
    using System;
    using System.Windows.Forms;
    public partial class carroAlta : Form
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

        public carroAlta() => InitializeComponent();

        #region BtnSave_Click
        /// <summary>
        /// Function to save car in parking lot.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Plate = txtPlate.Text;
            Model = txtModel.Text;
            CarBrand = txtCarBrand.Text;
            Color = txtColor.Text;

            txtPlate.Clear();
            txtModel.Clear();
            txtCarBrand.Clear();
            txtColor.Clear();

            Close();
        }
        #endregion
    }
}