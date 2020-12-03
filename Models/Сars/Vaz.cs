namespace Leson3M2.Models.Сars
{
    using Leson3M2.Enums;

    /// <summary>
    /// VAZ.
    /// </summary>
    public class Vaz : PassengerTaxi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vaz"/> class.
        /// </summary>
        /// <param name="fuelConsumption">Amount of fuel which car needs per 100 km.</param>
        /// <param name="fuelTankVolume">Max Amount of fuel which fuel tank can contain.</param>
        /// <param name="vehicleMileage">Amount of km which car overcome.</param>
        /// <param name="seats">Amount of seats which can be used for passengers.</param>
        /// <param name="price">Price of the car.</param>
        public Vaz(double fuelConsumption, double fuelTankVolume, int vehicleMileage, int seats, int price)
            : base(fuelConsumption, fuelTankVolume, vehicleMileage, seats, price)
        {
        }

        /// <summary>
        /// Gets car model.
        /// </summary>
        public override string CarModel => "2107";

        /// <summary>
        /// Gets type of taxi.
        /// </summary>
        public override TypeOfTaxi TypeOfTaxi => TypeOfTaxi.Econom;
    }
}
