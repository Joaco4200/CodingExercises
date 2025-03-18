namespace Tests;
using Xunit;
using Logic;

public class SockPairsTests{
    [Fact]
    public void expectedoutPut(){
        var result = SockPairs.PairsCounter("AABCBDD");
        Assert.Equal(3, result);
    }
}