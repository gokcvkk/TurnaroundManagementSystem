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

        public int OperationCount => GroundOperations?.Length ?? 0;

        public int GetTotalEstimatedMinutes()
        {
            if (GroundOperations == null || GroundOperations.Length == 0)
                return 0;

            return GroundOperations.Sum(op => op.EstimatedMinutes);
        }

        public void RunTurnaround()
        {
            if (Flight == null || Gate == null)
            {
                Console.WriteLine("Turnaround için uçuş ve kapı atanmalıdır!");
                return;
            }

            Gate.AssignFlight(Flight);

            if (GroundOperations == null)
                return;

            foreach (var operation in GroundOperations)
            {
                operation.Complete();
            }

            Gate.ReleaseGate();
            Console.WriteLine($"{Flight.FlightNumber} turnaround süreci tamamlandı.");
        }
    }
}
