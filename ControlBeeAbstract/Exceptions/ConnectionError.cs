namespace ControlBeeAbstract.Exceptions;

public class ConnectionError : SequenceError
{
    public ConnectionError() { }

    public ConnectionError(string message)
        : base(message) { }
}
