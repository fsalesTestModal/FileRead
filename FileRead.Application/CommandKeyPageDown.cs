namespace FileRead.Application
{
    internal sealed class CommandKeyPageDown : ICommandKey
    {
        private static readonly CommandKeyPageDown Instance = new CommandKeyPageDown();
        public static CommandKeyPageDown GetCommandKeyPageDown()
        {
            return Instance;
        }
        public long ReturnIndex(long index)
        {
            return index + 11;
        }
    }
}