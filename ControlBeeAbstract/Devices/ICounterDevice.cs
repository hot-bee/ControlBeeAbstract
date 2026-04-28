using ControlBeeAbstract.Constants;

namespace ControlBeeAbstract.Devices;

public interface ICounterDevice : IDevice
{
    void SetEncoderMode(int channel, EncoderMode mode);
    void SetCounterValue(int channel, double value);
    double GetCounterValue(int channel);
    event EventHandler? Reconnected;
}
