using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PackageLight;

namespace PackageButton
{
    public class Button
    {

        private Light _Light;

        public Button(Light light)
        {
            _Light = light; 
        }
                       
        public void Press()
        {
            if (_Light.IsOn)
                _Light.TurnOff();
            else
                _Light.TurnOn();
        }

    }
}
