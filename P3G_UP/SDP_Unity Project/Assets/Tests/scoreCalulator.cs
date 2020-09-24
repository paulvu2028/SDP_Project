using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class scoreCalulator
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Add_100_points_to_score()
        {
            // Use the Assert class to test conditions
            var uimanager = new UImanager();
            float score = uimanager.UpdateScore(100);

            int expected_score = 100;

            Assert.AreEqual(expected_score, score);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator scoreCalulatorWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
