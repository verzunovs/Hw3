namespace Leson3M2.Models.Сars
{
    using Leson3M2.Enums;

    /// <summary>
    /// Passanger taxi.
    /// </summary>
    public abstract class PassengerTaxi : Car
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PassengerTaxi"/> class.
        /// </summary>
        /// <param name="fuelConsumption">Amount of fuel which car needs per 100 km.</param>
        /// <param name="fuelTankVolume">Max Amount of fuel which fuel tank can contain.</param>
        /// <param name="vehicleMileage">Amount of km which car overcome.</param>
        /// <param name="seats">Amount of seats which can be used for passengers.</param>
        public PassengerTaxi(double fuelConsumption, double fuelTankVolume, int vehicleMileage, int seats)
            : base(fuelConsumption, fuelTankVolume, vehicleMileage, seats)
        {
        }

        /// <summary>
        /// Gets type of taxi.
        /// </summary>
        public abstract TypeOfTaxi TypeOfTaxi { get; }
    }
}
