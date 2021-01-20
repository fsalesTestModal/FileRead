namespace FileRead.Application
{
    internal sealed class CommandKeyGeneric : ICommandKey
    {
        private static readonly CommandKeyGeneric Instance = new CommandKeyGeneric();
        public static CommandKeyGeneric GetCommandKeyGeneric()
        {
            return Instance;
        }
        public long ReturnIndex(long indice)
        {
            return indice;
        }
    }
}