namespace WebReceipt.Models
{
    public class Form56ReportModel
    {
        public string Date { get; set; }
        public string TaxPayer { get; set; }
        public string ORNo { get; set; }
        public string PeriodCovered { get; set; }
        public string Barangay { get; set; }
        public decimal CurrentYear { get; set; }
        public decimal Discount { get; set; }
        public decimal PriorYear { get; set; }

        public decimal CurrentYearPenalty { get; set; }
        public decimal PrioYearPenalty { get; set; }
        public decimal Gross { 
            get
            {
                return CurrentYear + PriorYear;
            }
        }
        public decimal Net { 
            get
            {
                return (CurrentYearPenalty + PrioYearPenalty) + Gross - Discount;
            }
        }
    }
}
