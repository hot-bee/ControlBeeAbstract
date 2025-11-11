namespace ControlBeeAbstract.Devices;

public interface IBufferDevice : IDevice
{
    void RunBuffer(int bufferIndex, string label);
    void StopBuffer(int bufferIndex);

    bool IsRunningBuffer(int bufferIndex);

    object ReadVariable(string variable, int bufferIndex = -1,
        int from1 = -1, int to1 = -1, int from2 = -1, int to2 = -1);

    void WriteVariable(object value, string variable, int bufferIndex = -1,
        int from1 = -1, int to1 = -1, int from2 = -1, int to2 = -1);
}