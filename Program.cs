using System;
using static System.Console;
namespace DZ5_CSharp
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Program1();
			//Program2();
			Program3();
			ReadKey(true);

		}


		static void Program1()
		{
            Magazine mgz1 = new Magazine();
			
            mgz1.FillInfo();
            mgz1.PrintInfo();
        }

		static void Program2()
        {
			Shopp shp = new Shopp();

			shp.FillInfo();
			shp.PrintInfo();
        }

        static void Program3()
        {
			Running running = new Running();
			running.Run();
        }

    }
}


