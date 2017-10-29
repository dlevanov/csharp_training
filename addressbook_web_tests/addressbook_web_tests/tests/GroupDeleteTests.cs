using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

// Ограничение: тест выполняется при наличии не мене 1 строки в таблице

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDelete : BaseClass
    {
        [Test]
        public void GroupDeleteTests()
        {
            app.Auth.AuthAddressbook("admin", "secret");
            app.Def.ClickLink("groups");
            int res1 = app.Def.CountGroupList("span>input");
            app.Def.ClickCheckBox(1)
                .ClickButton("delete")
                .ClickId("logo");
            int res2 = app.Def.CountGroupList("span>input");
            Assert.AreEqual(res1, res2+1);
            app.Out.ExitAddressbook();
        }
    }
}
