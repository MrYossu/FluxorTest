using Fluxor;

namespace FluxorTest.Store.WeatherUseCase {
  public class Feature : Feature<WeatherState> {
    public override string GetName() => "Weather";

    protected override WeatherState GetInitialState() =>
      new WeatherState(false, null);
  }
}