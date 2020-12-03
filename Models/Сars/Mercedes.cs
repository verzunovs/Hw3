namespace Leson3M2.Models.Сars
{
    using Leson3M2.Enums;

    /// <summary>
    /// Mercedes s-class.
    /// </summary>
    public class Mercedes : PassengerTaxi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mercedes"/> class.
        /// </summary>
        /// <param name="fuelConsumption">Amount of fuel which car needs per 100 km.</param>
        /// <param name="fuelTankVolume">Max Amount of fuel which fuel tank can contain.</param>
        /// <param name="vehicleMileage">Amount of km which car overcome.</param>
        /// <param name="seats">Amount of seats which can be used for passengers.</param>
        /// <param name="price">Price of the car.</param>
        public Mercedes(double fuelConsumption, double fuelTankVolume, int vehicleMileage, int seats, int price)
            : base(fuelConsumption, fuelTankVolume, vehicleMileage, seats, price)
        {
        }

        /// <summary>
        /// gets type of taxi.
        /// </summary>
        public override TypeOfTaxi TypeOfTaxi => TypeOfTaxi.Luxary;

        /// <summary>
        /// Gets car model.
        /// </summary>
        public override string CarModel => "S 450";
    }
}
