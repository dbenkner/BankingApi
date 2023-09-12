using System;
using System.ComponentModel.DataAnnotations;

namespace BankingApi.Models
{
	public class Account
	{
		public int Id { get; set; }
		[StringLength(2)]
		public string Type { get; set; } = string.Empty;
		[StringLength(255)]
		public string Description { get; set; } = string.Empty;
		public decimal InterestRate { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime? ModifiedDate { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

	}
}

