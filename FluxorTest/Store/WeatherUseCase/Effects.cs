using System;
using System.Threading.Tasks;
using Fluxor;
using FluxorTest.Data;

namespace FluxorTest.Store.WeatherUseCase {
  public class Effects {
    private readonly WeatherForecastService _service;

    public Effects(WeatherForecastService service) =>
      _service = service;

    [EffectMethod]
    public async Task HandleFetchDataAction(FetchDataAction action, IDispatcher dispatcher) {
      await Task.Delay(2000);
      WeatherForecast[] forecasts = await _service.GetForecastAsync(DateTime.Now);
      dispatcher.Dispatch(new FetchDataResultAction(forecasts));
    }
  }
}