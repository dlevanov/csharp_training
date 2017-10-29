using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupEditAI : BaseClass
    {
        [Test]
        public void GroupEditTestsAI()
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
                .ClickButton("edit");
            Group group = new Group("ModifGroup_(edit)");
            group.Header = "ModifGroup_(edit)_header";
            group.Footer = "ModifGroup_(edit)_footer";
            app.Groups.EditDataGroup(group);
            app.Def.ClickButton("update");
            int res2 = app.Def.CountGroupList("span>input");
            Assert.AreEqual(res1, res2);
            app.Def.ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
