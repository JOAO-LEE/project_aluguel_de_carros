using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
  public string Brand
  {
    get
    {
      return Brand;
    }
    set
    {
      Brand = "";
    }
  }
  public string Model
  {
    get
    {
      return Model;
    }
    set
    {
      Model = "";
    }
  }

  public decimal Price { get; set; }

  public FuelType Fuel { get; set; }
  public int EngineCapacity { get; set; }

  public Color MainColor { get; set; }

  public int Year { get; set; }

  public double PricePerDay { get; set; }

  public bool IsRented
  {
    get
    {
      return IsRented;
    }
    set
    {
      IsRented = false;
    }
  }

}