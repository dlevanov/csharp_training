﻿using System;
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

        public DefaultActionsHelper ClickId(string id)
        {
            driver.FindElement(By.Id(id)).Click();
            return this;
        }

        public DefaultActionsHelper ClickXpath(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
            return this;
        }

        public DefaultActionsHelper ClickCss(string css)
        {
            driver.FindElement(By.CssSelector(css)).Click();
            return this;
        }

        public DefaultActionsHelper ClickCheckBox(int num)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + num + "]")).Click();
            return this;
        }

        public DefaultActionsHelper AcceptAlert()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public bool IsElementPresent(string xpath)
        {
            try
            {
                driver.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public int CountGroupList(string css)
        {
            driver.FindElement(By.LinkText("groups")).Click();
            ICollection<IWebElement> elm = driver.FindElements(By.CssSelector(css));
            if (elm.Count == 0)
            {
                return 1;
            }
            else
            {
                return elm.Count;//Console.WriteLine(elmArr.Count);
            }                
        }
    }
}
