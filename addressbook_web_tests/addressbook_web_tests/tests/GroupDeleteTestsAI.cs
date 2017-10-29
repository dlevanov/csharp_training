using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDeleteAI : BaseClass
    {
        [Test]
        public void GroupDeleteTestsAI()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups");
            int res1 = app.Def.CountGroupList("span>input");
            if (!(app.Def.IsElementPresent("//*[@id='content']/form/span/input")))
            {
                app.Def.ClickLink("groups")
                .ClickButton("new");
                Group g = new Group("Group_(test_21.09.2017)");
                g.Header = "Group_(test_21.09.2017)_header";
                g.Footer = "Group_(test_21.09.2017)_footer";
                app.Groups.InsertDataGroup(g);
                app.Def.ClickButton("submit");
            }
            app.Def.ClickLink("groups")
                .ClickCheckBox(1)
                .ClickButton("delete");
            int res2 = app.Def.CountGroupList("span>input");
            Assert.AreEqual(res1, res2);
            app.Def.ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
