using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCounterNew : MonoBehaviour
{
    int tokenCounter = 0;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Token")
        {
            tokenCounter++;
            Destroy(col.gameObject);
        }
    }
}