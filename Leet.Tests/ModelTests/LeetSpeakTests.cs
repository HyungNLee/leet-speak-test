using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void ConvertToLeetSpeak_Conversion()
    {
      LeetSpeak newphrase = new LeetSpeak();
      Assert.AreEqual("3pic0duz", newphrase.ConvertToLeetSpeak("Epicodus"));
    }
  }
}
