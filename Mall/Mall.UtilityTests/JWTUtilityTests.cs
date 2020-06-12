using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mall.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.Utility.Tests
{
    [TestClass()]
    public class JWTUtilityTests
    {
        [TestMethod()]
        public void JWTUtilityTest()
        {
            string secret = "JwtUtility";
            string encodeStr = JWTUtility.JwtEncode(new JwtObj { Key = "Key", Value = "Value" }, secret);
            JwtObj obj = JWTUtility.JwtDecode<JwtObj>(encodeStr, secret);
            Assert.IsNotNull(obj);
            Assert.AreEqual(obj.Key, "Key");
            Assert.AreEqual(obj.Value, "Value");
        }
    }

    public class JwtObj
    {
        public string Key { get; set; }

        public string Value { get; set; }

    }
}