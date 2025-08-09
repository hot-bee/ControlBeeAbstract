using System.Text.Json.Nodes;

namespace ControlBeeAbstract.Devices;

public interface IVisionDevice : IDevice
{
    void Connect();
    bool IsConnected();
    void Trigger(int channel, int inspectionIndex);
    void Wait(int channel, int inspectionIndex, int timeout);
    void WaitGrabEnd(int channel, int inspectionIndex, int timeout);
    JsonObject GetResult(int channel, int inspectionIndex);
    void EmbedVisionView(IntPtr parentHandle, int channel);
    void StartContinuous(int channel);
    void StopContinuous(int channel);
    void FocusChannel(int channel);
    event EventHandler? VisionConnected;
    event EventHandler? VisionDisconnected;
}