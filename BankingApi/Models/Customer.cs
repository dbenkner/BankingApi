using System.ComponentModel.DataAnnotations;

namespace BankingApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int CardCode { get; set; }
        public int PinCode {get;set; }
        public DateTime LastTransactionDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
