using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Panda_Racing;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Bet Obj_Bet;
        [TestMethod]
        public void TestMethod1()
        {
            Obj_Bet.PandaNum = 4;
            Obj_Bet.Amount = 40;
            Assert.AreEqual(40, Obj_Bet.Pay(4));
        }
    }
}
