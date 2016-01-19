using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class toolArm : arms
    {
        string multipurposeToolAttachment;

        public void build()
        {
            Console.WriteLine("The Robot builds small structures");
        }
        public void repair()
        {
            Console.WriteLine("The Robot repairs a nearby machine");
        }
    }
}
