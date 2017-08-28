using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageButton;
using PackageLight;
 
namespace TestUnitaires
{
    [TestClass]
    public class ButtonUnitTest
    {
        [TestMethod]
        public void BoutonCreeLampeEstEteinte()
        {
            Light light1 = new Light();
            Button button1 = new Button(light1);
            Assert.IsFalse(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress1FoisLampeAllumee()
        {
            Light light1 = new Light();
            Button button1 = new Button(light1);
            button1.Press();
            Assert.IsTrue(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress2FoisLampeEteinte()
        {
            Light light1 = new Light();
            Button button1 = new Button(light1);
            button1.Press();
            button1.Press();
            Assert.IsFalse(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress3FoisLampeAllumee()
        {
            Light light1 = new Light();
            Button button1 = new Button(light1);
            button1.Press();
            button1.Press();
            button1.Press();
            Assert.IsTrue(light1.IsOn);
        }

      
    }
}
