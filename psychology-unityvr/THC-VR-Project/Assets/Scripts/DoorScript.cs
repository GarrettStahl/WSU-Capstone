using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;

    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void OpenDoor()
    {
        transform.Rotate(0, -90, 0);
        isOpen = true;
    }

    public void CloseDoor()
    {
        transform.Rotate(0, 90, 0);
        isOpen = false;
    }
}
