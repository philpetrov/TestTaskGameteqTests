using OpenQA.Selenium;

namespace PageObject
{
    public class BasePage //Базовая страница
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;

        }
    }
}
