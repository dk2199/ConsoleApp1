using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArgument("--window-size=1200,800");
            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory,options);
            driver.Navigate().GoToUrl("http://www.wp.pl/");
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
