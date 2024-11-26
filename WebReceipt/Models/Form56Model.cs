using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    [Table("Form56s")]
    [PrimaryKey("Form56Id")]
    public class Form56Model
    {
        public int Form56Id { get; set; }
        [Required]
        public int FormNo { get; set; }
        [Required]
        public string PreviousReceiptNo { get; set; } = string.Empty;
        public DateTime? Dated {  get; set; }
        public DateTime? Year { get; set; }
        [Required]
        public string Province { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        public DateTime? Date {  get; set; }
        [Required]
        public string ReceiveFrom { get; set; } = string.Empty;
        public decimal Sum { get; set; }
        public decimal Pesos { get; set; }
        public Enums.TaxType TaxType { get; set; }
        public bool IsBasic { get; set; }
        public bool IsSpecial { get; set; }
        public string CheckNo { get; set; } = string.Empty;
        public DateTime? CheckDate { get; set; }
        [Required]
        public string Treasurere { get; set; } = string.Empty;
        [Required]
        public string Deputy { get; set; } = string.Empty;
        [ForeignKey("Form56Id")]
        public List<Form56DetailModel> Details { get; set; } = new();
        public long PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentTypeModel? PaymentType { get; set; }
    }
}
