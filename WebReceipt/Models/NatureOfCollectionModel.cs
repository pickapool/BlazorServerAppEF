using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReceipt.Models
{
    [Table("NatureOfCollections")]
    [PrimaryKey("NatureOfCollectionId")]
    public class NatureOfCollectionModel
    {
        public int NatureOfCollectionId { get; set; }
        public string NatureName { get; set; }
        public int ReceiptId { get; set; }
        public string AccountCode { get; set; }
        public double Amount { get; set; }
    }
}