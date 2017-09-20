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
            AuthAddressbook("admin", "secret");
            ClickLink("add new");
            Contact contact = new Contact("Думадельников", "Тихомир");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "г.Симсити, ул.Садовая, д.11";
            contact.Home = "";
            contact.Mobile = "+7(900)000-11-22";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Address2 = "";
            contact.Phone2 = "";
            contact.Notes = "";
            InsertDataContact(contact);
            ClickButton("submit");
            ExitAddressbook();
        }
    }
}
