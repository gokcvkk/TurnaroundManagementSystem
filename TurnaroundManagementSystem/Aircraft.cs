using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Aircraft
    {
        #region 
        private int _passengerCapacity;
        private int _fuelCapacity;
        private int _currentFuel;

        public Aircraft(string tailNumber, string model)
        {
            TailNumber = tailNumber;
            Model = model;
        }

        public Aircraft(string tailNumber, string model, int currentFuel, int passengerCapacity = 100)
        {
            TailNumber = tailNumber;
            Model = model;
            CurrentFuel = currentFuel;
            PassengerCapacity = passengerCapacity;
        }


        public string TailNumber { get; set; }
        public string Model { get; set; }
        public int PassengerCapacity
        {
            get { return _passengerCapacity; }
            set
            {
                if (value < 0)
                {
                    _passengerCapacity = 0;
                    Console.WriteLine("Yolcu kapasitesi negatif olamaz!!");
                }
                else
                    _passengerCapacity = value;
            }
        }
        public int FuelCapacity
        {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                if (value < 0)
                {
                    _fuelCapacity = 0;
                    Console.WriteLine("Yakıt kapasitesi negatif olamaz!!");
                }
                else
                    _fuelCapacity = value;
            }
        }
        public int CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                _currentFuel = value;
            }
        }

        #endregion

        #region behavior
        public void SetFuel(int fuelAmount)
        {
            if (fuelAmount < 0)
            {
                Console.WriteLine("Yakıt miktarı negatif olamaz!");
            }
            else if (fuelAmount > FuelCapacity)
            {
                Console.WriteLine("Girilen yakıt depo kapasitesini aşıyor!");
            }
            else
            {
                CurrentFuel = fuelAmount;
                Console.WriteLine("Yakıt güncellendi");
            }
        }

        public void AddFuel(int fuel)
        {
            if (fuel < 0 || CurrentFuel + fuel > FuelCapacity)
                Console.WriteLine("Eklemek istediğiniz miktarı kontrol ediniz.");
            else
            {
                CurrentFuel += fuel;
                Console.WriteLine("Yakıt ekleme işlemi tamamlandı");
            }
        }
        #endregion

    }
}
