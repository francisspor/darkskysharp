using DarkSkySharp;
using Xunit;

namespace DarkSkySharpTest {
  public class DarkSkyTests {
    [Fact]
    public void Throws_Exception_On_Empty_Api_Key ()
    {
      Assert.Throws<System.Exception>(delegate
                                        {
                                                var darkSky = new DarkSky("");
                                        });
    }
  }
}
