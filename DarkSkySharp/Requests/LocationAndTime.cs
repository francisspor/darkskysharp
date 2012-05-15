using System;

namespace DarkSkySharp.Requests
{
  public class LocationAndTime : Location
  {
    /// <summary>
    /// Unix timestamp you'd like weather for
    /// </summary>
    public long? Time { get; set; }

    public LocationAndTime(double latitude, double longitude, DateTime time) : base (latitude, longitude)
    {
      Time = (long) (time.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
    }

    public string ToString()
    {
      if (Latitude.HasValue && Longitude.HasValue && Time.HasValue)
      {
        return string.Format("{0},{1},{2}", Latitude, Longitude, Time);
      }
      throw new Exception("Latitude, Longitude, and Time are required");
    }
  }
}