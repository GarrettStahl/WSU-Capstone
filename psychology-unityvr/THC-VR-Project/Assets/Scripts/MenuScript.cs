using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void LoadNonStressful()
    {
        SceneManager.LoadScene("Scenes/NonStressfulHouse");
    }

    public void LoadStressful()
    {
        SceneManager.LoadScene("Scenes/StressfulHouse");
    }
}
