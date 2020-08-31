using Fluxor;

namespace FluxorTest.Store.CounterUseCase {
  public static class Reducers {
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
      new CounterState(state.ClickCount + 1);

    [ReducerMethod]
    public static CounterState2 ReduceIncrementCounterAction2(CounterState2 state, IncrementCounterAction action) =>
      new CounterState2(state.ClickCount + 2);
  }
}