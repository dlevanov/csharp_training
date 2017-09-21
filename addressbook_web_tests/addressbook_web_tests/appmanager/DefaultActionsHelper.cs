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
    public class DefaultActionsHelper : BaseHelper
    {
        public DefaultActionsHelper(IWebDriver driver) : base(driver)
        {
        }

        public DefaultActionsHelper ClickLink(string linkText)
        {
            driver.FindElement(By.LinkText(linkText)).Click();
            return this;
        }

        public DefaultActionsHelper ClickButton(string name)
        {
            driver.FindElement(By.Name(name)).Click();
            return this;
        }
    }
}
