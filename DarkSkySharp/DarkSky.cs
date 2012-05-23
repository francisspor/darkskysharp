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
using DarkSkySharp.Exceptions;
using DarkSkySharp.Requests;
using DarkSkySharp.Responses;
using RestSharp;

namespace DarkSkySharp
{
  public class DarkSky
  {
    public IRestClient RestClient { get; private set; }
    public string ApiKey { get; private set; }

    public DarkSky(string apiKey)
    {
      ApiKey = apiKey;

      if (string.IsNullOrEmpty(ApiKey))
      {
        throw new Exception("API Key is required");
      }

      RestClient = new RestClient("https://api.darkskyapp.com");
    }

    public ForecastResponse Forecast(Location location)
    {
      var restRequest = new RestRequest("v1/forecast/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", ApiKey);
      restRequest.AddUrlSegment("location", location.ToString());

      var response = RestClient.Execute<ForecastResponse>(restRequest);
      if (response.Data == null)
      {
        throw new DarkSkyException(response.StatusCode, response.StatusDescription);
      }
      return response.Data;
    }

    public ForecastResponse BriefForecast(Location location)
    {
      var restRequest = new RestRequest("v1/brief_forecast/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", ApiKey);
      restRequest.AddUrlSegment("location", location.ToString());

      var response = RestClient.Execute<ForecastResponse>(restRequest);
      if (response.Data == null)
      {
        throw new DarkSkyException(response.StatusCode, response.StatusDescription);
      }
      return response.Data;
    }

    public PrecipitationResponse Precipitation(IEnumerable<LocationAndTime> locations)
    {
      var restRequest = new RestRequest("v1/precipitation/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", ApiKey);

      restRequest.AddUrlSegment("location", string.Join(";", locations));

      var response = RestClient.Execute<PrecipitationResponse>(restRequest);
      if (response.Data == null)
      {
        throw new DarkSkyException(response.StatusCode, response.StatusDescription);
      }
      return response.Data;
    }

    public InterestingResponse Interesting()
    {
      var restRequest = new RestRequest("v1/interesting/{apikey}", Method.GET);
      restRequest.AddUrlSegment("apikey", ApiKey);

      var response = RestClient.Execute<InterestingResponse>(restRequest);

      if (response.Data == null)
      {
        throw new DarkSkyException(response.StatusCode, response.StatusDescription);
      }
      return response.Data;
    }
  }
}