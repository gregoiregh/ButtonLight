using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackageLight
{
    public class Light
    {
        private bool _IsOn;

        public bool IsOn
        {
            get { return _IsOn; }           
        }

        public Light()
        {
            //L'état initial de la lampe est éteint
            _IsOn = false;
        }
                

        public void TurnOn()
        {
            _IsOn = true;
        }

        public void TurnOff()
        {
            _IsOn = false;
        }

        public override string ToString()
        {
            if (IsOn)
                return "Allumé";
            else
                return "Eteint";
        } 
        
    }
}
