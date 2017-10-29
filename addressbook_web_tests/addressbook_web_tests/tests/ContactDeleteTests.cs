using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

// Ограничение: тест выполняется при наличии не мене 1 строки в таблице

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactDelete : BaseClass
    {
        [Test]
        public void ContactDeleteTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            int res1 = app.Contacts.CountContactList("td>input");
            string[,] compare1 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
            app.Def.ClickCheckBox(1)
                .ClickXpath("//*[@id='content']/form[2]/div[2]/input")
                .AcceptAlert();
            int res2 = app.Contacts.CountContactList("td>input");
            string[,] compare2 = app.Contacts.ReturnContactList("td>input", "tr td:nth-of-type(3)", "tr td:nth-of-type(2)");
            //Assert.AreEqual(res1, res2+1);
            Assert.IsTrue(app.Contacts.CompareContactList(compare1, compare2, "delete"));
            app.Out.ExitAddressbook();
        }
    }
}
