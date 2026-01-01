namespace ControlBeeAbstract.Exceptions;

public class VisionError : SequenceError
{
    public VisionError() { }

    public VisionError(string message)
        : base(message) { }
}
