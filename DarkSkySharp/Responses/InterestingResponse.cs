using System.Collections.Generic;

namespace DarkSkySharp.Responses {
  public class InterestingResponse {
    public List<Storm> Storms { get; set; }
  }

  public class Storm
  {
    public string RadarStation { get; set; }
    public double Intensity { get; set; }
    public string City { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}
