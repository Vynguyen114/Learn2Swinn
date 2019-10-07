using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace GameControllerTest
{
    [TestClass()]
    public class GameControllerTests
    {
        [TestMethod()]
        public void CreateComputerPlayer_hardSelected()
        {
            GameController.SetDifficulty(AIOption.Hard);
            GameController.CreateComputerPlayer();
            Assert.IsInstanceOfType(GameController.ComputerPlayer, typeof(AIHardPlayer));
        }
        [TestMethod()]
        public void CreateComputerPlayer_mediumSelected()
        {
            GameController.SetDifficulty(AIOption.Medium);
            GameController.CreateComputerPlayer();
            Assert.IsInstanceOfType(GameController.ComputerPlayer, typeof(AIMediumPlayer));
        }
        [TestMethod()]
        public void CreateComputerPlayer_easySelected()
        {
            GameController.SetDifficulty(AIOption.Easy);
            GameController.CreateComputerPlayer();
            Assert.IsInstanceOfType(GameController.ComputerPlayer, typeof(AIEasyPlayer));
        }
    }
}