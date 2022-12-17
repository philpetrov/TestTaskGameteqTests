using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://test-task.gameteq.com/"); //переход на тестовую страницу
            driver.Manage().Window.Maximize(); //браузер на полный экран
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
