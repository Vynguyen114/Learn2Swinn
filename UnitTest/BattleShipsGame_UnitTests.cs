using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShipsGame_UnitTests
{
    [TestClass]
    public class BattleShipGameTests
    {
        [TestMethod]
        public void AddDeployedPlayer()
        {
            var battleship = BattleShipsGame();

            var result = battleship.AddDeployedPlayers(new Player { _player = null });

            Assert.IsTrue(result);
        }
    }
}
