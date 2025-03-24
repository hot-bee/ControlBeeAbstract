namespace ControlBeeAbstract.Exceptions;

public class UnimplementedByDesignError : PlatformException
{
    public UnimplementedByDesignError() { }

    public UnimplementedByDesignError(string message)
        : base(message) { }
}
