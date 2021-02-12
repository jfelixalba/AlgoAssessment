using System;
using Xunit;

namespace TGS.Challenge.Tests
{
  public class VowelCountTests
  {
    private readonly VowelCount _vowelCount;

    public VowelCountTests()
    {
      this._vowelCount = new VowelCount();
    }

    [Fact]
    public void Value_IsRequired()
    {
      Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
    }

    [Fact]
    public void AEIOU_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("AEIOU");

      // Fix this UT because expected behaviour was 6
      Assert.Equal(count, 5);
    }

    [Fact]
    public void lmnpqr_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("lmnpqr");

      Assert.Equal(count, 0);
    }

    [Fact]
    public void abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
    {
      // Fix this UT because the input was incorrect
      var count = _vowelCount.Count("abcdefghijklmnopqrstuvwxyz");

      Assert.Equal(count, 5);
    }

    [Fact]
    public void Howmanycanyoufind_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("How many can you find");

      Assert.Equal(count, 6);
    }
  }
}