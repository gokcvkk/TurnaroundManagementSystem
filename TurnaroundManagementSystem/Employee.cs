using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public bool IsAvailable { get; set; }



        public void AddEmployee(GroundOperation groundOperation)
        {
            if (!IsAvailable)
            {
                Console.WriteLine($"{Name} çalışıyor.\nBaşka görevli atayınız!");
                return;
            }

            if (Department != groundOperation.OperationName)
            {
                Console.WriteLine($"Lütfen {groundOperation.OperationName} operasyonu için uygun departmandan görevli atayınız!");
                return;
            }

            groundOperation.ResponsibleEmployee = this;
            IsAvailable = false;
            Console.WriteLine($"{Name} {groundOperation.OperationName} operasyonuna atandı!");
        }
    }
}
