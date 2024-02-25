using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_GEOMETICAREAS
{
	internal class Square_area
	{

		protected double side;

		public double Side
		{
			get { return side; }
			set { side = value; }
		}


		public Square_area()
		{
			side = 0;
		}
		public Square_area(double side)
		{
			this.side = side;
		}

		//Methods
		//Method that returns but does not receive parameters
		public override string ToString()
		{
			return "" + "The measurements are: " + side;
		}

		//Method that returns and receives parameters:
		public double CalculateArea(double side)
		{
			return (side * side);
		}


		~Square_area()
		{

		
				Console.WriteLine("Destructor called. Cleaning up resources...");
			
			
		}


	}
}
