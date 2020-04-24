using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAMercuryTest.Pages
{
    public abstract class BasePageC : Base
    {
        public BasePageC()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

    }
}
