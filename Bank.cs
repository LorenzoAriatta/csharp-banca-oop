using System;

public class Bank
{
	public string Name = "Fineco bank";
	List<Client> clients;
	List<Lending> lendings;
	public Bank()
	{
		//this.Name = name;

		clients = new List<Client>();
		lendings = new List<Lending>();

		Client user = new Client("lorenzo", "ariatta", "cf001", 5000, 2);
		Client user2 = new Client("stefano", "calzoni", "cf002", 5000, 5);
		Client user3 = new Client("lello", "lellis", "cf003", 5000, 10);
		clients.Add(user);
		clients.Add(user2);
		clients.Add(user3);

		Lending lending = new Lending(user, 50000, 20, DateOnly.Parse("13/07/2020"), DateOnly.Parse("13/07/2022"), 5050);
		Lending lending2 = new Lending(user2, 500000, 10, DateOnly.Parse("20/05/2020"), DateOnly.Parse("20/05/2022"), 5151);
		Lending lending3 = new Lending(user3, 30000, 50, DateOnly.Parse("02/10/2020"), DateOnly.Parse("20/10/2022"), 5252);
		lendings.Add(lending);
		lendings.Add(lending2);
		lendings.Add(lending3);

	}

	public void StampClientList()
    {
		foreach (Client client in clients)
        {
            Console.WriteLine($"{client.Name} {client.Surname}");
		}
    }

	public Client SearchClient()
    {
        Console.WriteLine("Search a client by name: ");
		string name = Console.ReadLine().ToLower();

		bool notPresent = false;

		foreach (Client client in clients)
        {
			if (client.Name == name)
            {
				notPresent = false;
				Console.WriteLine($"Client found!");
				Console.WriteLine($"Client: \nName: {client.Name} | Surname: {client.Surname}");
				Console.WriteLine($"Info: \nFiscal Code:{client.CF} | Salary: {client.Salary} | Total lending request: {client.TotalLendings} ");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You will be redirected to the homepage in 8 seconds...");
				Thread.Sleep(8000);
				break;
            }
            else
            {
				notPresent = true;
            }
        }
		if (notPresent == true)
		{
			Console.WriteLine("Name not found!");
			Thread.Sleep(2000);
		}
		return null;
    }

	public Client SearchClientByCF()
	{
		Console.WriteLine("Search a client by Fiscal Code: ");
		string cf = Console.ReadLine().ToLower();

		bool notPresent = false;

		foreach (Client client in clients)
		{
			if (client.CF == cf)
			{
				notPresent = false;
				Console.WriteLine($"Found! Client: {client.Name} {client.Surname}");
				Thread.Sleep(2000);

				return client;
			}
			else
			{
				notPresent = true;
			}
		}
		if(notPresent == true)
        {
			Console.WriteLine("Fiscal code not found!");
			Thread.Sleep(2000);
			
		}
		return null;
	}

	public void SaveClient(Client newClient)
    {
		clients.Add(newClient);
		StampClientList();
	}

    public Client NewClient()
    {
        Console.WriteLine("Insert your name: ");
		string name = Console.ReadLine().ToLower();

		Console.WriteLine("Insert your surname: ");
		string surname = Console.ReadLine().ToLower();

		Console.WriteLine("Insert your fiscal code: ");
		string cf = Console.ReadLine().ToLower();

		Console.WriteLine("Insert your salary: ");
		int salary = Int32.Parse(Console.ReadLine());

		Client newClient = new Client(name, surname, cf, salary);

		Console.WriteLine("Please wait, we're saving your data....");

		Thread.Sleep(3000);
		Console.Clear();
        Console.WriteLine("Success!");

		//UI.Home();

		return newClient;
	}

	public void ModifyClient()
    {
		Console.WriteLine("Insert your fiscal code: ");
		string cf = Console.ReadLine().ToLower();

		bool notPresent = false;

		foreach (Client client in clients)
		{
			if (client.CF == cf)
			{
				notPresent = false;
				Console.WriteLine($"Found: {client.Name} {client.Surname}! Fiscal Code: {client.CF}, salary: {client.Salary}");

				clients.Remove(client);

				Console.WriteLine("What you want modify?");

				Console.WriteLine("Insert your NEW name: ");
				string name = Console.ReadLine().ToLower();

				Console.WriteLine("Insert your NEW surname: ");
				string surname = Console.ReadLine().ToLower();

				Console.WriteLine("Insert your NEW fiscal code: ");
				string fiscalCode = Console.ReadLine().ToLower();

				Console.WriteLine("Insert your NEW salary: ");
				int salary = Int32.Parse(Console.ReadLine());

				Client modClient = new Client(name, surname, fiscalCode, salary);

				clients.Add(modClient);
				break;
			}
			else
			{
				notPresent = true;
			}
		}
		StampClientList();

        if (notPresent == true)
        {
			Console.WriteLine("Wrong fiscal code!");
		}
	}

	public Lending NewLending()
    {
		Client newLender = SearchClientByCF();

		Console.WriteLine("How many cash do you want? ");
		int cash = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Insert number of installments: ");
		int installments = Int32.Parse(Console.ReadLine());

		Console.WriteLine("Insert the start of lending: ");
		DateOnly StartLend = DateOnly.Parse(Console.ReadLine());

		Console.WriteLine("Insert the end of lending: ");
		DateOnly EndLend = DateOnly.Parse(Console.ReadLine());

		Console.WriteLine("Insert ID number of lending: ");
		int ID = Int32.Parse(Console.ReadLine());

		Lending newLend = new Lending(newLender, cash, installments, StartLend, EndLend, ID);

		lendings.Add(newLend);

		Console.WriteLine("Please wait, we're saving your data....");

		Thread.Sleep(3000);
		Console.Clear();
		Console.WriteLine("Success!");

		return newLend;
	}

	public void SearchLending()
	{
		bool notPresent = false;
		Console.WriteLine("Search a lending of a client by fiscal code: ");
		string cf = Console.ReadLine().ToLower();
		
		foreach (Lending lend in lendings)
		{
			Client lender = lend.GetClient();
			DateTime currentDate = DateTime.Now;

			if (lender.CF == cf)
			{
				notPresent = false;
				Console.WriteLine($"Found! Client: {lender.Name} {lender.Surname}");

                Console.WriteLine($"ID of lend: {lend.ID} | Total lending: {lend.Cash} | Total installments: {lend.Installment} | Started: {lend.StartLend} | Ended: {lend.EndLend}");

				Thread.Sleep(5000);
			}
			
		}

		if(notPresent == true)
        {
			Console.WriteLine("Fiscal code not found!");
			Thread.Sleep(2000);
		}
		
	}
}
