using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    [Table("Form56s")]
    [PrimaryKey("Form56Id")]
    public class Form56Model
    {
        public int Form56Id { get; set; }
        public int FormNo { get; set; }
        public string PreviousReceiptNo { get; set; }
        public DateTime? Dated {  get; set; }
        public DateTime? Year { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public DateTime? Date {  get; set; }
        public string ReceiveFrom { get; set; }
        public decimal Sum { get; set; }
        public decimal Pesos { get; set; }
        public Enums.TaxType TaxType { get; set; }
        public string CheckNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Treasurere {  get; set; }
        public string Deputy { get; set; }
        [ForeignKey("Form56Id")]
        public List<Form56DetailModel> Details { get; set; } = new();
        public long PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentTypeModel? PaymentType { get; set; }
    }
}
