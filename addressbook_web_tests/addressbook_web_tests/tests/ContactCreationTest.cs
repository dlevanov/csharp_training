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
            app.Out.ExitAddressbook();
        }
    }
}
