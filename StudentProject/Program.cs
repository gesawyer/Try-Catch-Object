using System;
using System.Collections.Generic;

/*
 task #1: 
task #2: ???
 */

namespace StudentProject
{
	internal class Student
	{
		public string Name { get; internal set; }
		public string Hometown { get; internal set; }
		public string Food { get; internal set; }
		public Student(string argName, string argHometown, string argFood)
		{
			this.Name = argName;
			this.Hometown = argHometown;
			this.Food = argFood;
		}
		
		public Student()
		{
			this.Name = "blankName";
			this.Hometown = "blankHometown";
			this.Food = "blankFood";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int num=0;
			
			Console.WriteLine("Please enter a number 1-12");
			bool go = true;

            while (go)
			{
				string input = Console.ReadLine();

				try
				{
					 num = int.Parse(input);
				}
				catch (FormatException)
				{
					Console.WriteLine("Please provide a number!");
					go = !true;
				}
			}
			int tempNum = num;

			Student stu0 = new Student("Grace Seymore", "Mesa, AZ", "sweet potato fries");
			Student stu1 = new Student("Ramon Guarnes", "Tigard, OR", "burgers");
			Student stu2 = new Student("Antonio Manzari", "Beverly Hills, MI", "focaccia barese");
			Student stu3 = new Student("Joshua Coralin", "Novi, MI", "naleśniki");
			Student stu4 = new Student("Nick D'Oria", "Canton, MI", "tacos");
			Student stu5 = new Student("Jeremiah Wyeth", "Crystal, MI", "burgers");
			Student stu6 = new Student("Wendi Magee", "Detroit, MI", "salami");
			Student stu7 = new Student("Juliana", "Denver, CO", "tacos");
			Student stu8 = new Student("Nathaniel Davis", "Berkley, MI", "steak");
			Student stu9 = new Student("Tommy Waalkes", "Raleigh, NC", "chicken curry");
			Student stu10 = new Student("Jeffrey Wohlfield", "Detroit, MI", "steak");
			Student stu11 = new Student("Josh Gallentine", "Baldwin, MI", "falafel");
			Student stu12 = new Student("Stephen Jedlicki", "The Moon", "mooncakes");

			List<Student> myList = new List<Student>();

			myList.Add(stu0);
			myList.Add(stu1);
			myList.Add(stu2);
			myList.Add(stu3);
			myList.Add(stu4);
			myList.Add(stu5);
			myList.Add(stu6);
			myList.Add(stu7);
			myList.Add(stu8);
			myList.Add(stu9);
			myList.Add(stu10);
			myList.Add(stu11);
			myList.Add(stu12);

			Student temp = new Student();

			for (int i = 0; i <= tempNum - 1; i++)
			{
				temp = myList[i];
			}

			Console.WriteLine(temp.Name);
			Console.WriteLine("Would you like to know this student's favorite food or hometown? Please enter 'food' or 'hometown'.");
			string userChoice= Console.ReadLine();

			if (userChoice == "food")
			{
				Console.WriteLine(temp.Food);
			}
			else if (userChoice == "hometown")
            {
				Console.WriteLine(temp.Hometown);
            }
            else
            {
				Console.WriteLine("try again bitch");
            }




		}


	}
		
			
		

		

	
}