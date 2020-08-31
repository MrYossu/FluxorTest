using System.Collections.Generic;
using FluxorTest.Data;

namespace FluxorTest.Store.WeatherUseCase {
  public class FetchDataResultAction {
    public IEnumerable<WeatherForecast> Forecasts { get; }

    public FetchDataResultAction(IEnumerable<WeatherForecast> forecasts) =>
      Forecasts = forecasts;
  }
}