﻿using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAMercuryTest.Pages
{
    public class Base
    {
        public BasePageC CurrentPage { get; set; }
        private IWebDriver _driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePageC, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePageC
        {
            return (TPage)this;
        }
    }
}