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
    public class BaseHelper
    {
        public IWebDriver driver;

        public BaseHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
