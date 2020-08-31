using Fluxor;
using FluxorTest.Store.CounterUseCase;
using Microsoft.AspNetCore.Components;

namespace FluxorTest.Pages {
  public partial class Counter {
    [Inject]
    private IState<CounterState> CounterState { get; set; }

    [Inject]
    public IDispatcher Dispatcher { get; set; }

    private void IncrementCount() =>
      Dispatcher.Dispatch(new IncrementCounterAction());
  }
}