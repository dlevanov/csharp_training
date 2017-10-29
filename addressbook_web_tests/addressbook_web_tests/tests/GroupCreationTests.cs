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
            int res1 = app.Def.CountGroupList("span>input");
            app.Def.ClickButton("new");
            Group group = new Group("Group_(test_21.09.2017)");
            group.Header = "Group_(test_21.09.2017)_header";
            group.Footer = "Group_(test_21.09.2017)_footer";
            app.Groups.InsertDataGroup(group);
            app.Def.ClickButton("submit");
            int res2 = app.Def.CountGroupList("span>input");
            Assert.AreEqual(res1, res2-1);
            app.Def.ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
