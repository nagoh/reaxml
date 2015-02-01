using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Reaxml.Test.Unit.Serializer
{
    [TestFixture]
    public class SerializerTest
    {
        [Test]
        public void should_serilailze()
        {
            using (var file = File.Open(@"TestFiles\residential_current.xml", FileMode.Open))
            {
                var serializer = new Common.Serializer();
                var result = serializer.Serialize(file);
            }

            var xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><propertyList></propertyList>";
            using (var ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(xml)))
            {
                var serializer = new Common.Serializer();
                var result = serializer.Serialize(ms);
            }
        }
    }
}
