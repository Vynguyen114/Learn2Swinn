using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    [TestClass()]
    public class VyTest
    {
        //Test adding new game state
        [TestMethod()]
        public void TestGameState()
        {
            GameState state = GameState.Deploying;
            GameController.AddNewState(state);

            Assert.AreEqual(GameController.CurrentState, state);
        }


        //Test to remove old game state
        [TestMethod()]
        public void TestEndCurrentState()
        {
            GameState state1 = GameState.Deploying;
            GameState state2 = GameState.Discovering;

            GameController.AddNewState(state1);
            GameController.AddNewState(state2);

            GameController.EndCurrentState();

            Assert.AreEqual(GameController.CurrentState, state1);



        }
    }
}