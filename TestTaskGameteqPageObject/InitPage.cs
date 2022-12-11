using OpenQA.Selenium;

namespace PageObject
{
    public class InitPage : BasePage //Страница инициализации "Menu"
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement BtnMenu => driver.FindElement(By.ClassName("mat-slide-toggle-thumb")); //кнопка-слайд "Menu" - на странице одна с таким классом

        public void ClickMenu() => BtnMenu.Click();
    }
}