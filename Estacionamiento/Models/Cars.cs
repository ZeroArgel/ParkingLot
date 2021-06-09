namespace Estacionamiento.Models
{
    public class Cars
    {
        public Cars(string plate, string carBrand, string model, string color)
        {
            Plate = plate;
            CarBrand = carBrand;
            Model = model;
            Color = color;
        }
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int PayInit { get; } = 12;
        public int ToPay { get; set; }
    }
}