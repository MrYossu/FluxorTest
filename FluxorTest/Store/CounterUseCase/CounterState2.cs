namespace FluxorTest.Store.CounterUseCase {
  public class CounterState2 {
    public int ClickCount { get; }

    public CounterState2(int clickCount) =>
      ClickCount = clickCount;
  }
}