using System;

public class UI
{
	
	public UI()
	{
	}

	public static void Home()
    {
		Bank bank = new Bank("Fineco Bank");


		Console.Clear();
		bank.StampClientList();

		Console.WriteLine($"Welcome in {bank.Name}");
		Console.WriteLine();

		Console.WriteLine("1. Search clients");
		Console.WriteLine("2. Create clients");
		Console.WriteLine("3. Modify data clients");
		Console.WriteLine("4. Add Lending");
		Console.WriteLine("5. Search by Lending");
		Console.WriteLine("6. Total lendings for client");
		Console.WriteLine("7. How many installments remains");

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
        }
		else if(choice == 2)
        {
			Console.Clear();

			Client newClient = bank.NewClient();
			bank.SaveClient(newClient);
		}
		else if (choice == 3)
        {
			Console.Clear();
			
			bank.ModifyClient();
        }

    }
}
