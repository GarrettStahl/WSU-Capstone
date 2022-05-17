using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    [Header("Direction")]
    [SerializeField] private Transform start = null;
    [SerializeField] private Transform end = null;

    bool open = false;
    private Vector3 velocity = Vector3.zero;
    private Vector3 SavedStart;
    private Vector3 SavedEnd;

    // Start is called before the first frame update
    void Start()
    {
        SavedStart = start.position;
        SavedEnd = end.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            gameObject.transform.position = Vector3.SmoothDamp(transform.position, SavedEnd, ref velocity, 0.5f);
        }
        else if (open == false)
        {
            gameObject.transform.position = Vector3.SmoothDamp(transform.position, SavedStart, ref velocity, 0.5f);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Hand" && open == false)
        {
           
            open = true;
        }
        else if (collider.gameObject.tag == "Hand" && open == true)
        {
            open = false;
        }
    }

    private void OnDrawGizmos()
    {
        if (start && end)
            Gizmos.DrawLine(start.position, end.position);
    }
}
