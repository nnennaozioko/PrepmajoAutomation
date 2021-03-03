using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace PrepMajorAutomation.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()

           
        {

            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver = new ChromeDriver(@"C:\Users\nelyt\source\repos\PrepMajorAutomation\bin\Debug\netcoreapp3.1");

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose(); 
           
        }
    }
}
