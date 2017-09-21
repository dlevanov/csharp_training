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
    public class LogoutHelper : BaseHelper
    {
        private DefaultActionsHelper defHelper;

        public LogoutHelper(IWebDriver driver, DefaultActionsHelper defHelper) : base(driver)
        {
            this.defHelper = defHelper;
        }

        public void ExitAddressbook()
        {
            defHelper.ClickLink("home");
            defHelper.ClickLink("Logout");
        }
    }
}
