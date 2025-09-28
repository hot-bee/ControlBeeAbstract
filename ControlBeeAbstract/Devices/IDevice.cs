namespace ControlBeeAbstract.Devices;

using Dict = Dictionary<string, object?>;

public interface IDevice : IDisposable
{
    string DeviceName { get; }
    void Init(string deviceName, Dict config);
    object? GetInitArgument(string argumentName);
}