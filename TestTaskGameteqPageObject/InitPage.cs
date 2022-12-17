using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PageObject
{
    public class InitPage : BasePage //Страница инициализации "Menu"
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }

        private WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(15)); //явные ожидания 15 сек
        private IWebElement BtnMenu => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("mat-slide-toggle-thumb"))); //кнопка-слайд "Menu" - на странице одна с таким классом

        //МЕТОДЫ
        public void ClickMenu() => BtnMenu.Click(); // метод нажатия на Меню
        
    }
}