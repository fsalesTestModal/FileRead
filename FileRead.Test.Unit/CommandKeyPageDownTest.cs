using FileRead.Application;
using System;
using Xunit;

namespace FileRead.Test.Unit
{
    public class CommandKeyPageDownTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(25)]
        public void ReturnIndex_ReturnIndexPlusEleven(long index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.PageDown);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(index + 11, returnedIndex);
        }
    }
}
