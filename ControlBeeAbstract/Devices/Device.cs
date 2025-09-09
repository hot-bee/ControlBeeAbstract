using Dict = System.Collections.Generic.Dictionary<string, object?>;

namespace ControlBeeAbstract.Devices;

public abstract class Device : IDevice
{
    public string DeviceName { get; private set; } = "";

    public virtual void Init(string deviceName, Dict config)
    {
        DeviceName = deviceName;
    }

    public abstract void Dispose();
}