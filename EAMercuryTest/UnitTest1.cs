using System;
using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAMercuryTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace EAMercuryTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        private IWebDriver _driver;
        string URL = "http://www.newtours.demoaut.com/";

        public void OpenBrowser(BrowserType browserType = BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

        }

        [TestMethod]
        public void TestMethod1()
        {
            //DriverContext.Driver = new ChromeDriver();
            //DriverContext.Driver.Navigate().GoToUrl(URL);

            /*OpenBrowser(BrowserType.Chrome);
            DriverContext.Browser.GoToUrl(URL);*/

            LogHelpers.CreateLogFile();
            OpenBrowser(BrowserType.Chrome);
            LogHelpers.Write("Opened the browser !!!");

            DriverContext.Browser.GoToUrl(URL);
            LogHelpers.Write("Navigated to the page !!!");

            Login();
        }

        public void Login()
        {
            /*LoginPage loginPage = new LoginPage();
            SearchPage searchPage = loginPage.Login("neran", "neran");
            SearchResultsPage searchResultsPage = searchPage.SearchFlight();*/

            /*
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            */

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage = CurrentPage.As<LoginPage>().Login("neran", "neran");
            CurrentPage.As<SearchPage>().SearchFlight();

        }

    }
}
