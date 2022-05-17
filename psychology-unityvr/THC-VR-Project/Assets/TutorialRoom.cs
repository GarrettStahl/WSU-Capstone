using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRoom : MonoBehaviour
{
    GameObject tutRoomOpen, tutRoomClose;
    // Start is called before the first frame update
    void Start()
    {
        tutRoomOpen = GameObject.Find("DoorTrigger_Tut_Room_Open");
        tutRoomClose = GameObject.Find("DoorTrigger_Tut_Room");
        //tutRoomOpen.GetComponent<Door_Close_Trigger>().SetCurrentDoor("Door/RootNode/Root/Door/Door_Tut_To_Office");
        tutRoomClose.GetComponent<Door_Close_Trigger>().SetCurrentDoor("Door/RootNode/Root/Door/Door_Tut_To_Office");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
