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
    class LoginPage : BasePageC
    {
       
        [FindsBy(How=How.Name, Using = "userName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        IWebElement btnSignIn { get; set; }

        public SearchPage Login(String UserName, String Password)
        {
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            btnSignIn.Click();
            return new SearchPage();
        }
    }
}
