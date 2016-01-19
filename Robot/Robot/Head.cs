using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Head
    {
        string Optics;
        string comunications;
        

        public void see(){
            Console.WriteLine("stares in robot"); 
        }

        public void communicate()
        {
            Console.WriteLine("beep boop I am a robot");
        }
    }
}
