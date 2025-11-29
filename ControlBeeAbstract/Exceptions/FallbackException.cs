namespace ControlBeeAbstract.Exceptions;

public class FallbackException : PlatformException
{
    public FallbackException() { }

    public FallbackException(string message)
        : base(message) { }
}
