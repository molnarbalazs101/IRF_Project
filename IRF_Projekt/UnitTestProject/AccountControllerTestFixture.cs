using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_Projekt;
using NUnit.Framework;

namespace UnitTestProject
{
    public class AccountControllerTestFixture
    {
        [Test,
            TestCase("+3630260920a", false),
            TestCase("2609205", false),
            TestCase("+362609231", false),
            TestCase("202609231",false),
            TestCase("+36/30-260-92054",false),
            TestCase("+36302609205", false),
            TestCase("+36/30-260-9205", true)]


        public void TestValidatePhoneNumber(string phoneNumber, bool ExpectedResult)
        {
            var result = Helpers.IsPhoneNumber(phoneNumber);
            Assert.AreEqual(result, ExpectedResult);
        }





    }
}
