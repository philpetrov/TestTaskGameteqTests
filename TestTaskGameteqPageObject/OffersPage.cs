using OpenQA.Selenium;
using System;

namespace PageObject
{
    public class OffersPage : BasePage //страница со списком созданных приложений
    {
        public OffersPage(IWebDriver driver) : base(driver)
        {

        }

        
        private IWebElement BtnAdd => driver.FindElement(By.CssSelector("button[class='mat-raised-button mat-button-base mat-primary ng-star-inserted']")); // Кнопка "Add" - уникальный класс
        int AllId => driver.FindElements(By.XPath("/html/body/app-root/mat-sidenav-container/mat-sidenav-content/app-list/table/tbody/tr")).Count; //Все Id элементы на странице

        //МЕТОДЫ
        public void ClickAdd() => BtnAdd.Click(); //метод нажатия на кнопку "Add"
        public void CountAllId() => Console.WriteLine("кол-во Id " + AllId);

        //цикл метод поиска по ключу (какой по счету?)

    }

}
