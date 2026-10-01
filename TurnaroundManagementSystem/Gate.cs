using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Gate
    {
        #region 
        private bool _isOccupied;

        public string? GateCode { get; set; }
        public bool IsOccupied
        {
            get
            {
                return _isOccupied;
            }
            set
            {
                if (value == true)
                {
                    _isOccupied = value;
                    Console.WriteLine("Kapı şu anda dolu!");
                }
                else
                    _isOccupied = value;
            }
        }
        public Flight? CurrentFlight { get; set; }

        #endregion

        #region behaviour
        public void AssignFlight(Flight? flight)
        {
            if (IsOccupied == false)
            {
                CurrentFlight = flight;
                IsOccupied = true;
                Console.WriteLine($"{GateCode} numaralı kapıda {CurrentFlight.FlightNumber} uçuşu var!");
            }
            else
            {
                Console.WriteLine($"{GateCode} numaralı kapı dolu, bekleyiniz ya da farklı bir kapı seçiniz!");
            }
        }

        public void ReleaseGate()
        {
            CurrentFlight= null;
            IsOccupied = false;
        }


        #endregion
    }
}
