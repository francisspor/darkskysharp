using System.Collections.Generic;

namespace DarkSkySharp.Responses {
  public class ForecastResponse {
    public bool IsPrecipitating { get; set; }
    public int MinutesUntilChange { get; set; }
    public string CurrentSummary { get; set; }
    public string HourSummary { get; set; }
    public int CheckTimeout { get; set; }
    public string RadarStation { get; set; }

    public List<Precipitation> HourPrecipitation { get; set; }
    public List<Precipitation> DayPrecipitation { get; set; }
  }
}
