using System;

namespace Dalamud.Plugin
{
    /// <summary>
    /// This exception is thrown when an IPC method is invoked, but nothing has been registered by that name yet.
    /// </summary>
    public class IpcNotReadyYetError : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpcNotReadyYetError"/> class.
        /// </summary>
        /// <param name="name">Name of the IPC method.</param>
        public IpcNotReadyYetError(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of the IPC that was invoked.
        /// </summary>
        public string Name { get; }

        /// <inheritdoc/>
        public override string Message => $"IPC method {this.Name} was not registered yet";
    }
}
