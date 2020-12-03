namespace Leson3M2.Helper
{
    using System.Collections;
    using Leson3M2.Models.Сars;

    /// <summary>
    /// Compare cars.
    /// </summary>
    public class CarComparer : IComparer
    {
        /// <summary>
        /// Compare two passanger taxies.
        /// </summary>
        /// <param name="x"> first object.</param>
        /// <param name="y"> second object.</param>
        /// <returns>comparable value.</returns>
        public int Compare(object x, object y)
        {
            var car1 = x as PassengerTaxi;
            var car2 = x as PassengerTaxi;
            if (car1.Price > car2.Price)
            {
                return 1;
            }
            else
            {
                if (car1.Price < car2.Price)
                {
                    return -1;
                }
            else
                {
                    return 0;
                }
        }
    }
}
