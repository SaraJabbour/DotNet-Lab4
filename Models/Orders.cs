using System.ComponentModel.DataAnnotations;

namespace DotNet_Lab4.Models
{
	public class Orders
	{
		[System.ComponentModel.DataAnnotations.Key]

		public int OrdersID { get; set; }

			[DataType(DataType.Date)]
			public DateTime OrdersType { get; set; }

			public int Qty { get; set; }

			public int MixID { get; set; }
			public int CUSTID { get; set; }


			[DataType(DataType.Time)]
			public DateTime OrdersTIME { get; set; }
			public String Notes { get; set; }

			public bool deleted { get; set; }
		
	}
}
