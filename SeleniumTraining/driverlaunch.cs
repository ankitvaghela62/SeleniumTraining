using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumTraining
{
	internal class driverlaunch
	{
		public string url="https://computer-database.gatling.io/computers";
		IWebElement addclick = null;
		IWebDriver driver = null;
		public void chrome()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl(url);
			addclick = driver.FindElement(By.Id("add"));
			addclick.Click();
			driver.Quit();	
        }

		public void edge()
		{
			driver = new EdgeDriver();
			driver.Navigate().GoToUrl(url);
			addclick = driver.FindElement(By.Id("add"));
			addclick.Click();
			driver.Quit();
		}


	}
}
