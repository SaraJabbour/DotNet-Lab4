using System.ComponentModel.DataAnnotations;

namespace DotNet_Lab4.Models
{
	public class Payment
	{
		[System.ComponentModel.DataAnnotations.Key]

		public int PaymentID { get; set; }

		[DataType(DataType.Date)]
		public DateTime PaymentType { get; set; }

		public int CustID { get; set; }
		public double PayAmount { get; set; }
		public String? username { get; set; }
		public string? PayType { get; set; }

		[DataType(DataType.Date)]
		public DateTime PayDate { get; set; }
		public String? AmountCurrency { get; set; }
	}
}
