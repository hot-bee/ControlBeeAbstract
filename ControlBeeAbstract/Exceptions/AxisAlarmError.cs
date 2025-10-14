namespace ControlBeeAbstract.Exceptions;

public class AxisAlarmError : FatalSequenceError
{
    public AxisAlarmError() { }

    public AxisAlarmError(string message)
        : base(message) { }
}
