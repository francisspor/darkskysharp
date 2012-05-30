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

    public string IntensityValue
    {
      get
      {
        if (Intensity < 2)
        {
          return "No";
        }
 
        if (Intensity < 15)
        {
          return "Sporadic";
        } 
        
        if (Intensity < 30)
        {
          return "Light";
        } 
        
        if (Intensity < 45)
        {
          return "Moderate";
        }

        if (Intensity < 75)
        {
          return "Heavy";
        }

        return "No";
      }
    }
  }
}