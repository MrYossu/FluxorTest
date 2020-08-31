using Fluxor;

namespace FluxorTest.Store.WeatherUseCase {
  public static class Reducers {
    [ReducerMethod]
    public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
      new WeatherState(true, null);

    [ReducerMethod]
    public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
      new WeatherState(false, action.Forecasts);
  }
}