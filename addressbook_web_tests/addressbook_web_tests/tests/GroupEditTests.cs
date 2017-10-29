using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

// Ограничение: тест выполняется при наличии не мене 1 строки в таблице

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupEdit : BaseClass
    {
        [Test]
        public void GroupEditTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups");
            int res1 = app.Def.CountGroupList("span>input");
            app.Def.ClickCheckBox(1)
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
