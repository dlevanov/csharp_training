using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactDelete : BaseClass
    {
        [Test]
        public void ContactDeleteTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickCheckBox(1)
                .ClickXpath("//*[@id='content']/form[2]/div[2]/input")
                .AcceptAlert();
            app.Out.ExitAddressbook();
        }
    }
}
