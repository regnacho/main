using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;


namespace WpfSupportLibs.Blah
{
    public class Class1
    {
        [Test]
        public void SomeTest()
        {
            var repo = new MockRepository(MockBehavior.Loose);
        }
    }
}
