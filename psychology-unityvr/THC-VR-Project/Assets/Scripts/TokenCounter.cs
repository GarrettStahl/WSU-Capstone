using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCounter : MonoBehaviour
{

    public bool isDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDestroy()
    {
        isDestroyed = true;
    }

    private void OnTriggerEnter(Collider collider)
    {

        int tokenCounter = 0;

        if (collider.gameObject.tag == "Hand")
        {
            tokenCounter++;
            Destroy(gameObject);
            isDestroyed = true;
        }
    }
}
