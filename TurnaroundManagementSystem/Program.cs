using TurnaroundManagementSystem;

var aircraft = new Aircraft("TC-JHK", "A320", 5000, 180)
{
    FuelCapacity = 20000
};

var flight = new Flight
{
    FlightNumber = "TK101",
    Destination = "Ankara",
    ArrivalTime = DateTime.Now,
    DepartureTime = DateTime.Now.AddHours(2),
    PassengerCount = 150,
    Aircraft = aircraft
};

if (!flight.CanCarryPassengers())
{
    return;
}

var gate = new Gate { GateCode = "A12" };

var fuelOp = new GroundOperation("Yakıt", 25);
var cleaningOp = new GroundOperation("Temizlik", 15);

var fuelEmployee = new Employee
{
    EmployeeId = 1,
    Name = "Ali",
    Department = "Yakıt",
    IsAvailable = true
};

var cleaningEmployee = new Employee
{
    EmployeeId = 2,
    Name = "Ayşe",
    Department = "Temizlik",
    IsAvailable = true
};

fuelEmployee.AddEmployee(fuelOp);
cleaningEmployee.AddEmployee(cleaningOp);

var turnaround = new Turnaround
{
    Flight = flight,
    Gate = gate,
    GroundOperations = [fuelOp, cleaningOp]
};

Console.WriteLine($"Planlanan operasyon sayısı: {turnaround.OperationCount}");
Console.WriteLine($"Tahmini süre (dk): {turnaround.GetTotalEstimatedMinutes()}");

aircraft.AddFuel(3000);
turnaround.RunTurnaround();
