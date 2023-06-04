namespace DotNet_Lab4.Models
{
	public class Customer
	{
		[System.ComponentModel.DataAnnotations.Key]
		public int CUSTID { get; set; }
		public string CUSTDESC { get; set; }

		public bool deleted { get; set; }
	}
}
