using System;

public class Client
{
	public string Name { get; private set; }
	public string Surname { get; private set; }
	public string CF { get; private set; }
	public int Salary { get; private set; }
	public Client(string name, string surname, string cf, int salary)
	{
		this.Name = name;
		this.Surname = surname;
		this.CF = cf;
		this.Salary = salary;
	}
}
