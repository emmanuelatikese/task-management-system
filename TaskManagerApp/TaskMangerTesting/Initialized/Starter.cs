using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TaskMangerTesting.Initialized
{
    public class Starter
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Start()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44352/";
        }

        [OneTimeTearDown]
        public void Stop()
        {

            driver.Quit();

        }

    }
}
