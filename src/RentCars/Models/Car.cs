using RentCars.Types;
namespace RentCars.Models;

//6 - Faça a classe `Car` herdar de `Vehicle`
public class Car : Vehicle
{
  public int Seats { get; set; }
  public int Doors { get; set; }
  public TractionType Traction { get; set; }
  public BrakeType FrontBrake { get; set; }
  public BrakeType RearBrake { get; set; }

  //   public Car(int seats, int doors, TractionType traction, BrakeType frontBrake, BrakeType rearBrake)
  //   {
  //     Seats = seats;
  //     Doors = doors;
  //     Traction = traction;
  //     FrontBrake = frontBrake;
  //     RearBrake = rearBrake;
  //   }
}
