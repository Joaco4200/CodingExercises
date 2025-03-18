namespace Tests;
using Xunit;
using Logic;

public class ReversingBinaryTests{
    [Fact]
    public void expectedoutPut(){
        var result= ReversingBinary.ReverseNumber(10);
        Assert.Equal(5  , result);
    }
}