namespace ControlBeeAbstract.Devices;

public interface IAnalogIoDevice : IDevice
{
    void SetAnalogInputRange(int channel, double min, double max);
    void SetAnalogOutputRange(int channel, double min, double max);
    void SetAnalogOutputByte(int channel, byte value);
    void SetAnalogOutputSignedByte(int channel, sbyte value);
    void SetAnalogOutputWord(int channel, ushort value);
    void SetAnalogOutputSignedWord(int channel, short value);
    void SetAnalogOutputDWord(int channel, uint value);
    void SetAnalogOutputSignedDWord(int channel, int value);
    void SetAnalogOutputDouble(int channel, double value);
    byte GetAnalogOutputByte(int channel);
    sbyte GetAnalogOutputSignedByte(int channel);
    ushort GetAnalogOutputWord(int channel);
    short GetAnalogOutputSignedWord(int channel);
    uint GetAnalogOutputDWord(int channel);
    int GetAnalogOutputSignedDWord(int channel);
    double GetAnalogOutputDouble(int channel);
    byte GetAnalogInputByte(int channel);
    sbyte GetAnalogInputSignedByte(int channel);
    ushort GetAnalogInputWord(int channel);
    short GetAnalogInputSignedWord(int channel);
    uint GetAnalogInputDWord(int channel);
    int GetAnalogInputSignedDWord(int channel);
    double GetAnalogInputDouble(int channel);
}