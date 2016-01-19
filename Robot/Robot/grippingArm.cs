using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class grippingArm : arms
    {
        string grippyClaw;

        public void grab()
        {
            Console.WriteLine("The robot grabs with its grippy claw.");
        }
    }
}
