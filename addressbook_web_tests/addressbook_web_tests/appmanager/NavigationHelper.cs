using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class NavigationHelper
    {
        private IWebDriver driver;
        private string baseURL;
        private DefaultActionsHelper defHelper;

        public NavigationHelper(IWebDriver driver, string baseURL)
        {
            this.driver = driver;
            this.baseURL = baseURL;
            //defHelper = new DefaultActionsHelper(driver);
        }

        public void AuthAddressbook(string login, string password)
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(login);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        public void OpenGroupsPage()
        {
            defHelper.ClickLink("group");
        }

        public void OpenContactsPage()
        {
            defHelper.ClickLink("home");
        }
    }
}
