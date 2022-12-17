using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObject
{
    public class MenuPage : BasePage //выездная страница с 2-умя кнопками "Dashboard" и "Offer" (Menu)
    {
        public MenuPage(IWebDriver driver) : base(driver)
        {

        }
        private WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(20));  //явные ожидания 10 сек
        private IWebElement BtnDashboard => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[routerlink='/dashboard']")));
        private IWebElement BtnOffers => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[routerlink='/list']")));


        public void ClickDashboard() => BtnDashboard.Click(); //метод нажатия на кнопку "Dashboard"
        public void ClickOffers() => BtnOffers.Click(); //метод нажатия на кнопку "Offers"


    }
}