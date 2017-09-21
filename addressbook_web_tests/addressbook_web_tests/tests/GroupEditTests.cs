using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupEdit : BaseClass
    {
        [Test]
        public void GroupEditTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups")
                .ClickCheckBox(1)
                .ClickButton("edit");
            Group group = new Group("ModifGroup_(edit)");
            group.Header = "ModifGroup_(edit)_header";
            group.Footer = "ModifGroup_(edit)_footer";
            app.Groups.EditDataGroup(group);
            app.Def.ClickButton("update")
                .ClickId("logo");
            app.Out.ExitAddressbook();
        }
    }
}
