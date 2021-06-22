using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Radio
    {
        public void RadioOn(bool on)
        {
            Console.WriteLine(on ? "Ah Jamming..." : "Quiet time");

        }
    }
}
