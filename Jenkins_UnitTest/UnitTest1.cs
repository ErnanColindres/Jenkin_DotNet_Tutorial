using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Jenkins_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Jenkin_DotNet_Tutorial.Program.Main();

                var result = sw.ToString().Trim();
                Assert.IsTrue(result.Contains("Hello") && result.Contains("World"));

            }
        }
    }
}
