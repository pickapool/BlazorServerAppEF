using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReceipt.Models
{
    [Table("Accounts")]
    [PrimaryKey("UserAccountId")]
    public class UserAccountModel
    {
        public int UserAccountId { get; set; }
        public string UserAccountName { get; set;} = string.Empty;
        public string UserAccountPassword { get; set; } = string.Empty;
        public string EmployeeName { get;set; } = string.Empty;
    }
}
