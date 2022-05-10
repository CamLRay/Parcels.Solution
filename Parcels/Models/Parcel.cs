namespace Parcels.Models
{
  public class Parcel
  {
    public double Weight { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int ParcelVolume { get; set; }
    public string ParcelCostToShip { get; set;}

    public Parcel ()
    {
    }

    public Parcel (double weight, int height, int width, int length)
    {
      Weight = weight;
      Height = height;
      Width = width;
      Length = length;
    }

    public int Volume ()
    {
      return Height * Width * Length;
    }

    public string CostToShip()
    {
      return ((Volume() * Weight)/50).ToString("F");
    }

  }
}