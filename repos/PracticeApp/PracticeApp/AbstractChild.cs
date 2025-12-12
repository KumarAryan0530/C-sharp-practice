using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class AbstractChild : AbstractArea
    {
        internal override void rectangle()
        {
            area = param1 * param2;
        }

        internal override void triangle()
        {
            area = (param1 * param2) / 2;
        }
    }
}
