namespace ControlBeeAbstract.Exceptions;

public class DeviceError : FatalSequenceError
{
    public DeviceError()
    {
    }

    public DeviceError(string message)
        : base(message)
    {
    }

    public int ErrorCode { get; set; }
}