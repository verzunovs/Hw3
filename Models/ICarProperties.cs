namespace Leson3M2
{
    /// <summary>
    /// Properties of cars.
    /// </summary>
    internal interface ICarProperties
    {
        /// <summary>
        /// Gets car model.
        /// </summary>
        string CarModel { get; }

        /// <summary>
        /// Gets amount of seats.
        /// </summary>
        int Seats { get; }

        /// <summary>
        /// Gets fuel consumption of car.
        /// </summary>
        double FuelConsumption { get; }

        /// <summary>
        /// Gets fuel tank volume of car.
        /// </summary>
        double FuelTankVolume { get; }

        /// <summary>
        /// Gets vehicle mileage.
        /// </summary>
        int VehicleMileage { get; }

        /// <summary>
        /// Gets price of car;
        /// </summary>
        int Price { get; }
    }
}
