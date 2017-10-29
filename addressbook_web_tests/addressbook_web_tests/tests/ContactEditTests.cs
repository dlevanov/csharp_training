using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

// Ограничение: тест выполняется при наличии не мене 1 строки в таблице

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactEdit : BaseClass
    {
        [Test]
        public void ContactEditTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            int res1 = app.Contacts.CountContactList("td>input");
            string[,] compare1 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
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
            app.Def.ClickButton("update");
            int res2 = app.Contacts.CountContactList("td>input");
            string[,] compare2 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
            //Assert.AreEqual(res1, res2);
            Assert.IsTrue(app.Contacts.CompareContactList(compare1, compare2, "modif"));
            app.Def.ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
