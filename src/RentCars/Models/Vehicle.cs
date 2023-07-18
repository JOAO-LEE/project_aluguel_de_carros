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


// Brand que deve ser do tipo string, ter valor padrão igual à "", deve ter get e set;
// Model que deve ser do tipo string, ter valor padrão igual à "", deve ter get e set;
// Price que deve ser do tipo decimal, deve ter get e set;
// Fuel que deve ser do tipo FuelType, deve ter get e set;
// EngineCapacity que deve ser do tipo int, deve ter get e set;
// MainColor que deve ser do tipo Color, deve ter get e set;
// Year que deve ser do tipo int, deve ter get e set;
// PricePerDay que deve ser do tipo double, deve ter get e set;
// IsRented que deve ser do tipo bool, ter valor padrão igual à false, deve ter get e set;