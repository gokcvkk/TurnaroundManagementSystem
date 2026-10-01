using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Turnaround
    {
        public Flight? Flight { get; set; }
        public Gate? Gate { get; set; }
        public GroundOperation[]? GroundOperations { get; set; }


    }
}
