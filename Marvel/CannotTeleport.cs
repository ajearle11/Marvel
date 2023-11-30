using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel
{
    public class CannotTeleport : Teleports
    {
        public string Teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
