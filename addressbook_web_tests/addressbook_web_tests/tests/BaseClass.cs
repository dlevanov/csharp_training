using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    public class BaseClass
    {
        protected ApplicationManager app;

        [SetUp]
        protected void SetupTest()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        protected void TeardownTest()
        {
            app.Stop();
        }
    }
}
