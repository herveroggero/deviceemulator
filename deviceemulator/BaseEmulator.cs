using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deviceemulator
{
    public class BaseEmulator
    {
        public BaseEmulator() { }

        public string Name { get; set; }

        public List<string> Devices { get; set; }

    }
}
