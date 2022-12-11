using NUnit.Framework;
using System.Threading;
using PageObject;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;


namespace Tests
{
    public class CreateAppTests : BaseTest
    {
        [Test]
        public void PositiveCreateApp() //создания приложения (позитивный случай)
        {
            InitPage Init = new InitPage(driver); //создаем объект инит страницы
            Init.ClickMenu(); //Нажатие на Меню
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            MenuPage Menu = new MenuPage(driver); //создаем объект страницы "Меню"
            Menu.ClickOffers(); //Нажатие на "Offers"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            OffersPage Offers = new OffersPage(driver); //создаем объект страницы "Offers"
            Offers.ClickAdd(); //Нажатие на "Add" на странице "Offers"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            AddPage Add = new AddPage(driver); // создаем объект страницы "Add" (страница добавления приложения)
            Add.SendTextToName("Filipp"); //вводим текст в поле "name" - имя
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.SendTextToKey("Key123!Ключ"); //вводим текст в поле "key" - ключ
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickFieldNetworks(); //Нажатие в поле "Networks"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickCheckBoxFacebook(); //Нажимаем на чек-бокс "Facebook"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickFieldAddPage(); //нажатие вне списка "Networks", для его закрытия
            Add.ClickFieldGroup(); //нажимаем в поле "Group"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickListElementEngineers(); //нажаимаем на элемент списка "Engineers"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickAddSegment(); //нажимаем на кнопку "Add segment"
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Add.ClickSave(); // нажимаем на кнопку сохранить
            Thread.Sleep(5000); // заменить на Wait (Ожидание)
            Offers.CountAllId();//сосчитаем кол-во элементов для подстановки параметра в Delete selector
            Thread.Sleep(5000); // заменить на Wait (Ожидание)

            //Assert.Pass();
        }
    }
}
