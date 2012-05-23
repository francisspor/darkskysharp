using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DarkSkySharp.Requests;

namespace DarkSkySharpClient
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string apiKey = "23565578962bf71e66ed5cffc731f362";

      var darkSky = new DarkSkySharp.DarkSky(apiKey);

      var interesting = darkSky.Interesting();
      Console.WriteLine("Apparently - a storm of {0} dBZ is happening in {1}", interesting.Storms.First().Intensity,
                        interesting.Storms.First().City);

      var forecast = darkSky.Forecast(new Location(40.77420, -73.95784));
      Console.WriteLine("It is {0} and {1} in NYC", forecast.IsPrecipitating ? "raining" : "not raining",
                        forecast.CurrentSummary);

      try
      {
        var precipitation =
          darkSky.Precipitation(new List<LocationAndTime>() {new LocationAndTime(42.678, -73.748, DateTime.Now)});
      Console.WriteLine("It is {0} in Duanesburg", precipitation.Precipitation.First().Type);
      } catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        
      } 
    }
  }
}