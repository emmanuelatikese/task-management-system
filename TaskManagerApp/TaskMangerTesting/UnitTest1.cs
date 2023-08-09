using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TaskMangerTesting.Initialized;

namespace TaskMangerTesting
{
    [TestFixture]
    public class Tests: Starter
    {


        [Test, Category("First Test")]
        [Description("Add a task to it.")]

        public void Test1()
        {



            IWebElement EmailTextField = driver.FindElement(By.XPath(".//*[@id='exampleFormControlInput1']"));
            EmailTextField.SendKeys("First test");
            IWebElement buttonElement = driver.FindElement(By.Id("InputAdd"));
            buttonElement.Click();



        }

        }
    
}