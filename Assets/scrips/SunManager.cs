using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SunManager : MonoBehaviour
{
    private void Update()
    {
        AllSunCollected();
    }

   public void AllSunCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan soles, tienes más energia");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
