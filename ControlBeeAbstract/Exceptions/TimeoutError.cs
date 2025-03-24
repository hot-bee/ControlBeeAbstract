namespace ControlBeeAbstract.Exceptions;

public class TimeoutError : SequenceError
{
    public TimeoutError() { }

    public TimeoutError(string message)
        : base(message) { }
}
