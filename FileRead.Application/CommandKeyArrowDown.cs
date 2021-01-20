namespace FileRead.Application
{
    internal sealed class CommandKeyArrowDown : ICommandKey
    {
        private static readonly CommandKeyArrowDown Instance = new CommandKeyArrowDown();
        public static CommandKeyArrowDown GetCommandKeyArrowDown()
        {
            return Instance;
        }

        public long ReturnIndex(long indice)
        {
            return ++indice;
        }
    }
}