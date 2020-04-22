namespace TheMediaEditor
{
    /// <summary>
    /// ICommand interface - all commands must implement this.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute the command.
        /// </summary>
        void Execute();
    }
}