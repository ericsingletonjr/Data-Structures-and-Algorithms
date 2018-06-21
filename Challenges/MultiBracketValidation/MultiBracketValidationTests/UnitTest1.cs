using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aerggq")]
        [InlineData("!09eqe093")]
        [InlineData(" ")]
        public void InvalidStringsReturnFalseNotNull(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
        [Theory]
        [InlineData("(){}[]")]
        [InlineData("[[{}]]({[]})")]
        [InlineData("[bob]{code{yes}}(pass)()")]
        [InlineData("[{()}]")]
        public void ValidStringsThatAreBalancedReturnTrue(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }
        [Theory]
        [InlineData("({)}")]
        [InlineData("[[{}]]({]})")]
        [InlineData("[{code{no}}(pass)()")]
        [InlineData("[{()}{")]
        public void ValidStringsThatAreNotBalancedReturnFalse(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
