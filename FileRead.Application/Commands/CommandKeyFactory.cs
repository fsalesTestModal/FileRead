using System;

namespace FileRead.Application.Commands
{
    public static class CommandKeyFactory
    {
        public static ICommandKey Create(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    return CommandKeyArrowDown.GetCommandKeyArrowDown();
                case ConsoleKey.UpArrow:
                    return CommandKeyArrowUp.GetCommandKeyArrowUp();
                case ConsoleKey.PageUp:
                    return CommandKeyPageUp.GetCommandKeyPageUp();
                case ConsoleKey.PageDown:
                    return CommandKeyPageDown.GetCommandKeyPageDown();
                case ConsoleKey.L:
                    return CommandKeyL.GetCommandKeyL();
                default:
                    return CommandKeyGeneric.GetCommandKeyGeneric();

            }
        }
    }
}
