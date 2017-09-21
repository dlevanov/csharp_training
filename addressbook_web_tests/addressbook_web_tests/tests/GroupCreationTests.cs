using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreation : BaseClass
    {
        [Test]
        public void GroupCreationTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups")
                .ClickButton("new");
            Group group = new Group("Group_(test_21.09.2017)");
            group.Header = "Group_(test_21.09.2017)_header";
            group.Footer = "Group_(test_21.09.2017)_footer";
            app.Groups.InsertDataGroup(group);
            app.Def.ClickButton("submit")
                .ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
