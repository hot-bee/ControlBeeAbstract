namespace ControlBeeAbstract.Devices;

public interface IUserMemoryDevice : IDevice
{
    void SetUserMemoryBit(int channel, int offset, byte value);
    void SetUserMemoryByte(int channel, byte value);
    void SetUserMemorySignedByte(int channel, sbyte value);
    void SetUserMemoryWord(int channel, ushort value);
    void SetUserMemorySignedWord(int channel, short value);
    void SetUserMemoryDWord(int channel, uint value);
    void SetUserMemorySignedDWord(int channel, int value);
    byte GetUserMemoryBit(int channel, int offset);
    byte GetUserMemoryByte(int channel);
    sbyte GetUserMemorySignedByte(int channel);
    ushort GetUserMemoryWord(int channel);
    short GetUserMemorySignedWord(int channel);
    uint GetUserMemoryDWord(int channel);
    int GetUserMemorySignedDWord(int channel);
}