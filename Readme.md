# DarkSkySharp - A C# implementation of the Dark Sky Api

## About
A C# class based on [RestSharp](http://www.restsharp.org) with the [Dark Sky](http://darkskyapp.com) API. You must acquire an [API key](https://developer.darkskyapp.com/)	 to use it.

## Installation
The project is hosted on [NuGet](https://nuget.org/packages/DarkSkySharp) 

## Usage
Create a client and then call one of the exposed methods. See the 
Dark Sky [API](http://darkskyapp.com/api/) for details.

```c#
var darkskyClient = new DarkSky("CLIENTKEY");

// Let's find out what's going on in the Magic Kingdom
var locandTime = new LocationAndTime(28.4193, -81.5811, DateTime.Now);
var precipitation = darkSky.Precipitation(new List<LocationAndTime>() { locandTime });
Console.WriteLine("There is a {0:P1} chance of {1} {2} at Cinderella's Castle currently.",
				  precipitation.Precipitation.First().Probability,
				  precipitation.Precipitation.First().IntensityValue,
				  precipitation.Precipitation.First().Type);
```

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Added some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request


## Copyright
Copyright (c) 2012 [Francis Spor](mailto:francis@upstatespors.com). See LICENSE for further details.