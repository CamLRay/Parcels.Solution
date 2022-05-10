namespace Parcels.Models
{
  public class Parcel
  {
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }

    public Parcel (int weight, int height, int width, int length)
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

    public int CostToShip()
    {
      return (Volume() * Weight)*100
    }
  }
}