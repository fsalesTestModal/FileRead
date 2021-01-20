namespace FileRead.Application
{
    internal sealed class CommandKeyArrowUp : ICommandKey
    {
        private static readonly CommandKeyArrowUp Instance = new CommandKeyArrowUp();
        public static CommandKeyArrowUp GetCommandKeyArrowUp()
        {
            return Instance;
        }

        public long ReturnIndex(long indice)
        {
            return indice <= 0 ? 0 : --indice; 
        }
    }
}