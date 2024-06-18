using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReceipt.Models
{
    [Table("PaymentTypes")]
    [PrimaryKey("PaymentTypeId")]
    public class PaymentTypeModel
    {   
        public Int64 PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; } = string.Empty;
    }
}
