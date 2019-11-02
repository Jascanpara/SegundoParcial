using System;
using
    SegundoParcial.Models;

namespace SegundoParcial.Services
{
    public interface IProxy
    {
        WeatherObject weather(string ciudad);
        ForecastObject forecast(string ciudad);
    }
}
