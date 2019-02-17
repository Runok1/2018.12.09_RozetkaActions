using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Threading;

using _2018._12._09_RozetkaActions.Pages;
using System.Drawing;

namespace _2018._12._09_RozetkaActions
{
    public class RozetkaActionTests
    {
        IWebDriver chromeDriver;
        Actions actions;

       [SetUp]
        public void SetUp()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //chromeDriver.Manage().Window.Size = new Size(1024, 768);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://rozetka.com.ua/ua/");
            actions = new Actions(chromeDriver);
        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Quit();
        }

        [Test]
        public void TestGoToAsus()
        {
            //Arrange

            //Act
            RozetkaMainPage rozetkaMainPage = new RozetkaMainPage(chromeDriver);
            Actions actions = new Actions(chromeDriver);
            actions.MoveToElement(rozetkaMainPage.partitionLaptopsAndComp, 15, 15).Perform();
            Thread.Sleep(100);
            actions.MoveToElement(rozetkaMainPage.linkAsus).Click(rozetkaMainPage.linkAsus).Perform();
            Thread.Sleep(1000);
            //Assert
        }

        [Test]
        public void GetBinText()
        {
            //Arrange
            var binText = "";

            //Act
            RozetkaMainPage rozetkaMainPage = new RozetkaMainPage(chromeDriver);
            Actions actions = new Actions(chromeDriver);
            actions.MoveToElement(rozetkaMainPage.iconBin).Perform();
            Thread.Sleep(100);
            binText =  rozetkaMainPage.popupBinMsg.Text;
            Console.WriteLine(binText);

            //Assert

        }

    }
}
