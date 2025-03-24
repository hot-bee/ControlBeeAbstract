namespace ControlBeeAbstract.Devices;

public interface IVisionDevice : IDevice
{
    void Trigger(int channel);
    void Wait(int channel, int timeout);
    string GetResult(int channel);
}
