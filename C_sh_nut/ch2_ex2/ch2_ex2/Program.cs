using System;

namespace ch2_ex2
{
	class Test
	{
		public static void Main (string[] args)
		{
			UnitConverter feetToInchesConverter = new UnitConverter (12);
			UnitConverter milesToFeetConverter = new UnitConverter (5280);

			Console.WriteLine ("Hello World!");

			Console.WriteLine (feetToInchesConverter.Convert(30)); //360
			Console.WriteLine (feetToInchesConverter.Convert(100)); //1200
			Console.WriteLine (feetToInchesConverter.Convert(milesToFeetConverter.Convert(1))); //63360

			Console.WriteLine (yardsToFeetConverter.Convert(4)); //12

			Panda p1 = new Panda ("Pan Dee");
			Panda p2 = new Panda ("Pan Dah");

			Console.WriteLine (p1.Name); // Pan Dee
			Console.WriteLine (p2.Name); // Pan Dah

			Console.WriteLine (Panda.Population); // 2
		}
	}

	public class UnitConverter
	{
		int ratio; //Field
		public UnitConverter (int unitRatio) //constructor
		{
			ratio = unitRatio;
		}
		public int Convert (int unit)  //method
		{
			return unit * ratio;
		}
	}

	public static class yardsToFeetConverter
	{
		static int ratio = 3; //Field
		public static int Convert (int unit)  //method
		{
			return unit * ratio;
		}
	}

	public class Panda
	{
		public string Name;    // instance field
		public static int Population; // Static field

		public Panda (string n)  // Constructor
		{
			Name = n;  //Assign the instance field
			Population = Population + 1; //increment the static population field
		}
	}


}
