namespace DarkSkySharp.Requests {
  public class Location {
    public double Latitude { get; set; }
    public double Longitude { get; set; }


    public new string ToString()
    {
      return string.Format("{0},{1}", Latitude, Longitude);
    }
  }
}
