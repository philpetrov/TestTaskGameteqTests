using NUnit.Framework;
using System.Threading;
using PageObject;
using System;


namespace Tests
{
    public class CreateAppTests : BaseTest
    {
        
            [Test]
        public void PositiveCreateAndDeleteApp() //создание и удаление приложения (позитивный кейс)
        {
            InitPage Init = new InitPage(driver); //создаем объект инит страницы
            Init.ClickMenu(); //Нажатие на Меню
            MenuPage Menu = new MenuPage(driver); //создаем объект страницы "Меню"
            Menu.ClickOffers(); //Нажатие на "Offers"
            OffersPage Offers = new OffersPage(driver); //создаем объект страницы "Offers"
            Offers.ClickAdd(); //Нажатие на "Add" на странице "Offers"
            AddPage Add = new AddPage(driver); // создаем объект страницы "Add" (страница добавления приложения)
            Add.SendTextToName(); //вводим текст в поле "name" - имя
            Add.SendTextToKey(); //вводим текст в поле "key" - ключ
            Add.ClickFieldNetworks(); //Нажатие в поле "Networks"
            Add.ClickCheckBoxFacebook(); //Нажимаем на чек-бокс "Facebook"
            Add.ClickFieldAddPage(); //нажатие вне списка "Networks", для его закрытия
            Add.ClickFieldGroup(); //нажимаем в поле "Group"
            Add.ClickListElementEngineers(); //нажаимаем на элемент списка "Engineers"
            Add.ClickAddSegment(); //нажимаем на кнопку "Add segment"
            Add.ClickSave(); // нажимаем на кнопку сохранить                                                                                                                                                                                                                                              
            Thread.Sleep(5000); //не явно ждем прогрузку офферс
            Console.WriteLine("Приложение создано, перенаправление на страницу Offers"); //залогируем после Save 
            Offers.CountRowsOffers();//залогируем сосчитанное на странице Offers кол-во строк 
            int FirstCountApps = Offers.AllId;// Кол-во до удаления
            string LastCreatedTextIdFirst = Offers.LastCreatedTextId; //фиксируем последний Id созданный нами
            Offers.PrintTextCreatedApp(); //принт текст id, key, name последнего созданного ключа
            Assert.AreEqual(Add.TextToNameForInsert, Offers.LastCreatedTextName); //проверка, что заведенное Name = выведенному после создания приложения
            Console.WriteLine("Проверка выведенного в списке Name: " + Add.TextToNameForInsert + " равно заведенному: " + Offers.LastCreatedTextName); //залогируем проверку (что она действительно работает)
            Assert.AreEqual(Add.TextToKeyForInsert, Offers.LastCreatedTextKey); //проверка, что заведенное Key = выведенному после создания приложения
            Console.WriteLine("Проверка выведенного в списке Key: " + Add.TextToKeyForInsert + " равно заведенному ранее: " + Offers.LastCreatedTextKey); //залогируем проверку (что она действительно работает)
            Offers.ClickDelete(); //удаляем созданное приложение
            Offers.ClickYes(); // подтверждаем удаление
            Thread.Sleep(5000); //не явно ждем прогрузку офферс для дальнейшего подсчета и проверок
            Offers.CountRowsOffers();//залогируем сосчитанное на странице Offers кол-во строк
            Assert.AreNotEqual(FirstCountApps, Offers.AllId); //проверка, что количество приложений уменьшилось на 1 
            Console.WriteLine("Кол-во строк сразу после создания: " + FirstCountApps + " не равно " + "кол-ву строк после удаления последнего: " + (Offers.AllId)); //залогируем проверку (что она действительно работает)
            Assert.AreNotEqual(LastCreatedTextIdFirst, Offers.LastCreatedTextId); //проверка, что именно последний Id не соответствует последему созданному нами, значит он действительно был удален
            Console.WriteLine("Последний ID сразу после создания: " + LastCreatedTextIdFirst + " не равен" + "последнему ID сразу после удаления: " + Offers.LastCreatedTextId); //залогируем проверку (что она действительно работает)
        }


    }

}
