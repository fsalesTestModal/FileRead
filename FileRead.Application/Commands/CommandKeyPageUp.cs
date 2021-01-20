namespace FileRead.Application.Commands
{
    internal sealed class CommandKeyPageUp : ICommandKey
    {
        private static readonly CommandKeyPageUp Instance = new CommandKeyPageUp();
        public static CommandKeyPageUp GetCommandKeyPageUp()
        {
            return Instance;
        }
        public long ReturnIndex(long indice)
        {
            return indice < 11 ? 0 : indice - 11;
        }
    }
}