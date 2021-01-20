using FileRead.Application;
using System;
using Xunit;

namespace FileRead.Test.Unit
{
    public class CommandKeyLTest
    {
        [Theory]
        [InlineData(12)]
        [InlineData(20)]
        [InlineData(100)]   
        public void ReturnIndex_ReturnIndexMinusSix(long index)
        {
            ICommandKey commandKey = new CommandKeyL();
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(returnedIndex, index - 6);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(5)]
        [InlineData(4)]
        public void ReturnIndex_IndexLessthanOrEqualSix_ReturnZero(long index)
        {
            var commandKey = new CommandKeyL();
            var returnedIndex = commandKey.ReturnIndex(index);

            Assert.Equal(0, returnedIndex);
        }
    }
}
