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
        public string Owner {  get; set; }
        public string Location { get; set; }
        public string Block { get; set; }
        public string TaxNo { get; set; }
        public string Land { get; set; }
        public string Improvements { get; set; }
        public decimal AssesedTotal { get; set; }
        public string TaxDue { get; set; }
        public string InstallmentNo { get; set; }
        public string InstallmentPayment {  get; set; }
        public string FullPayment { get; set; }
        public string Penalty { get; set; }
        public decimal Total { get; set; }
    }
}
