using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    [Table("Receipts")]
    [PrimaryKey("ReceiptId")]
    public class ReceiptModel
    {
        public int ReceiptId { get; set; }
        public DateTime? DateRecorded { get; set; } = DateTime.Now;
        public string Number { get; set; } = string.Empty;
        public string Agency { get; set; } = string.Empty;
        public string Payor { get; set; } = string.Empty;
        public string Fund { get; set; } = string.Empty;
        public double Total { get; set; }
        [ForeignKey("ReceiptId")]
        public List<NatureOfCollectionModel> ListOfNatures { get; set; } = new();
        public bool Cash { get; set; } = false;
        public bool Check { get; set; } = false;
        public bool MoneyOrder { get; set; } = false;
        public string CollectionOfficer { get; set; } = string.Empty;
        public string DraweeBank { get; set ;} = string.Empty;
        public string DraweeNumber { get; set; } = string.Empty;
        public DateTime? DraweeDate { get; set; } = DateTime.Now;
        public long PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentTypeModel PaymentType { get; set; }
        //public Enums.TransactionType TransactionType { get; set ;}
        [NotMapped]
        public bool IsShowReceipt { get; set; }
        [NotMapped]
        public string PDF { get; set; } = string.Empty;
        [NotMapped]
        public string PaymentTypeName { get; set; } = string.Empty;
    }
}