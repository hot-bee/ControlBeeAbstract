namespace ControlBeeAbstract.Devices;

public record EthercatNetworkInfo(int SlaveCount, EthercatSlaveInfo[] Slaves);
