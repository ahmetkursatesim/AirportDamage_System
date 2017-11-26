using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportDamage_S
{
    public class userData
    {
        public String name;
        public String value;
        public userData(String name, String value)
        {
            this.name = name;
            this.value = value;
        }
        public override string ToString()
        {

            return name;
        }
        public string getValue()
        {
            return value;
        }
        public string getName()
        {
            return name;
        }
    }
}
