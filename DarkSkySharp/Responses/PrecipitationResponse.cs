using System.Collections.Generic;

namespace DarkSkySharp.Responses
{
  public class PrecipitationResponse
  {
    public List<Precipitation> Precipitation { get; set; }
  }

  public class Precipitation
  {
    public float Probability { get; set; }
    public double Intensity { get; set; } 
    public float Error { get; set; }
    public string Type { get; set; }
    public long Time { get; set; }
  }
}