using System;
using Xunit;

namespace CosTest {
    public class Tests {
        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(-0.53)]
        [InlineData(0.53)]
        public void RecursiveTest(int n) {
            var cos = new CosX(n);
            var expected = Math.Round(cos.Actual(), 4);
            var actual = Math.Round(cos.Recursive(), 4);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(-0.53)]
        [InlineData(0.53)]
        public void SeriesTest(int n) {
            var cos = new CosX(n);
            var expected = Math.Round(cos.Actual(), 4);
            var actual = Math.Round(cos.Series(), 4);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(-0.53)]
        [InlineData(0.53)]
        public void EqualTest(int n) {
            var cos = new CosX(n);
            var recursive = cos.Recursive();
            var series = cos.Series();
            Assert.Equal(recursive, series);
        }
    }
}