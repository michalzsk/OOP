namespace Exercise_solution
using System;


public class Student
{
	public string name { get; private set; }
	public int Grade 
	{
		get;
		set {if(value>=1 && value <= 6){Grade = value;}}
	}
	public Student(string name, int grade)
	{
		this.name = name;
		Grade = grade;
	}
	public void IsPassing()
	{
		int grade = int.parse(Console.ReadLine());
		if (Grade > 2)
		{
			console.write($"Uczen {name} zdaje");
			return 1;
		}
		else
		{
			Console.Write($"Uczen {name} nie zdaje")
			return 0;
		}
	}
}
