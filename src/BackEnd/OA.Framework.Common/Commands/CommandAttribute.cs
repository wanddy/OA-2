namespace OA.Framework.Common.Commands
{
    using System;

    /// <summary>
    /// An attribute that identifies a command.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class CommandAttribute : Attribute
    {
    }
}