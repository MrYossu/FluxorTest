using System;
using System.Collections.Generic;
using FluxorTest.Data;

namespace FluxorTest.Store.WeatherUseCase {
  public class WeatherState {
    public bool IsLoading { get; }
    public IEnumerable<WeatherForecast> Forecasts { get; }

    public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts) {
      IsLoading = isLoading;
      Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
    }
  }
}