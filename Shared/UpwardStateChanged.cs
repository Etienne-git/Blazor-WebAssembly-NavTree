using System;

public class UpwardStateChanged
{
    public event Action RefreshRequested;
    public void CallRequestRefresh()
    {
        RefreshRequested?.Invoke();
    }
}