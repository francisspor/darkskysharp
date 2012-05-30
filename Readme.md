DarkSkySharp - A C# implementation of the Dark Sky Api
==========================================

About
-----

A Node.js module for integrating with the [Dark Sky](http://darkskyapp.com) API. You must acquire an API key to use it.

Installation
------------

The project is hosted on [NuGet](https://nuget.org/packages/DarkSkySharp) 

Usage
-----

Create a client and then call one of the exposed methods. See the 
Dark Sky [API](http://darkskyapp.com/api/) for details.

```c#
var darkskyClient = new DarkSky("CLIENTKEY");
var locandTime = new LocationAndTime(28.4193, -81.5811, new DateTime(2012, 5, 15, 22, 21, 00, DateTimeKind.Utc));
var precipitation = darkSky.Precipitation(new List<LocationAndTime>() { locandTime });

```


Copyright
---------

Copyright (c) 2012 Francis Spor. See LICENSE for further details.