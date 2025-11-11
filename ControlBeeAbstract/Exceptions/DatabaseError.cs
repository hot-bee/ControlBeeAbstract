namespace ControlBeeAbstract.Exceptions;

public class DatabaseError : PlatformException
{
    public DatabaseError() { }

    public DatabaseError(string message)
        : base(message) { }
}