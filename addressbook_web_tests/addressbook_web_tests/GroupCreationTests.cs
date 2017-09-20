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
            AuthAddressbook("admin", "secret");
            ClickLink("groups");
            ClickButton("new");
            Group group = new Group("Group_(test_20.09.2017)");
            group.Header = "Group_(test_20.09.2017)_header";
            group.Footer = "Group_(test_20.09.2017)_footer";
            InsertDataGroup(group);
            ClickButton("submit");
            ExitAddressbook();
        }
    }
}
