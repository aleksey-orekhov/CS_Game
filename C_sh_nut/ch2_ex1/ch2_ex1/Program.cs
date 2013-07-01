using System;  // Importing Namespace

namespace ch2_ex1  
{
	class Test  //Class declaration
	{
		static void Main (string[] args) //Method declaration
		{          
			bool simpleVar = false;
			if (simpleVar)
				Console.WriteLine ("This will not print");
			int y= 5000;
			bool lessThanAMile = y < 5280;
			if (lessThanAMile)
				Console.WriteLine ("This will print");
			int x = FeetToInches (30);
			Console.WriteLine (x); //360
			string message = "Hello world!";
			string upperMessage = message.ToUpper ();
			Console.WriteLine (message);
			Console.WriteLine (upperMessage);
			Console.WriteLine (message + upperMessage + x.ToString());
		}

		static int FeetToInches(int feet)
		{
			int inches = feet * 12;
			return inches;
		}
	}
}
