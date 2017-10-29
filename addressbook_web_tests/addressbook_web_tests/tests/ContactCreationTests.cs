using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreation : BaseClass
    {
        [Test]
        public void ContactCreationTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            int res1 = app.Contacts.CountContactList("td>input");
            string[,] compare1 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
            app.Def.ClickLink("add new");
            Contact contact = new Contact("Фамилия 2", "Имя 2");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "г.Симсити, ул.Садовая, д.2";
            contact.Home = "";
            contact.Mobile = "+2(222)222-22-22";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Address2 = "";
            contact.Phone2 = "";
            contact.Notes = "";
            app.Contacts.InsertDataContact(contact);
            app.Def.ClickButton("submit");
            int res2=app.Contacts.CountContactList("td>input");
            string[,] compare2 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
            //Assert.AreEqual(res1,res2-1);
            Assert.IsTrue(app.Contacts.CompareContactList(compare1, compare2, "create"));
            app.Def.ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
