using System;

public interface Signal<T>
{
    public T GetValue(T fallbackValue);
    public void SetValue(T value);
    public void RegisterOnSetListener(Action<T> action);
    public void UnregisterOnSetListener(Action<T> action);
}
