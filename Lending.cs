using System;

public class Lending
{
	public string ID { get; set; }

	Client lender;
	public int Installment { get; set; }
	DateTime StartLend { get; set; }
	DateTime EndLend { get; set; }

	public Lending()
	{
	}
}
