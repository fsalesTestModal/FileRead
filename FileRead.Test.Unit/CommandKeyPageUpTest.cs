using FileRead.Application;
using System;
using Xunit;

namespace FileRead.Test.Unit
{
    public class CommandKeyPageUpTest
    {
        [Theory]
        [InlineData(12)]
        [InlineData(20)]
        [InlineData(100)]
        public void ReturnIndex_IndexGreaterThanEleven_ReturnIndexMinusEleven(long index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.PageUp);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(index - 11, returnedIndex);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(10)]
        [InlineData(9)]
        public void ReturnIndex_IndexLessThanOrEqualEleven_ReturnZero(long index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.PageUp);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(0, returnedIndex);
        }
    }
}
