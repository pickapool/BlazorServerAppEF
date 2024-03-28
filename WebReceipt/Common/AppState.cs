namespace WebReceipt.Common
{
    public class AppState
    {
        public event Action? OnChange;
        public async Task NotifyStateChangedAsync() => await Task.Run(() => OnChange?.Invoke());
    }
}