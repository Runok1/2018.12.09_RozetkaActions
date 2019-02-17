using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace _2018._12._09_RozetkaActions.Pages
{
    public class RozetkaBasePage
    {
        public RozetkaBasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
