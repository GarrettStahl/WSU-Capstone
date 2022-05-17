using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


/*
 * Testing Token.cs
 * 
 */
namespace Tests
{
    public class TokenTest
    {

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TokenTestWithEnumeratorPasses()
        {
            //need a second object that is tagged as a player to collide with the token
            var playerObj = new GameObject("Player");
            playerObj.tag = "Player";
            //box collider stops it from rolling
            playerObj.AddComponent<BoxCollider>();

           //create token
            var gameObj = new GameObject();

            var token = gameObj.AddComponent<BoxCollider>();

            token.gameObject.AddComponent<TokenCounter>();
            playerObj.transform.position = new Vector3(0, 0, 0);
           
            // Use yield to skip a frame.
            yield return new WaitForSeconds(1);
            var tokenComponent = token.gameObject.GetComponent<TokenCounter>();

            Assert.AreEqual(true, tokenComponent.isDestroyed);
        }
    }
}
