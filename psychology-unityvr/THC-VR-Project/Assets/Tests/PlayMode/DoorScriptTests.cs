using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/*
 * This set of tests relates to the DoorScript and the DoorCloseScript
 * here we are testing if the triggers and all the scripting behaves as intented
 */

namespace Tests
{
    public class DoorScriptTest
    {

        /*
         * Testing DoorScript.cs
         */

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DoorOpen_Test()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            //Create a game object, addd the component we are wishing to test to that object
            var GameObj = new GameObject();
            var door = GameObj.AddComponent<DoorScript>();


            //make a game object in the expected position
            // this is more reliable than testing the true/false given in the DoorScript.cs file
            // as this tests if it actually moved.
            var ExpectedPosition = new GameObject();
            ExpectedPosition.transform.Rotate(0, -90, 0);
            
            //execute the command we are testing
            door.OpenDoor();
            // wait 1 second for the OpenDoor command to finish
            yield return new WaitForSeconds(1);

            // the door object should be in the same position as the ExpectedPosition Object
            Assert.AreEqual(ExpectedPosition.transform.position, GameObj.transform.position);
        }

        // the following tests follow the above format
        [UnityTest]
        public IEnumerator DoorClose_Test()
        {
            var GameObj = new GameObject();
            var door = GameObj.AddComponent<DoorScript>();

            //open the door so we can test the closing script
            door.OpenDoor();

            var ExpectedPosition = new GameObject();
            //no need to move this object since we want the door to return to the original position (0,0,0)
            door.CloseDoor();
            yield return new WaitForSeconds(1);

            Assert.AreEqual(ExpectedPosition.transform.position, door.transform.position);
          
        }


        /*
         * Testing DoorTrigger.cs
         */

        [UnityTest]
        public IEnumerator SetCurrentDoor_Test()
        {
            var TriggerObj = new GameObject();
            var trigger = TriggerObj.AddComponent<Door_Close_Trigger>();

            //need a door to test
            var DoorObj = new GameObject();
            var door = DoorObj.AddComponent<DoorScript>();
            door.name = "Test Door";

            trigger.SetCurrentDoor("Test Door");

            yield return new WaitForSeconds(1);

            //if it is pointing to the right object. the names should be the same
            Assert.AreEqual(trigger.currentDoor.name, door.name);
        }

        [UnityTest]
        public IEnumerator TriggerActivation_Test()
        {
            var TriggerObj = new GameObject();
            var trigger = TriggerObj.AddComponent<Door_Close_Trigger>();
            trigger.gameObject.AddComponent<BoxCollider>();

            var collide = trigger.gameObject.GetComponent<BoxCollider>();
            collide.isTrigger = true;

            //need a door to test
            var DoorObj = new GameObject();
            var door = DoorObj.AddComponent<DoorScript>();
            door.name = "Test Door";

            trigger.SetCurrentDoor("Test Door");

            //open the door
            door.OpenDoor();

            // can use the variable since the actual movement is handleded in other tests
            Assert.AreEqual(true, door.isOpen);

            //create a new object, give it a collider then check if the door closed.
            //shouldnt have to move the object since the two colliders are on top of eachother
            var TestPlayer = new GameObject();
            TestPlayer.AddComponent<BoxCollider>();

            //give the script a second to perform the action
            yield return new WaitForSeconds(1);

            Assert.AreEqual(false, door.isOpen);
        }


    }
}
