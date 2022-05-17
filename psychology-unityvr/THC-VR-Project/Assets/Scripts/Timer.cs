using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float guiTime;
    private bool isEnabled;

    //exposing seconds for testing
    private int minutes;
    public int seconds { get; private set; }
    private int fraction;

    public Text textField;

    GameObject door1, door2, door3, door4, door5, curDoor, closeD1, closeD2, closeD3, closeD4, closeD5;
    List<GameObject> doorList;
    
    void Start()
    {
        door1 = GameObject.Find("Door_O_T_K/RootNode/Root/Door/Door_Office");
        door2 = GameObject.Find("Door_H_T_BR/RootNode/Root/Door/Door_Bathroom");
        door3 = GameObject.Find("Door_H_T_B1/RootNode/Root/Door/Door_Bedroom1");
        door4 = GameObject.Find("Door_H_T_B2/RootNode/Root/Door/Door_Bedroom2");
        door5 = GameObject.Find("Door_H_T_MB/RootNode/Root/Door/Door_Master_Bedroom");
        doorList = new List<GameObject> { door1, door2, door3, door4, door5 };
        closeD1 = GameObject.Find("DoorTrigger_Office");
        closeD2 = GameObject.Find("DoorTrigger_HallwayBR");
        closeD3 = GameObject.Find("DoorTrigger_B1");
        closeD4 = GameObject.Find("DoorTrigger_B2");
        closeD5 = GameObject.Find("DoorTrigger_MB");
        closeD1.GetComponentInParent<Door_Close_Trigger>().SetCurrentDoor(door1.name);
        closeD2.GetComponentInParent<Door_Close_Trigger>().SetCurrentDoor(door2.name);
        closeD3.GetComponentInParent<Door_Close_Trigger>().SetCurrentDoor(door3.name);
        closeD4.GetComponentInParent<Door_Close_Trigger>().SetCurrentDoor(door4.name);
        closeD5.GetComponentInParent<Door_Close_Trigger>().SetCurrentDoor(door5.name);
        isEnabled = false;
        // UNCOMMENT TO OPEN ALL DOORS FOR DEVELOPMENT
        //
        // OpenNextDoor(doorList[0]);
        // OpenNextDoor(doorList[1]);
        // OpenNextDoor(doorList[2]);
        // OpenNextDoor(doorList[3]);
        // OpenNextDoor(doorList[4]);
    }

    void Update()
    {
        if (isEnabled)
        {
            guiTime = Time.time - startTime;
            minutes = (int)guiTime / 60;
            seconds = (int)guiTime % 60;
            fraction = (int)(guiTime * 100) % 100;
            textTime = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        /* As time ticks by, each door will be individually called and opened.
        Doors will be closed after the user has walked past them a certain distance.*/
        // 2:00
        if (minutes == 2 && seconds == 0 && !doorList[0].GetComponent<DoorScript>().isOpen) // 1:48 + :12
        {
            OpenNextDoor(doorList[0]); // Open Office door
        }
        //5:12
        if (minutes == 5 && seconds ==  12 && !doorList[1].GetComponent<DoorScript>().isOpen) // 4:48 + :24
        {
            OpenNextDoor(doorList[1]); // Open Bathroom door
        }
        //6:06
        if(minutes == 6 && seconds == 06 && !doorList[2].GetComponent<DoorScript>().isOpen) // 5:30 + :36
        {
            OpenNextDoor(doorList[2]); // Open first bedroom door
            OpenNextDoor(doorList[1]);
        }
        // 7:30
       if (minutes == 7 && seconds == 30 && !doorList[3].GetComponent<DoorScript>().isOpen) // 6:42 + :48
        {
            OpenNextDoor(doorList[3]); // Open second bedroom door
            OpenNextDoor(doorList[2]);
        }
        // 8:54
        if (minutes == 8 && seconds == 54 && !doorList[4].GetComponent<DoorScript>().isOpen) // 7:54 + :60
        {
            OpenNextDoor(doorList[4]); // Open master bedroom door
            OpenNextDoor(doorList[3]);
        }
    }

    private void OpenNextDoor(GameObject inDoor)
    {
        inDoor.GetComponent<DoorScript>().OpenDoor();
    }

    // Used to keep the timer from starting before the user has left the tutorial room.
    public void EnableTimer()
    {
        startTime = Time.time;
        isEnabled = true;
    }
}
