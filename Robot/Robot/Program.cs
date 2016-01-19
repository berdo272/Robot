using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            toolArm Arm1 = new toolArm();
            grippingArm Arm2 = new grippingArm();
            Head StandardHead = new Head();
            torso StandardTorso = new torso();
            treads wheels = new treads();

            StandardHead.see();
            StandardHead.communicate();
            Arm1.build();
            Arm2.grab();
            StandardTorso.storeItem();
            wheels.move();
        }
    }
}
