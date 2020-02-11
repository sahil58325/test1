using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;



        [TestMethod]
        public void TestMethod1()
        {


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("BD");

        }
        [TestMethod]
        public void TestMethod2()
        {


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("BD IS GOOD");

        }
    }
}
