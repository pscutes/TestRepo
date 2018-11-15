using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;namespace contosounittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"C:\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:41787/");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            
            
        }
    }
}
