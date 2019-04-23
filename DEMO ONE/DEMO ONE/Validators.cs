using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe
{
    public class Validators
    {
        public string name;

        public Validators(string newName)
        {
            name = newName;
        }

        public bool nameValidator()
        {
            if (name.Length < 3 || name.Length > 12)//checks size
            {
                return false;
            }
            return true;
        }
    }
}
