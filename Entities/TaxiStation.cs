namespace Leson3M2.Entities
{
/// <summary>
/// Contain taxi station parameters.
/// </summary>
    public class TaxiStation
    {
       /// <summary>
       /// Gets or sets cars.
       /// </summary>
        public Car[] Cars { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public int Price { get; set; }
    }
}
