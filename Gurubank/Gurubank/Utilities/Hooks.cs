using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Gurubank.Utilities
{
    [Binding]
    public class Hooks
    {
        public static WebDriver driver;
        [BeforeScenario]

        public void BeforeScenatrio()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
        }

        [AfterScenario]
        public void AfterScenario()
        {
           // driver.Quit();
        }
    }
}
