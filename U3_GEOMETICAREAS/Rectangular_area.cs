using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_GEOMETICAREAS
{
	internal class Rectangular_area:Square_area
	{
		protected double large_side;

		public double Large_Side
		{
			get { return large_side; }
			set { large_side = value; }
		}
		protected double hypotenuse;

		public double Hypotenuse
		{
			get { return hypotenuse; }
		}


		public Rectangular_area():base()
		{

			large_side = 0;
		}
		public Rectangular_area(double side, double large_S): base(side)
		{
			this.large_side = large_S;
		}

		//Methods

		public void CalculateHypotenuse()
		{
			hypotenuse = Math.Sqrt((side * side) + (large_side * large_side));
		}

		//Method that returns but does not receive parameters
		public override string ToString()
		{
			return "" + base.ToString() + "," + large_side;
		}

		//Method that returns and receives parameters:
		public double CalculateArea(double side, double large_S)
		{
			return (side * large_S);
		}

		//Method that does not return but receives parameters

		public string Printhypotenusa(double hypotenuse)
		{
			return "The hypotenuse of the rectangle measures  " + "" + hypotenuse;
		}

		~Rectangular_area()
		{
			
				Console.WriteLine("Destructor called. Cleaning up resources...");
	
		}


	}
}
