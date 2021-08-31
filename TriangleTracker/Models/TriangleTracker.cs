using System;


namespace TriangleTracker
{

  public class TriangleTracker
  {
		public bool IsATriangle(int side1, int side2, int side3)
			{
				if (side1 <= (side2 + side3) && side2 <= (side1 + side3) && side3 <= (side1 + side2))
				  {
						Console.WriteLine("Congrats, it's a triangle");
				    return true;
				  } else
				  {
						Console.WriteLine("Better luck next time.");
					  return false;
				  }
			}

		public void TypeOfTriangle(int side1, int side2, int side3)
		{
			if (side1 == side2 && side2 == side3)
			{
				Console.WriteLine("Its an equilateral");
			} else if (side1 == side2 || side1 == side3 || side2==side3) 
			{
				Console.WriteLine("Its an isosceles");
			}else 
			{
				Console.WriteLine("Its scalene");
			}
		}

		static void Main()
			{
			Console.WriteLine("Enter a number");
			string number1 = Console.ReadLine();
			int side1 = int.Parse(number1);
			Console.WriteLine("Enter another number: ");
			string number2 = Console.ReadLine();
			int side2 = int.Parse(number2);
			Console.WriteLine("Enter a third number: ");
			string number3 = Console.ReadLine();
			int side3 = int.Parse(number3);

			TriangleTracker triangle = new TriangleTracker();
			triangle.IsATriangle(side1, side2, side3);
			triangle.TypeOfTriangle(side1, side2, side3);

			// if (triangle.IsATriangle == true)
			// {
			// 	triangle.TypeOfTriangle(side1, side2, side3);
			// }
			// else
			// {
			// 	return Console.WriteLine("still not a triangle");
			// }
			
		}
  }
}