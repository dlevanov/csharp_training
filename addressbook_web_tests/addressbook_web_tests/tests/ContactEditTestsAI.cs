using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactEditAI : BaseClass
    {
        [Test]
        public void ContactEditTestsAI()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            if (!(app.Def.IsElementPresent("//*[@id='maintable']/tbody/tr[2]/td[7]/a/img")))
            {
                app.Def.ClickLink("add new");
                Contact c = new Contact("Фамилия 2", "Имя 2");
                c.Middlename = "";
                c.Nickname = "";
                c.Title = "";
                c.Company = "";
                c.Address = "г.Симсити, ул.Садовая, д.2";
                c.Home = "";
                c.Mobile = "+2(222)222-22-22";
                c.Work = "";
                c.Fax = "";
                c.Email = "";
                c.Email2 = "";
                c.Email3 = "";
                c.Homepage = "";
                c.Address2 = "";
                c.Phone2 = "";
                c.Notes = "";
                app.Contacts.InsertDataContact(c);
                app.Def.ClickButton("submit");
            }
            app.Def.ClickLink("home");
            app.Def.ClickXpath("(//img[@alt='Edit'])[" + 1 + "]");
            Contact contact = new Contact("Фамилия 4", "Имя 4");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "г.Симсити, ул.Садовая, д.4";
            contact.Home = "";
            contact.Mobile = "+4(444)444-44-44";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Address2 = "";
            contact.Phone2 = "";
            contact.Notes = "";
            app.Contacts.EditDataContact(contact);
            app.Def.ClickButton("update")
                .ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
