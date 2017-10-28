using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactDeleteAI : BaseClass
    {
        [Test]
        public void ContactDeleteTestsAI()
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
            app.Def.ClickCheckBox(1)
                .ClickXpath("//*[@id='content']/form[2]/div[2]/input")
                .AcceptAlert();
            app.Out.ExitAddressbook();
        }
    }
}
