using System;

public class Lending
{
	public int ID { get; set; }

	public int Cash { get; set; }

	Client lender;
	public int Installment { get; set; }
	public DateOnly StartLend { get; set; }
	public DateOnly EndLend { get; set; }

	public Lending(Client lender, int cash, int installment, DateOnly StartLend, DateOnly EndLend, int ID)
	{
		this.lender = lender;
		this.Cash = cash;
		this.Installment = installment;
		this.StartLend = StartLend;
		this.EndLend = EndLend;
		this.ID = ID;
	}

	public Client GetClient()
    {
		return this.lender;
    }
}
