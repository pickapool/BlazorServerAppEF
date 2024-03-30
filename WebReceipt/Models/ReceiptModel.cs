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
        public string Number { get; set; }
        public string Agency { get; set; }
        public string Payor { get; set; }
        public string Fund { get; set; }
        public double Total { get; set; }
        [ForeignKey("ReceiptId")]
        public List<NatureOfCollectionModel> ListOfNatures { get; set; } = new();
        public bool Cash { get; set; } = false;
        public bool Check { get; set; } = false;
        public bool MoneyOrder { get; set; } = false;
        public string CollectionOfficer { get; set; }
        public string DraweeBank { get; set ;}
        public string DraweeNumber { get; set; }
        public DateTime? DraweeDate { get; set; } = DateTime.Now;
        public Enums.TransactionType TransactionType { get; set ;}
        [NotMapped]
        public bool IsShowReceipt { get; set; }

    }
}