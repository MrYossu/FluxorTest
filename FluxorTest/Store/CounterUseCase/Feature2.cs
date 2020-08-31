using Fluxor;

namespace FluxorTest.Store.CounterUseCase {
  public class Feature2 : Feature<CounterState2> {
    public override string GetName() => "Counter2";

    protected override CounterState2 GetInitialState() =>
      new CounterState2(0);
  }
}