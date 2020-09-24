using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CoinTest
    {
        public void Testing_Coin()
        {
            var coin = new UImanager();

            float testCoin = coin.UpdateCoins(1);

            int expected_coin = 1;

            Assert.AreEqual(expected_coin, testCoin);
        }

        [UnityTest]
        public IEnumerator scoreCalulatorWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
