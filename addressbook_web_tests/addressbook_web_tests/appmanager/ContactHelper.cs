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
    public class ContactHelper : BaseHelper
    {
        public ContactHelper(IWebDriver driver) : base(driver)
        {
        }

        public ContactHelper SubmitDataContact()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }

        public ContactHelper InsertDataContact(Contact contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contact.Home);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contact.Work);
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(contact.Fax);
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
/*          new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("11");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("March");
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys("1234");
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("17");
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("March");
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys("1234");
            new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("aaaaa");
*/          driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contact.Address2);
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(contact.Phone2);
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);
            return this;
        }

        public ContactHelper EditDataContact(Contact contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(contact.Home);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contact.Work);
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(contact.Fax);
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
            /*          new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("11");
                        new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("March");
                        driver.FindElement(By.Name("byear")).Clear();
                        driver.FindElement(By.Name("byear")).SendKeys("1234");
                        new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("17");
                        new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("March");
                        driver.FindElement(By.Name("ayear")).Clear();
                        driver.FindElement(By.Name("ayear")).SendKeys("1234");
                        new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("aaaaa");
            */
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contact.Address2);
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(contact.Phone2);
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);
            return this;
        }

        public int CountContactList(string css)
        {
            driver.FindElement(By.LinkText("home")).Click();
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

        public string[,] ReturnContactList(string css, string nm, string snm)
        {
            ICollection<IWebElement> elmID = driver.FindElements(By.CssSelector(css));
            ICollection<IWebElement> Name = driver.FindElements(By.CssSelector(nm));
            ICollection<IWebElement> Surname = driver.FindElements(By.CssSelector(snm));
            string[,] R = null;

            if (elmID.Count == 0)
            {
                return R;
            }
            else
            {
                string data = null;

                string[] arrID = new string[elmID.Count];
                string[] arrName = new string[elmID.Count];
                string[] arrSurname = new string[elmID.Count];

                string[,] resArray = new string[3, elmID.Count];

                foreach (var item in elmID)
                {
                    data = item.GetAttribute("id");
                    for (int i = 0; i < elmID.Count; i++)
                    {
                        arrID[i] = data;
                    }
                    //Console.WriteLine(item.GetAttribute("id"));
                }
                foreach (var item in Name)
                {
                    data = item.Text;
                    for (int i = 0; i < Name.Count; i++)
                    {
                        arrName[i] = data;
                    }
                    //Console.WriteLine(item.Text);
                }
                foreach (var item in Surname)
                {
                    data = item.Text;
                    for (int i = 0; i < Surname.Count; i++)
                    {
                        arrSurname[i] = data;
                    }
                    //Console.WriteLine(item.Text);
                }
                for (int i = 0; i < elmID.Count; i++)
                {
                    resArray[0, i] = arrID[i];
                    resArray[1, i] = arrName[i];
                    resArray[2, i] = arrSurname[i];
                }
                R = resArray;
                //Console.WriteLine(resArray[2,1]);  
                return R;
            }        
        }

        public bool CompareContactList(string[,] oldData, string[,] newData, string option)
        {
            if (oldData == null || newData == null)
            {
                return true;
            }
            bool R = false;
            int Cnt = 0;
            int maxIndexK = 0;

            if (oldData.Length < newData.Length)
            {
                Cnt = oldData.Length;
                //Console.WriteLine("old "+ oldData.Length);
            }
            else
            {
                Cnt = newData.Length;
                //Console.WriteLine("new " + newData.Length);
            }

            if (Cnt / 3 == 1)
            {
                return true;
            }

            switch (option)
            {
                case "create":
                    maxIndexK = 0;
                    break;
                case "delete":
                    maxIndexK = 1;
                    break;
                case "modif":
                    maxIndexK = 1;
                    break;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Cnt / 3; j++)
                {
                    for (int k = maxIndexK; k < Cnt / 3; k++)
                    {
                        if (oldData[i, j] == newData[i, k])
                        {
                            //Console.WriteLine("true");
                            //Console.WriteLine(oldData[i, j] + "==" + newData[i, j]);
                            R = true;
                        }
                        else
                        {
                            //Console.WriteLine("false");
                            R = false; return false;
                        }
                    }
                }
            } return R;
        }
    }
}
