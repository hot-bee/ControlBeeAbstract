namespace ControlBeeAbstract.Devices;

public interface IDigitalIoDevice : IDevice
{
    bool GetDigitalInputBit(int channel);
    void SetDigitalOutputBit(int channel, bool value);
    bool GetDigitalOutputBit(int channel);
    event EventHandler<(int channel, bool value)>? OutputBitChanged;
    bool SetDigitalInputBitInverted(int channel, bool inverted);
    bool GetDigitalInputBitInverted(int channel);
}