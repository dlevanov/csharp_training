using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactEdit : BaseClass
    {
        [Test]
        public void ContactEditTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
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
