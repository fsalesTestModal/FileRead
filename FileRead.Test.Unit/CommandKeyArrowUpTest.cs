using FileRead.Application;
using System;
using Xunit;

namespace FileRead.Test.Unit
{
    public class CommandKeyArrowUpTest
    {
        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(30)]
        public void ReturnIndex_IndexGreaterThanZero_ReturnIndexMinusOne(long index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.UpArrow);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(index - 1, returnedIndex);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        public void ReturnIndex_IndexLessThanOrEqualZero_ReturnZero(long index)
        {
            var commandKey = CommandKeyFactory.Create(ConsoleKey.UpArrow);
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(0, returnedIndex);
        }
    }
}
