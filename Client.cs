﻿using System;

public class Client
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string CF { get; set; }
	public int Salary { get; set; }
	public int TotalLendings { get; set; }

	public Client(string name, string surname, string cf, int salary, int totalLendings)
	{
		this.Name = name;
		this.Surname = surname;
		this.CF = cf;
		this.Salary = salary;
		this.TotalLendings = totalLendings;
	}

	public Client(string name, string surname, string cf, int salary)
	{
		this.Name = name;
		this.Surname = surname;
		this.CF = cf;
		this.Salary = salary;
	}

}
