﻿#region License
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

namespace DarkSkySharp.Requests {
  public class Location {
    protected double? Latitude { get; set; }
    protected double? Longitude { get; set; }

    public Location (double latitude, double longitude)
    {
      Latitude = latitude;
      Longitude = longitude;
    }

    public override string ToString()
    {
      if (Latitude.HasValue && Longitude.HasValue)
      {
        return string.Format("{0},{1}", Latitude, Longitude);
      }

      throw new Exception("Latitude and Longitude are required");
    }
  }
}
