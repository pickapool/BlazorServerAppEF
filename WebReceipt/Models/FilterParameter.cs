using MudBlazor;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    public class FilterParameter
    {
        public bool IsDate { get; set; }
        public DateRange _dateRange { get; set; } = new DateRange(DateTime.Now, DateTime.Now);
        public bool IsPayor { get; set; }
        public string PayorName { get; set; }
        public bool IsORNumber;
        public string ORNumber { get; set; }
        public bool IsTransactionType { get; set; }
        public IEnumerable<Enums.TransactionType> ListOfTransaction { get; set; } = new HashSet<Enums.TransactionType>();
    }
}