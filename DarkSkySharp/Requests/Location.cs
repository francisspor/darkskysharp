using System;

namespace DarkSkySharp.Requests {
  public class Location {
    protected double? Latitude { get; set; }
    protected double? Longitude { get; set; }

    public Location (double latitude, double longitude)
    {
      Latitude = latitude;
      Longitude = longitude;
    }

    public string ToString()
    {
      if (Latitude.HasValue && Longitude.HasValue)
      {
        return string.Format("{0},{1}", Latitude, Longitude);
      }

      throw new Exception("Latitude and Longitude are required");
    }
  }
}
