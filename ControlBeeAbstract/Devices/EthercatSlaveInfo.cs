namespace ControlBeeAbstract.Devices;

public record EthercatSlaveInfo(
    int Position,
    uint VendorId,
    uint ProductCode,
    EthercatSlaveState State,
    bool Offline,
    bool Inaccessible
);
