using System;

public class UI
{
	Bank bank = new Bank();
	public UI()
	{
	}

	public void Home()
    {
		//Bank bank = new Bank(bankName);

		Console.Clear();
		//bank.StampClientList();

		Console.WriteLine($"Welcome in {bank.Name}");
		Console.WriteLine();
		DateTime today = DateTime.Now;
		Console.WriteLine(today.ToString("D"));
		Console.WriteLine();

		Console.WriteLine("1. Search info clients");
		Console.WriteLine("2. Create clients");
		Console.WriteLine("3. Modify data clients");
		Console.WriteLine("4. Add Lending");
		Console.WriteLine("5. Search Lending");
		Console.WriteLine("6. How many installments remains");

		int choice = Int32.Parse(Console.ReadLine());

		if(choice < 1)
        {
            Console.WriteLine("Wrong choice...");
			Console.Clear();
			Home();
        }
		else if (choice == 1)
        {
			Console.Clear();

			bank.SearchClient();
			Home();
		}
		else if(choice == 2)
        {
			Console.Clear();

			Client newClient = bank.NewClient();
			bank.SaveClient(newClient);
			Home();
		}
		else if (choice == 3)
        {
			Console.Clear();
			
			bank.ModifyClient();
			Home();
		}
		else if (choice == 4)
		{
			Console.Clear();

			bank.NewLending();
			Home();
		}
		else if (choice == 5)
		{
			Console.Clear();

			bank.SearchLending();
			Home();
		}

	}
}
