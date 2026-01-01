namespace ControlBeeAbstract.Devices;

using Dict = Dictionary<string, object?>;

public abstract class Device : IDevice
{
    private readonly Dict _initArguments = [];
    public string DeviceName { get; private set; } = "";

    public virtual void Init(string deviceName, Dict config)
    {
        DeviceName = deviceName;
    }

    public abstract void Dispose();

    public object? GetInitArgument(string argumentName)
    {
        return _initArguments.GetValueOrDefault(argumentName);
    }

    protected void SetInitArgument(string argumentName, object? value)
    {
        _initArguments[argumentName] = value;
    }
}
