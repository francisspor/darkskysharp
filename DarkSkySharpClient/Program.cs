#region License

//   Copyright 2012 Francis Spor
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DarkSkySharp.Requests;

namespace DarkSkySharpClient
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var darkSky = new DarkSkySharp.DarkSky(ConfigurationManager.AppSettings["DarkSkyApiKey"]);

      var interesting = darkSky.Interesting();
      Console.WriteLine("Apparently - a storm of {0} dBZ is happening in {1}", interesting.Storms.First().Intensity,
                        interesting.Storms.First().City);

      var forecast = darkSky.Forecast(new Location(40.77420, -73.95784));
      Console.WriteLine("It is {0}precipitating and {1} in NYC", forecast.IsPrecipitating ? String.Empty : "not ",
                        forecast.CurrentSummary);

      try
      {
        var precipitation =
          darkSky.Precipitation(new List<LocationAndTime>()
                                  {
                                    new LocationAndTime(28.4193, -81.5811,
                                                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now)),
                                    new LocationAndTime(28.4193, -81.5811,
                                                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now.AddHours(2)))
                                  });
        Console.WriteLine("There is a {0:P1} chance of {1} {2} at Cinderella's Castle currently.",
                          precipitation.Precipitation.First().Probability,
                          precipitation.Precipitation.First().IntensityValue,
                          precipitation.Precipitation.First().Type);
        Console.WriteLine("In thirty minutes, there is a {0:P1} chance of {1} {2} at Cinderella's Castle.",
                          precipitation.Precipitation.Last().Probability,
                          precipitation.Precipitation.Last().IntensityValue,
                          precipitation.Precipitation.Last().Type);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}