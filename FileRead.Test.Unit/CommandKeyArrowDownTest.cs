using FileRead.Application;
using System;
using Xunit;

namespace FileRead.Test.Unit
{
    public class CommandKeyArrowDownTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ReturnIndex_ReturnIndexPlusOne(int index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.DownArrow);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(returnedIndex, index + 1);
        }
    }
}
