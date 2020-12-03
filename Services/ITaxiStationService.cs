namespace Leson3M2.Services
{
    using Leson3M2.Entities;

    /// <summary>
    /// Interface for class "TaxiStationService".
    /// </summary>
    internal interface ITaxiStationService
    {
        /// <summary>
        /// Create list of cars.
        /// </summary>
        /// <returns>List of cars on taxi staation</returns>
        TaxiStation MakeTaxiStation();
    }
}
