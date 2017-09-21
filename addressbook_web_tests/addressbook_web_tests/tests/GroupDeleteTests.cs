using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDelete : BaseClass
    {
        [Test]
        public void GroupDeleteTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups")
                .ClickCheckBox(1)
                .ClickButton("delete")
                .ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
