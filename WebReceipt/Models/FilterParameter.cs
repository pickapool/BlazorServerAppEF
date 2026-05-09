using MudBlazor;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    public class FilterParameter
    {
        public bool IsDate { get; set; }
        public DateRange _dateRange { get; set; } = new DateRange(DateTime.Now, DateTime.Now);
        public bool IsPayor { get; set; }
        public string PayorName { get; set; } = string.Empty;
        public bool IsORNumber { get; set; }
        public string ORNumber { get; set; } = string.Empty;
        public bool IsTransactionType { get; set; }
        public IReadOnlyCollection<Enums.TransactionType?> ListOfTransaction { get; set; } = System.Array.Empty<Enums.TransactionType?>();
        public IReadOnlyCollection<PaymentTypeModel> ListOfPayments { get; set; } = System.Array.Empty<PaymentTypeModel>();
        public bool IsCollector { get; set; }
        public string CollectorName { get; set; } = string.Empty;
    }
}