namespace Leson3M2
{
    /// <summary>
    /// Class of cars.
    /// </summary>
    public abstract class Car : ICarProperties
    {
        private readonly double fuelConsumption;
        private readonly double fuelTankVolume;
        private readonly int vehicleMileage;
        private readonly int seats;
        private readonly int price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="fuelConsumption">Amount of fuel which car needs per 100 km.</param>
        /// <param name="fuelTankVolume">Max Amount of fuel which fuel tank can contain.</param>
        /// <param name="vehicleMileage">Amount of km which car overcome.</param>
        /// <param name="seats">Amount of seats which can be used for passengers.</param>
        /// <param name="price">Price of the car.</param>
        protected Car(double fuelConsumption, double fuelTankVolume, int vehicleMileage, int seats, int price)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelTankVolume = fuelTankVolume;
            this.vehicleMileage = vehicleMileage;
            this.seats = seats;
            this.price = price;
        }

        /// <summary>
        /// Gets car model.
        /// </summary>
        public abstract string CarModel { get; }

        /// <summary>
        /// Gets amount of seats.
        /// </summary>
        public int Seats => this.seats;

        /// <summary>
        /// Gets fuel consumption.
        /// </summary>
        public double FuelConsumption => this.fuelConsumption;

        /// <summary>
        /// Gets fuel tank volume.
        /// </summary>
        public double FuelTankVolume => this.fuelTankVolume;

        /// <summary>
        /// Gets vehicle Mileage.
        /// </summary>
        public int VehicleMileage => this.vehicleMileage;

        /// <summary>
        /// Gets price of the car.
        /// </summary>
        public int Price => this.price;
    }
}
