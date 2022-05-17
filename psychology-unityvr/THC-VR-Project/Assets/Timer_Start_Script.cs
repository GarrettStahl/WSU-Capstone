using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Start_Script : MonoBehaviour
{
    GameObject timeCube;
    // Start is called before the first frame update
    void Start()
    {
        timeCube = GameObject.Find("Timer_Cube");
        timeCube.SetActive(false);
        //Debug.Log(timeCube.name + timeCube.activeSelf);
    }

    private void OnTriggerEnter(Collider other)
    {
        timeCube.SetActive(true);
        timeCube.GetComponent<Timer>().EnableTimer();
        //Debug.Log(timeCube.name + timeCube.activeSelf);
    }
}
