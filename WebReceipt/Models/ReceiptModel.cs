using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

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
        public decimal Total { get; set; }
        public List<NatureOfCollectionModel> ListOfNatures { get; set; } = new();
        public bool checked1 { get; set; } = false;
        public bool checked2 { get; set; } = false;
        public bool checked3 { get; set; } = false;
        public string ApprovedBy { get; set; }
        public string Value1 { get; set ;}
        public string Value2 { get; set; }
        public String Value3 { get; set; }

    }
}