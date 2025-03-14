namespace Tests;
using Xunit;
using Logic;

public class DriverLicenseTests{
    [Fact]
    public void ifyouaretheSecond(){
        var result = DriverLicense.License("Abril", 1, "Gaston, Agustin, Tiago, Fabian");
        Assert.Equal(20, result);
    }

    [Fact]
    public void ifyouaretheLast(){
        var result = DriverLicense.License("Santiago", 2, "Gaston, Agustin, Tiago, Fabian");
        Assert.Equal(80, result);
    }
}


