using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tests
{
    [TestClass()]
    public class PlayerTests
    {        
        [TestMethod()]
        public void AItest()
        {
            string i;
            GameController.SetDifficulty(AIOption.Easy);
            GameController.SetDifficulty(AIOption.Medium);
            GameController.CreateComputerPlayer();

            i = GameController.ComputerPlayer.ToString();
            string expected = "AIMediumPlayer";
            Assert.AreEqual(expected, i);
        }
        [TestMethod()]
        public void ShipNumberTest()
        {
            int i = 0;
            BattleShipsGame S0 = new BattleShipsGame();
            var s0 = new Player(S0);
            foreach (ShipName shipToPlace in Enum.GetValues(typeof(ShipName)))
            {
                if (shipToPlace != ShipName.None)
                {
                    i++;
                    continue;
                }
            }
            int expected = 5;
            Assert.AreEqual(expected, i);
        }

    }
}