using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAMercuryTest.Pages
{
    class SearchPage : BasePageC
    {

        [FindsBy(How = How.Name, Using = "passCount")]
        IWebElement lstPassengerCount { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Business']")]
        IWebElement chkBusinessClass { get; set; }
        
        [FindsBy(How = How.Name, Using = "findFlights")]
        IWebElement btnFindFlights { get; set; }

        public SearchResultsPage SearchFlight()
        {
            new SelectElement(lstPassengerCount).SelectByValue("3");
            chkBusinessClass.Click();
            btnFindFlights.Click();
            return new SearchResultsPage();
        }
    }
}
