﻿namespace ControlBeeAbstract.Exceptions;

public class FatalSequenceError : SequenceError
{
    public FatalSequenceError() { }

    public FatalSequenceError(string message)
        : base(message) { }
}
