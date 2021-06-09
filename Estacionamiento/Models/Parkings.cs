namespace Estacionamiento.Models
{
    using System;
    public class Parkings
    {
        public Parkings(Cars car, DateTimeOffset parkingLotDateIn)
        {
            Car = car;
            ParkingLotDateIn = parkingLotDateIn;
        }
        /// <summary>
        /// Save that car is parked.
        /// </summary>
        public Cars Car { get; set; }
        /// <summary>
        /// Save date in.
        /// </summary>
        public DateTimeOffset ParkingLotDateIn { get; set; }
        /// <summary>
        /// Save date out
        /// </summary>
        public DateTimeOffset ParkingLotDateOut { get; set; }
        /// <summary>
        /// Save how much pay for each hour.
        /// </summary>
        public int ToPayForHr { get; } = 8;
    }
}