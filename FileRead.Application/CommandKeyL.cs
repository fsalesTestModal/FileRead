namespace FileRead.Application
{
    public sealed class CommandKeyL : ICommandKey
    {
        private static readonly CommandKeyL Instance = new CommandKeyL();
        public static CommandKeyL GetCommandKeyL()
        {
            return Instance;
        }

        public long ReturnIndex(long indice)
        {
            return indice < 6 ? 0 : indice - 6;
        }
    }
}