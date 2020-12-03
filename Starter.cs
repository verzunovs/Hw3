namespace Leson3M2.Helper
{
    using Leson3M2.Services;

    /// <summary>
    /// Starter.
    /// </summary>
    public class Starter
    {
        private readonly ITaxiStationService taxiStationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
            this.taxiStationService = new TaxiStationService();
        }

        /// <summary>
        /// Method for run program.
        /// </summary>
        public void Run()
        {
            var taxiStation = this.taxiStationService.MakeTaxiStation();
        }
    }
}
