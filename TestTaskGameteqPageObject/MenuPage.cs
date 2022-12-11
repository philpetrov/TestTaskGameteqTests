using OpenQA.Selenium;

namespace PageObject
{
    public class MenuPage : BasePage //выездная страница с 2-умя кнопками "Dashboard" и "Offer" (Menu)
    {
        public MenuPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement BtnDashboard => driver.FindElement(By.CssSelector("button[routerlink='/dashboard']")); //Кнопка "Dashboard" - уникальный локатор
        private IWebElement BtnOffers => driver.FindElement(By.CssSelector("button[routerlink='/list']")); //Кнопка "Offers" - уникальный локатор

        public void ClickDashboard() => BtnDashboard.Click(); //метод нажатия на кнопку "Dashboard"
        public void ClickOffers() => BtnOffers.Click(); //метод нажатия на кнопку "Offers"


    }
}