using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Close_Trigger : MonoBehaviour
{
    public GameObject currentDoor;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (currentDoor != null && currentDoor.GetComponent<DoorScript>().isOpen)
        {
            currentDoor.GetComponent<DoorScript>().CloseDoor();
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
