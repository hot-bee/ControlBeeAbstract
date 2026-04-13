namespace ControlBeeAbstract.Devices;

public interface IEthercatDevice : IDevice
{
    EthercatNetworkInfo GetNetworkInfo();
}
