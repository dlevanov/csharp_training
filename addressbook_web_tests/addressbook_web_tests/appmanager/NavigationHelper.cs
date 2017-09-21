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

        public NavigationHelper(IWebDriver driver, string baseURL, DefaultActionsHelper defHelper)
        {
            this.driver = driver;
            this.baseURL = baseURL;
            this.defHelper = defHelper;
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

        public void OpenNextBirthdayPage()
        {
            defHelper.ClickLink("next birthdays");
        }

        public void OpenPrintAllPage()
        {
            defHelper.ClickLink("print all");
        }

        public void OpenPrintPhonesPage()
        {
            defHelper.ClickLink("print phones");
        }

        public void OpenMapPage()
        {
            defHelper.ClickLink("map");
        }

        public void OpenExportPage()
        {
            defHelper.ClickLink("export");
        }

        public void OpenImportPage()
        {
            defHelper.ClickLink("import");
        }
    }
}
