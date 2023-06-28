using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTraining
{
	internal class driverlaunch
	{
		public string url="https://computer-database.gatling.io/computers";
		IWebElement addclick = null;
		IWebDriver driver = null;
		String cname = "CompName";
		String intro = "1998-02-22";
		String disconti = "2000-12-02";
		public void chrome()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl(url);
			addclick = driver.FindElement(By.Id("add"));
			addclick.Click();
			IWebElement compname = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
			IWebElement intorduced = driver.FindElement(By.XPath("//*[@id=\"introduced\"]"));
			IWebElement discontinue = driver.FindElement(By.XPath("/html/body/section/form/fieldset/div[3]/div/input"));
			IWebElement company = driver.FindElement(By.XPath("/html/body/section/form/fieldset/div[4]/div/select"));
			SelectElement cmp = new SelectElement(company);
			compname.SendKeys(cname);
			intorduced.SendKeys(intro);
			discontinue.SendKeys(disconti);
			cmp.SelectByIndex(4);

		}

	


		public void chromeentries()
        {
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl(url);
			
		
			
			
			      for (int i = 0; i < 5; i++)
				  
			      {

				        addclick = driver.FindElement(By.Id("add"));
				        addclick.Click();      
						IWebElement compname = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
						IWebElement intorduced = driver.FindElement(By.XPath("//*[@id=\"introduced\"]"));
						IWebElement discontinue = driver.FindElement(By.XPath("/html/body/section/form/fieldset/div[3]/div/input"));
						IWebElement company = driver.FindElement(By.XPath("/html/body/section/form/fieldset/div[4]/div/select"));
						SelectElement cmp = new SelectElement(company);
						compname.SendKeys(cname);
						intorduced.SendKeys(intro);
						discontinue.SendKeys(disconti);
						cmp.SelectByIndex(4);
						IWebElement btnsub = driver.FindElement(By.XPath("//*[@id=\"main\"]/form/div/input"));
						btnsub.Click();
				        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


				  }
			Console.WriteLine("all the 5 computers are added!!!");

			


		}


	}
}
