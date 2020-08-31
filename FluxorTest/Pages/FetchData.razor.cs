using System.Linq;
using Fluxor;
using FluxorTest.Store.CounterUseCase;
using FluxorTest.Store.WeatherUseCase;
using Microsoft.AspNetCore.Components;

namespace FluxorTest.Pages {
  public partial class FetchData {
    [Inject]
    private IState<WeatherState> WeatherState { get; set; }

    [Inject]
    private IDispatcher Dispatcher { get; set; }

    protected override void OnInitialized() {
      base.OnInitialized();
      if (!WeatherState.Value.Forecasts?.Any() ?? false) {
        Dispatcher.Dispatch(new FetchDataAction());
      }
    }

    private void RefreshForecasts() =>
      Dispatcher.Dispatch(new FetchDataAction());

    private void IncrementCount() =>
      Dispatcher.Dispatch(new IncrementCounterAction());
  }
}