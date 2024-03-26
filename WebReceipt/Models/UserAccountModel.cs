using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReceipt.Models
{
    [Table("Accounts")]
    [PrimaryKey("UserAccountInt")]
    public class UserAccountModel
    {
        public int UserAccountInt { get; set; }
        public string UserAccountName { get; set;} = string.Empty;
        public string UserAccountPassword { get; set; } = string.Empty;
    }
}
