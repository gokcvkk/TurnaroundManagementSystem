using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class GroundOperation
    {
        public GroundOperation()
        {
            OperationName = string.Empty;
        }

        public GroundOperation(string operationName)
        {
            OperationName = operationName;
        }

        public GroundOperation(string operationName, int estimatedMinutes)
        {
            OperationName = operationName;
            EstimatedMinutes = estimatedMinutes;
        }

        public string OperationName { get; set; }
        public int EstimatedMinutes { get; set; }
        public bool IsCompleted { get; private set; }
        public Employee? ResponsibleEmployee { get; set; }

        public void Complete()
        {
            IsCompleted = true;
            Console.WriteLine($"{OperationName} operasyonu tamamlandı.");
        }
    }
}
