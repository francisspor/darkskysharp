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
using DarkSkySharp;
using DarkSkySharp.Requests;
using Xunit;

namespace DarkSkySharpTest
{
  public class DarkSkyTests
  {
    [Fact]
    public void ThrowsExceptionOnEmptyApiKey()
    {
      Assert.Throws<System.Exception>(delegate { var darkSky = new DarkSky(""); });
    }

    [Fact]
    public void CreatesClientWithApiKey()
    {
      const string clientKey = "clientApiKey";
      var darkSky = new DarkSky(clientKey);
      Assert.Equal(clientKey, darkSky.ApiKey);
    }

    [Fact]
    public void CallsForecast()
    {
      const string clientKey = "clientApiKey";
      var darkSky = new DarkSky(clientKey);
    }

    [Fact]
    public void CreatingLocationAndTimeWorks()
    {
      var locandTime = new LocationAndTime(28.4193, -81.5811, new DateTime(2012, 5, 15, 22, 21, 00, DateTimeKind.Utc));
      Assert.Equal(1337120460, locandTime.Time);
      locandTime = new LocationAndTime(28.4193, -81.5811, new DateTime(2012, 5, 16, 0, 21, 00, DateTimeKind.Utc));
      Assert.Equal(1337127660, locandTime.Time);
    }
  }
}