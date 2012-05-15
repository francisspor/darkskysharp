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
      string apiKey = "8799f5282961deabcefba7bfecd8038b";

      var darkSky = new DarkSkySharp.DarkSky(apiKey);

      var interesting = darkSky.Interesting();
      Console.WriteLine("Apparently - a storm of {0} dBZ is happening in {1}", interesting.Storms.First().Intensity,
                        interesting.Storms.First().City);

      var forecast = darkSky.Forecast(new Location(40.77420, -73.95784));
      Console.WriteLine("It is {0} and {1} in NYC", forecast.IsPrecipitating ? "raining" : "not raining",
                        forecast.CurrentSummary);

      var precipitation = darkSky.Precipitation(new List<LocationAndTime>() {new LocationAndTime(42.7626, -74.1359,DateTime.Now)});
      Console.WriteLine("It is {0} in Duanesburg", precipitation.Precipitation.First().Type);

    }
  }
}