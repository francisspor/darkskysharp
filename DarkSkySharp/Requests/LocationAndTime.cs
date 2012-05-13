namespace DarkSkySharp.Requests
{
  public class LocationAndTime : Location
  {
    /// <summary>
    /// Unix timestamp you'd like weather for
    /// </summary>
    public long Time { get; set; }

    public new string ToString()
    {
      return string.Format("{0},{1},{2}", Latitude, Longitude, Time);
    }
  }
}