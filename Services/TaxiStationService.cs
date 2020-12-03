namespace Leson3M2.Services
{
    using Leson3M2.Entities;
    using Leson3M2.Models.Сars;

    /// <summary>
    /// Contain taxi service.
    /// </summary>
    public class TaxiStationService : ITaxiStationService
    {
        /// <summary>
        /// Create list of car.
        /// </summary>
        /// <returns>List of cars on taxi station.</returns>
        public TaxiStation MakeTaxiStation()
        {
            var cars = new Car[]
            {
                new Volkswagen(9, 30, 1000, 4, 9000),
                new Vaz(11, 50, 20000, 4, 1000),
                new Mercedes(15, 50, 5000, 4, 15000),
            };
            var priceOfAllCars = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                priceOfAllCars += cars[i].Price;
            }

            return new TaxiStation {Cars = cars, Price = priceOfAllCars};
        }
    }
}
