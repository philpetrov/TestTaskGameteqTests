using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace PageObject
{
    public class AddPage : BasePage //страница создания приложения (ввода параметров)
    {
        public AddPage(IWebDriver driver) : base(driver)
        {

        }

        //Описание объектов страницы
        private WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(20)); //явные ожидания 10 сек
        private IWebElement FieldName => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("input[placeholder='name']"))); //кнопка-слайд "Menu" - на странице одна с таким классом
        private IWebElement FieldKey => driver.FindElement(By.CssSelector("input[placeholder='key']")); // Поле "key" - уникальный селектор
        private IWebElement FieldNetworks => driver.FindElement(By.Id("mat-select-0")); // Поле "Networks" - уникальный путь
        private IWebElement CheckBoxFacebook => driver.FindElement(By.XPath("//span[text()='Facebook']")); // Чек-бокс "Facebook" - уникальный путь
        private IWebElement FieldAddPage => driver.FindElement(By.CssSelector("div[class='cdk-overlay-backdrop cdk-overlay-transparent-backdrop cdk-overlay-backdrop-showing']")); // Поле вне списка "Networks"
        private IWebElement FieldGroup => driver.FindElement(By.Id("mat-select-1")); // Поле "Group" - уникальный путь
        private IWebElement ListElementEngineers => driver.FindElement(By.XPath("//span[text()=' Engineers ']")); // Элемент списка "Engineers" - уникальный путь
        private IWebElement BtnAddSegment => driver.FindElement(By.XPath("//span[text()=' Add segment ']")); // Кнопка "Add segment" - уникальный путь
        private IWebElement BtnSave => driver.FindElement(By.XPath("//span[text()=' Save ']")); // Кнопка "Save" - уникальный путь

        //Объекты для ввода
        public string TextToNameForInsert = "Filipp";
        public string TextToKeyForInsert = "Key123!Ключ";
 
        //МЕТОДЫ
        public void SendTextToName() => FieldName.SendKeys(TextToNameForInsert); //метод ввода текста в поле "name"
        public void SendTextToKey() => FieldKey.SendKeys(TextToKeyForInsert); //метод ввода текста в поле "key"
        public void ClickFieldNetworks() => FieldNetworks.Click(); //метод нажатия в поле "Networks"
        public void ClickCheckBoxFacebook() => CheckBoxFacebook.Click(); //метод нажатия на чек-бокс "Facebook"
        public void ClickFieldAddPage() => FieldAddPage.Click(); //метод нажатия на Область вне выпадающего списка "Networks", для его закрытия
        public void ClickFieldGroup() => FieldGroup.Click(); //метод нажатия в поле "Group"
        public void ClickListElementEngineers() => ListElementEngineers.Click(); //метод нажатия на элемент списка "Engineers"
        public void ClickAddSegment() => BtnAddSegment.Click(); //метод нажатия на кнопку "Add segment"
        public void ClickSave() => BtnSave.Click(); //метод нажатия на кнопку "Save"

    }
}
