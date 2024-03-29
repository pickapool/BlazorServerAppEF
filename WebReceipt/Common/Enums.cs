using System.ComponentModel;

namespace WebReceipt.Common
{
    public class Enums
    {
        public enum TransactionType
        {
            [Description("Mayors Permit")]
            Mayors = 0,
            [Description("Electrical Permit")]
            Electrilcal = 1,
            [Description("Chair Rental")]
            ChairRental = 2,
            [Description("Water Billing")]
            WaterBilling = 3,
            [Description("Laboratory")]
            Laboratory = 4,
            [Description("Market Stall")]
            MarketStall = 5
        }
    }
}