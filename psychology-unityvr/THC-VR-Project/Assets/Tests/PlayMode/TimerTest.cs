using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
/*
 * Testing the script in Timer.cs
 * Since this script relies on the DoorScripts to run at certain times
 * we will test that the time is calculated properly at the seconds level
 */
namespace Tests
{
   
    public class TimerTest
    {
  
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TimerTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.


            //The timer needs to connect to doors and their respective triggers
            // so we gotta create a lot of objects
            
            //triggers
            var trigger1 = new GameObject();
            trigger1.AddComponent<Door_Close_Trigger>();
            trigger1.name = "DoorTrigger_Office";

            var trigger2 = new GameObject();
            trigger2.AddComponent<Door_Close_Trigger>();
            trigger2.name = "DoorTrigger_HallwayBR";


            var trigger3 = new GameObject();
            trigger3.AddComponent<Door_Close_Trigger>();
            trigger3.name = "DoorTrigger_B1";

            var trigger4 = new GameObject();
            trigger4.AddComponent<Door_Close_Trigger>();
            trigger4.name = "DoorTrigger_B2";

            var trigger5 = new GameObject();
            trigger5.AddComponent<Door_Close_Trigger>();
            trigger5.name = "DoorTrigger_MB";

            //doors
            var door1 = new GameObject();
            door1.name = "Door_O_T_K/RootNode/Root/Door/Door_Office";

            var door2 = new GameObject();
            door2.name = "Door_H_T_BR/RootNode/Root/Door/Door_Bathroom";

            var door3 = new GameObject();
            door3.name = "Door_H_T_B1/RootNode/Root/Door/Door_Bedroom1";

            var door4 = new GameObject();
            door4.name = "Door_H_T_B2/RootNode/Root/Door/Door_Bedroom2";

            var door5 = new GameObject();
            door5.name = "Door_H_T_MB/RootNode/Root/Door/Door_Master_Bedroom";



            //now set up the timer
            var GameObj = new GameObject();
            var timer = GameObj.AddComponent<Timer>();
            var component = timer.GetComponent<Timer>();

            //wait five seconds, check if the time is equal to five seconds
            yield return new WaitForSeconds(5);

          
            Assert.AreEqual(5, component.seconds);
        }
    }
}
