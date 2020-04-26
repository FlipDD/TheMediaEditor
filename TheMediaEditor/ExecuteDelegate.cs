namespace TheMediaEditor
{
    /// <summary>
    /// Declare a delegate that is used to execute commands, call it ExecuteDelegate.
    /// </summary>
    /// <param name="command"> The command to execute </param>
    public delegate void ExecuteDelegate(ICommand command);
}