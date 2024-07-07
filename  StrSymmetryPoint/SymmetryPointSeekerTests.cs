using FluentAssertions;
using NUnit.Framework;

namespace StrSymmetryPoint;

[TestFixture]
public class SymmetryPointSeekerTests
{
    [Test]
    public void Seek_Empty()
    {
        var result = SymmetryPointSeeker.Seek("");

        result.Should().Be(-1);
    }
    
    [Test]
    public void Seek_Single()
    {
        var result = SymmetryPointSeeker.Seek("x");

        result.Should().Be(0);
    }
    
    [Test]
    public void Seek_Even_Chars()
    {
        var result = SymmetryPointSeeker.Seek("xxxxxx");

        result.Should().Be(-1);
    }
    
    [Test]
    public void Seek_Three_Chars_Pos()
    {
        var result = SymmetryPointSeeker.Seek("121");

        result.Should().Be(1);
    }
    
    [Test]
    public void Seek_Three_Chars_Neg()
    {
        var result = SymmetryPointSeeker.Seek("x2y");

        result.Should().Be(-1);
    }
    
    [Test]
    public void Seek_Long_Pos()
    {
        var result = SymmetryPointSeeker.Seek("racecar");

        result.Should().Be(3);
    }
    
    [Test]
    public void Seek_Long_Neg()
    {
        var result = SymmetryPointSeeker.Seek("qwertyracecarytqwe");

        result.Should().Be(-1);
    }
}