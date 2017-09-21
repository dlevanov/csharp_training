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
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected DefaultActionsHelper defHelper;
        protected LoginHelper loginHelper;
        protected LogoutHelper logoutHelper;
        protected NavigationHelper navHelper;
        protected ContactHelper contactHelper;
        protected GroupHelper groupHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver(new FirefoxBinary("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe"), new FirefoxProfile());
            baseURL = "http://localhost/";

            defHelper = new DefaultActionsHelper(driver);
            loginHelper = new LoginHelper(driver, baseURL);
            logoutHelper = new LogoutHelper(driver, defHelper);
            navHelper = new NavigationHelper(driver, baseURL);
            contactHelper = new ContactHelper(driver);
            groupHelper = new GroupHelper(driver);
        }

        public void Stop()
        {
            driver.Quit();
        }

        public LoginHelper Auth
        {
            get { return loginHelper; }
        }

        public LogoutHelper Out
        {
            get { return logoutHelper; }
        }

        public NavigationHelper Nav
        {
            get { return navHelper; }
        }

        public DefaultActionsHelper Def
        {
            get { return defHelper; }
        }

        public ContactHelper Contacts
        {
            get { return contactHelper; }
        }

        public GroupHelper Groups
        {
            get { return groupHelper; }
        }

    }
}
