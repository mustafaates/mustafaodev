using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    class Program
    {
        static void Main(string[] args)
        {

          
            
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);


            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("atesmustafa25@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("12332112");
            driver.FindElement(By.Id("loginButton")).Click();


            driver.FindElement(By.Id("searchData")).SendKeys("Bilgisayar");
            driver.FindElement(By.ClassName("searchBtn")).Click();

            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id='p-107402167']/div[1]/a")).Click();

            driver.FindElement(By.ClassName("btnAddBasket")).Click();

        }
    }
}
