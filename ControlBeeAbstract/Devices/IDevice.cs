namespace ControlBeeAbstract.Devices;

using Dict = Dictionary<string, object?>;

public interface IDevice : IDisposable
{
    void Init(Dict config);
}
