using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theapp
{
    public class ToDo
    {
        public ToDo()
        {
            desc = string.Empty;
        }
        public string desc { get; set; }
        public bool done { get; set; }
    }
}
