using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebReceipt.Common;

namespace WebReceipt.Models
{
    [Table("Cedulas")]
    [PrimaryKey("CedulaId")]
    public class CedulaModel
    {
        public CedulaModel()
        {
            PlaceOfIssue = "Barbaza, Antique";
            DateIssued = DateTime.Now;
            DateOfBirth = DateTime.Now;
        }
        public int CedulaId { get; set; }
        public DateTime? DateIssued { get; set;  }
        public int ORNumber {  get; set; }
        public string PlaceOfIssue { get; set; }
        public string SureName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Citizenship { get; set; } = string.Empty;
        public string ICRNo { get; set; } = string.Empty;
        public string PlaceOfBirth { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public decimal BasicTax { get; set; }
        public decimal BasicCommunity { get; set; }
        public decimal AdditionTax { get; set; }
        public decimal AdditionCommunity { get; set;}
        public decimal GrossTax { get; set;}
        public decimal GrossCommunity { get; set;}
        public decimal SalaryTax { get; set; }
        public decimal SalaryCommunity { get; set;}
        public decimal IncomeTax { get; set; }
        public decimal IncomeCommunity { get; set; }
        public decimal Total {  get; set; }
        public decimal Interest { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Enums.CivilStatus CivilStatus { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Paid { get; set; }
        public string Tin { get; set; }
        public string CityTreasurer { get; set; }
        public Enums.Sex Sex {  get; set; }
        public long PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentTypeModel? PaymentType { get; set; }
        [NotMapped]
        public string Name
        {
            get
            {
                return $"{FirstName}{(String.IsNullOrEmpty(MiddleName) ? " " : " " + MiddleName.Substring(0,1))}. {SureName}";
            }
        }
    }
}
