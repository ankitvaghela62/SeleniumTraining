using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumTraining
{
	internal class Program
	{
		static void Main(string[] args)
		{

			char browser;
			driverlaunch dl = new driverlaunch();
			Console.WriteLine("Enter 'c' for chrome and 'e' for edge");
			browser = Console.ReadLine()[0];

			switch (browser)
			{
				case 'c':
					dl.chrome();
					break;
				case 'e':
					dl.edge();
					break;
				default:
					Console.WriteLine("Please enter correct option");
					break;

			}
		}
	}
}

