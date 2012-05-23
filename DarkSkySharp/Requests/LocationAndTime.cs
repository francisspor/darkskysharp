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

    public override string ToString()
    {
      if (Latitude.HasValue && Longitude.HasValue && Time.HasValue)
      {
        return string.Format("{0},{1},{2}", Latitude, Longitude, Time);
      }
      throw new Exception("Latitude, Longitude, and Time are required");
    }
  }
}