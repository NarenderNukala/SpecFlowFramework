using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAMercuryTest.Pages
{
    class SearchResultsPage
    {
        [FindsBy(How = How.Name, Using = "passCount")]
        public IWebElement lstPassengerCount { get; set; }

    }
}
