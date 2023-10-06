using System;

namespace TeamLong.Citrix.Exceptions;

public abstract class DirectorExceptionBase : Exception
{
    public DirectorExceptionBase(string message) : base(message)
    {
    }
}