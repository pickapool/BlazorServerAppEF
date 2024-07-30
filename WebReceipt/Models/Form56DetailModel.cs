using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReceipt.Models
{
    [Table("Form56Details")]
    [PrimaryKey("Form56DetailId")]
    public class Form56DetailModel
    {
        public int Form56DetailId { get; set; }
        public int Form56Id { get; set; }
        public string Owner { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Block { get; set; } = string.Empty;
        public string TaxNo { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;
        public string Improvements { get; set; } = string.Empty;
        public decimal AssesedTotal { get; set; }
        public string TaxDue { get; set; } = string.Empty;
        public string InstallmentNo { get; set; } = string.Empty;
        public string InstallmentPayment { get; set; } = string.Empty;
        public string FullPayment { get; set; } = string.Empty;
        public string Penalty { get; set; } = string.Empty;
        public decimal Total { get; set; }
    }
}
