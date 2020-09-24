using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    //movement variables

    //component handles
    public class PlayerTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Player_Testing_for_input()
        {
            //var player = new Player();
            float inputv = 0;//Player.movement(0f, 0f);
            float expected_input = 0f;

            Assert.AreEqual(inputv , expected_input);
        }

        private string isEqualTo(float expected_input)
        {
            throw new NotImplementedException();
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
    }
}
