using System;

public class Bank
{
	public string Name { get; set; }

	List<Client> clients;
	List<Lending> lendings;
	public Bank(string name)
	{
		this.Name = name;

		clients = new List<Client>();
		lendings = new List<Lending>();

		Client user = new Client("lorenzo", "ariatta", "cf001", 5000);
		Client user2 = new Client("stefano", "calzoni", "cf002", 5000);
		clients.Add(user);
		clients.Add(user2);

	}

	public void StampClientList()
    {
		foreach (Client client in clients)
        {
            Console.WriteLine($"{client.Name} {client.Surname}");
		}
    }


	internal Client SearchClient()
    {
        Console.WriteLine("Search a client by name: ");
		string name = Console.ReadLine().ToLower();

		foreach(Client client in clients)
        {
			if (client.Name == name)
            {
				Console.WriteLine($"Found! Client: {client.Name} {client.Surname}");
				Thread.Sleep(2000);
            }
            else
            {
				Console.WriteLine("Name not found!");
				Thread.Sleep(2000);
				UI.Home();
            }
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

		foreach (Client client in clients)
		{
			if (client.CF == cf)
			{
				Console.WriteLine($"Found: {client.Name} {client.Surname}! Fiscal Code: {client.CF}, salary: {client.Salary}");

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
			}
			else
			{
                Console.WriteLine("Wrong fiscal code!");
			}
		}
	}
}
