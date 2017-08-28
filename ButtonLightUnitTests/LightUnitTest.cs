using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageLight;


namespace TestUnitaires
{
    [TestClass]
    public class LightUnitTest
    {
        [TestMethod]
        public void LampeCreeEstEteinte()
        {
            Light light1 = new Light();
            Assert.IsFalse(light1.IsOn); 
            string expected = "Eteint";
            string actual = light1.ToString();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LampeAllumerLampeEstAllumee()
        {
            Light light1 = new Light();
            light1.TurnOn();
            Assert.IsTrue(light1.IsOn);
            string expected = "Allumé";
            string actual = light1.ToString();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LampeAllumeeEteindreEstEteinte()
        {
            Light light1 = new Light();
            light1.TurnOn();
            light1.TurnOff();
            Assert.IsFalse(light1.IsOn);
        }
        [TestMethod]
        public void LampeReAllumerEstAllumee()
        {
            Light light1 = new Light();
            light1.TurnOn();
            light1.TurnOff();
            light1.TurnOn();
            Assert.IsTrue(light1.IsOn);
        }
    }
}
