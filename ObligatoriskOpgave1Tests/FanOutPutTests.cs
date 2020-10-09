using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatoriskOpgave1.Tests
{
    [TestClass()]
    public class FanOutPutTests
    {
        private FanOutPut _fan;

        [TestInitialize]
        public void BeforeTest()
        {
            _fan =  new FanOutPut(1, "FanNumberOne", 20, 40);
        }


        [TestMethod()]
        public void CheckTempTest()
        {
            Assert.AreEqual(20,_fan.Temp);
            try
            {
                _fan.Temp = 13;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            try
            {
                _fan.Temp = 25;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

        }

        [TestMethod()]
        public void CheckFugtTest()
        {
            Assert.AreEqual(40,_fan.Fugt);

            try
            {
                _fan.Fugt = 20;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

        }

        [TestMethod()]
        public void CheckNameTest()
        {
            Assert.AreEqual("FanNumberOne",_fan.Name);
            try
            {
                _fan.Name = "F";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                
            }

            try
            {
                _fan.Name = null;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                
            }
        }

        [TestMethod]
        public void CheckIdTest()
        {
            Assert.AreEqual(1,_fan.Id);
            try
            {
                _fan.Id = 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        }
    }
}