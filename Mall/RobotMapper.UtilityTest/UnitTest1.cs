using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotMapper.UtilityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            A a = new A { Id = 100 };
            B b = a.RobotMap<A, B>();
        }


    }

    public class A
    {
        public int Id { get; set; }
    }

    public class B
    {
        public int Id { get; set; }
    }

}
