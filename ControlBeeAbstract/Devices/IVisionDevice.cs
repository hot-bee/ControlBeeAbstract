namespace ControlBeeAbstract.Devices;

using Dict = Dictionary<string, object?>;

public interface IVisionDevice : IDevice
{
    void Trigger(int channel);
    void Wait(int channel, int timeout);
    Dict GetResult(int channel);
}
