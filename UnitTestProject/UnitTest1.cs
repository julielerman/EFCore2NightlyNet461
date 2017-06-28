using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.Nightly;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanRunQuery()
        {
            using (var context = new SamuraiContext())
            {
                
                var samurais = context.Samurais.ToList();
                Assert.AreEqual(3,samurais.Count());
            }
        }
    }
}
