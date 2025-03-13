namespace Tests;
using Xunit;
using Logic;

public class TrackTheRobotTests
{
    [Fact]
    public void defaultcordinatesResult()
    {   
        var result= TrackTheRobot.TrackRobot(new string[] {"right 37","left 62","up 60","down 10"});
        Assert.Equal(new[] { -25, 50}, result);
    }

    [Fact]
    public void cordinatesResult()
    {   
        var result= TrackTheRobot.TrackRobot(new string[] {"right 50","right 1000","up 30","down 15"});
        Assert.Equal(new[] { 1050, 15}, result);
    }

    [Fact]
    public void nullinstructionsTest()
    {   
        var result= TrackTheRobot.TrackRobot(new string[] {});
        Assert.Equal(new[] {0,0}, result);
    }
}
