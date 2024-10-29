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
		Name = name;
		Grade = grade;
	}
	public void IsPassing()
	{
		int Grade = int.parse(Console.ReadLine());
		if (Grade > 2)
		{
			console.write($"Uczen {Name} zdaje");
			return true;
		}
		else
		{
			Console.Write($"Uczen {Name} nie zdaje")
			return false;
		}
	}
}
