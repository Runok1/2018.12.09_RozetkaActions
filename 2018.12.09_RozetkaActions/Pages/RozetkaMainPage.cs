using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace _2018._12._09_RozetkaActions.Pages
{
    public class RozetkaMainPage : RozetkaBasePage
    {
        public RozetkaMainPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "[href = 'https://rozetka.com.ua/computers-notebooks/c80253/']")]
        public IWebElement partitionLaptopsAndComp;

        [FindsBy(How = How.CssSelector, Using = "[href = 'https://rozetka.com.ua/notebooks/asus/c80004/v004/']")]
        public IWebElement linkAsus;

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/rz-header/header/div/div[2]/ul/li[4]/div/div[1]/a")]
        public IWebElement iconBin;

        [FindsBy(How = How.CssSelector, Using = ".header-actions__dummy-content.header-actions__dummy-content_type_cart")]
        public IWebElement popupBinMsg;

        [FindsBy(How = How.XPath, Using = ("//*[@id='rz-search']/form/div[1]/div[2]/input"))]
        public IWebElement searchField;


    }
}
