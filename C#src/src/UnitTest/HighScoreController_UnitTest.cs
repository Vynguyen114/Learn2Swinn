using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighScoreController_UnitTests
{
    [TestClass]
    public class HighScoreController
    {
        [TestMethod]
        public void CompareTo()
        {
            var score = HighScoreController();

            var result = score.CompareTo(new obj { obj = Score});

            Assert.IsTrue(result);

        }
    }
}
