using System.Globalization;


namespace Oasp4net.Infrastructure.DataTypes
{
    /// <summary>
    /// Represents a Money data type
    /// </summary>
    public class Money
    {
        /// <summary>
        /// The amount
        /// </summary>
        private decimal amount;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Money()
        {
            amount = 0.0m;
        }


        /// <summary>
        /// Get and sets the Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="amount">The amount</param>
        public Money(decimal amount)
        {
            this.amount = amount;
        }

        public Money Add(Money money)
        {
            Amount = Amount + money.Amount;
            return this;
        }

        /// <summary>
        /// Ovveride ToString
        /// </summary>
        /// <returns>Returns a string representation</returns>
        public override string ToString()
        {
            return Amount.ToString(CultureInfo.CreateSpecificCulture("de-DE")) + "EUR";
        }
    }
}
