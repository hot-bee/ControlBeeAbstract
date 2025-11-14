using Newtonsoft.Json.Linq;

namespace ControlBeeAbstract.Devices;

using Dict = Dictionary<string, object?>;

public interface IVisionDevice : IDevice
{
    void Connect();
    bool IsConnected();
    void Trigger(int channel, int inspectionIndex, string? triggerId, Dict? options = null);
    void Trigger(int channel, int inspectionIndex, Dict? options = null);
    void Wait(int channel, int inspectionIndex, int timeout);
    void Wait(string triggerId, int timeout);
    void WaitGrabEnd(int channel, int inspectionIndex, int timeout);
    void WaitExposureEnd(int channel, int inspectionIndex, int timeout);
    JObject GetResult(int channel, int inspectionIndex);
    JObject GetResult(string triggerId);
    void EmbedVisionView(IntPtr parentHandle, Dict options);
    void StartContinuous(int channel);
    void StopContinuous(int channel);
    void FocusChannel(int channel);
    void LoadRecipe(string recipeName);
    void SaveRecipe(string? recipeName);
    void SaveImage(int channel, string triggerId, string savePath);
    void SetLightOnOff(int channel, int inspectionIndex, bool on);
    void SetLightValue(int channel, int inspectionIndex, int lightChannel, double value);
    event EventHandler? VisionConnected;
    event EventHandler? VisionDisconnected;
    event EventHandler<(string eventName, JObject? payload)>? EventOccurred;
    void RequestRecipeInfo();
    void RequestData(string dataName);
}