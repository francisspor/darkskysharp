using System;
using System.Collections.Generic;
using DarkSkySharp.Requests;
using DarkSkySharp.Responses;
using RestSharp;

namespace DarkSkySharp
{
  public class DarkSky
  {
    private readonly string _apiKey = "";
    private readonly RestClient _restClient;

    public DarkSky(string apiKey)
    {
      _apiKey = apiKey;

                  if (string.IsNullOrEmpty(_apiKey) )
      {
        throw new Exception("API Key is required");
      }

      _restClient = new RestClient("https://api.darkskyapp.com");
    }

    public ForecastResponse Forecast(Location location)
    {
      var restRequest = new RestRequest("v1/forecast/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", _apiKey);
      restRequest.AddUrlSegment("location", location.ToString());

      var response = _restClient.Execute<ForecastResponse>(restRequest);
      return response.Data;
    }

    public ForecastResponse BriefForecast(Location location)
    {
      var restRequest = new RestRequest("v1/brief_forecast/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", _apiKey);
      restRequest.AddUrlSegment("location", location.ToString());

      var response = _restClient.Execute<ForecastResponse>(restRequest);
      return response.Data;
    }

    public PrecipitationResponse Precipitation(List<LocationAndTime> locations)
    {
      var restRequest = new RestRequest("v1/precipitation/{apikey}/{location}", Method.GET);
      restRequest.AddUrlSegment("apikey", _apiKey);

      var loc = locations[0].ToString();
      restRequest.AddUrlSegment("location", string.Join(";", loc));

      var response = _restClient.Execute<PrecipitationResponse>(restRequest);
      return response.Data;
    }

    public InterestingResponse Interesting()
    {
      var restRequest = new RestRequest("v1/interesting/{apikey}", Method.GET);
      restRequest.AddUrlSegment("apikey", _apiKey);

      var response = _restClient.Execute<InterestingResponse>(restRequest);
      return response.Data;
    }
  }
}