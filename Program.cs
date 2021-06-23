using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        string actual ;
        string expected = "Google";
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Inialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        [Test]
        public void Execute()
        {
            //find the element (search bar)
            IWebElement searchbox = driver.FindElement(By.Name("q"));
            // write in search bar
            searchbox.SendKeys("facebook");

            actual = driver.Title;
            Assert.AreEqual(actual, expected);

            IWebElement search = driver.FindElement(By.ClassName("gNO89b"));
            search.Click();
        }
        [TearDown]
        public void EndTest()
        {
            //close browser
            //driver.Quit();
        }
    }
}
