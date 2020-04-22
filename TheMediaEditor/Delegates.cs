namespace TheMediaEditor
{
    /// <summary>
    /// Declare a generic delegate with no parameters and no return value to implement Strategy Pattern, call it StrategyDelegate.
    /// </summary>
    public delegate void StrategyDelegate();

    /// <summary>
    /// Declare a delegate that is used to execute commands, call it ExecuteDelegate.
    /// </summary>
    /// <param name="command"> The command to execute </param>
    public delegate void ExecuteDelegate(ICommand command);
}