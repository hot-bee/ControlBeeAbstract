namespace ControlBeeAbstract.Devices;

public interface ITransactionDevice : IDevice
{
    void SendCommand(string command);
}
