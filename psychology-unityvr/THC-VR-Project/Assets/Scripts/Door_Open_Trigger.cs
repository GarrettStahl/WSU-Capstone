using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open_Trigger : MonoBehaviour
{
    public GameObject currentDoor;
    private void OnTriggerEnter(Collider collision)
    {
        if (currentDoor != null && !currentDoor.GetComponent<DoorScript>().isOpen)
        {
            currentDoor.GetComponent<DoorScript>().OpenDoor();
            //Debug.Log("In open: Door is not null + " + currentDoor.name);
        }
        /*else
        {
            Debug.Log("Door is null");
        }*/
    }

    public void SetCurrentDoor(string doorName)
    {
        currentDoor = GameObject.Find(doorName);
    }
}