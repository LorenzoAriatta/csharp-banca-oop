using System;

public class Bank
{
	public string Name { get; set; }

	List<Client> clients;
	List<Lending> lendings;
	public Bank(string name)
	{
		this.Name = name;
	}

	public Client NewClient()
    {
        Console.WriteLine("Insert your name: ");
		string name = Console.ReadLine();

		Console.WriteLine("Insert your surname: ");
		string surname = Console.ReadLine();

		Console.WriteLine("Insert your fiscal code: ");
		string cf = Console.ReadLine();

		Console.WriteLine("Insert your salary: ");
		int salary = Int32.Parse(Console.ReadLine());

		Client newClient = new Client(name, surname, cf, salary);

        Console.WriteLine("Please wait, we're saving your data....");

		foreach (Client client in clients)
        {
			if(client.CF == newClient.CF)
            {
                Console.WriteLine("Your data already exist!");
				break;
            }
			else
            {
				clients.Add(newClient);
			}
        }
		Thread.Sleep(3000);
		Console.Clear();
        Console.WriteLine("Success!");


		return newClient;
    }

}
