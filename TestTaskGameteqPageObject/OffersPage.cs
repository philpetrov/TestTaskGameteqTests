using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using PageObject;
using System.Threading.Tasks;

namespace PageObject
{
    public class OffersPage : BasePage //страница со списком созданных приложений
    {
        public OffersPage(IWebDriver driver) : base(driver)
        {


        }
        //Объекты страницы с ожиданиями
        private WebDriverWait Wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));  //явные ожидания 10 сек
        private IWebElement BtnAdd => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[class='mat-raised-button mat-button-base mat-primary ng-star-inserted']"))); // Кнопка "Add" - уникальный класс
        private IWebElement BtnDelete => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("tr:nth-child(" + AllId + ") > td[class='mat-cell cdk-column-actions mat-column-actions ng-star-inserted'] > button[class='mat-raised-button mat-button-base mat-warn']")));
        private IWebElement BtnYes => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[text()='yes!']"))); //кнопка подтверждения удаления из списка
        public string LastCreatedTextId => driver.FindElement(By.CssSelector("tr:nth-child(" + AllId + ") > td.mat-cell.cdk-column-id.mat-column-id.ng-star-inserted")).Text; //текстовое значения поля Id на странице списка (последнее созданное)
        public string LastCreatedTextName => driver.FindElement(By.CssSelector("tr:nth-child(" + AllId + ") > td.mat-cell.cdk-column-name.mat-column-name.ng-star-inserted")).Text; //текстовое значения поля Name на странице списка (последнее созданное)
        public string LastCreatedTextKey => driver.FindElement(By.CssSelector("tr:nth-child(" + AllId + ") > td.mat-cell.cdk-column-key.mat-column-key.ng-star-inserted")).Text; //текстовое значения поля Key на странице списка (последнее созданное)
        public int AllId => driver.FindElements(By.CssSelector("body > app-root > mat-sidenav-container > mat-sidenav-content > app-list > table > tbody > tr")).Count; //Все Id элементы на странице  

        //МЕТОДЫ
        public void ClickAdd() => BtnAdd.Click(); //метод нажатия на кнопку "Add"
        public void CountRowsOffers() => Console.WriteLine("кол-во строк на странице Offers = " + AllId); //кол-во приложений на странице
        public void PrintCountTextId() => Console.WriteLine("кол-во Id Print " + AllId); //кол-во приложений на странице
        public void CountAllIdPrint() => Console.WriteLine("кол-во Id " + AllId); //кол-во приложений на странице
        public void ClickDelete() => BtnDelete.Click(); //метод нажатия на кнопку "Delete"
        public void ClickYes() => BtnYes.Click(); //метод нажатия на кнопку "yes!", подтверждение удаления
        public void PrintTextCreatedApp() => Console.WriteLine("Параметры созданного приложения: " + "Id: " + LastCreatedTextId + " " + "Name: " + LastCreatedTextName + " " + "Key: " + LastCreatedTextKey); //Текст id, name, key последнего созданного приложения


        //public async Task awaitsAsync() => await expect(await LastCreatedTextNameElem).toEqual(0); //проверяем отсутствие объекта на странице

        //Assert.IsTrue(actualvalue.Contains("Key123!Ключ"), actualvalue + "Созданное приложение успешно удалено");

        //Assert.That(firstRow.Text, Does.Contain("SomeText"));

        //Assert.assertEquals(ExpectedTitle, KeyFieldText.Text);

        //Assert.AreEqual("Expected Results", driver.Title);///


    }
}