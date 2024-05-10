using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public string EngineType;
        public string Color;
        public string EngineV;
        public override string ToString()
        {
            return $"{Brand}, {Model}, {EngineType}, {Color}, {EngineV}";
        }
    }
}
