

using System.Timers;

namespace U3_GEOMETICAREAS
{
	internal class Program
	{
		public static void Main(string[] args)
		{

		
				Console.WriteLine("Welcome to the area of square and rectangles calculator");
				Console.WriteLine("What will be today's option?  \n 1) Square \n2) Rectangle");
				string option = Console.ReadLine();

				if (option == "1" || option == "2")
				{
					switch (option)
					{
						case "1":
							try
							{


								Console.WriteLine("ENTER SIDE VALUE: ");
								double value_side = Convert.ToDouble(Console.ReadLine());

								Square_area object1 = new Square_area(value_side);
								Console.WriteLine(object1.ToString());
								Console.WriteLine("The area is : " + object1.CalculateArea(value_side));
						     	value_side = double.NaN;
								


							}
							catch (FormatException)
							{
								Console.WriteLine("The value entered is not valid");

							}

							break;

						case "2":

							try
							{

								
								Console.WriteLine("ENTER WIDTH VALUE: ");
								double width_side = Convert.ToDouble(Console.ReadLine());

								Console.WriteLine("ENTER THE LENGTH VALUE:  ");
								double lenght_side = Convert.ToDouble(Console.ReadLine());

								Rectangular_area object2 = new Rectangular_area(width_side, lenght_side);
								Console.WriteLine(object2.ToString());
								Console.WriteLine("The area is : " + object2.CalculateArea(width_side, lenght_side));
							     width_side = double.NaN;
							 
							}
							catch (FormatException)
							{
								Console.WriteLine("The value entered is not valid");

							}

							break;

						default:
							break;
					}

					

				}
				else
				{
					Console.WriteLine("The value entered is not valid");

				}

			

			Console.ReadKey();
		}




	}

}