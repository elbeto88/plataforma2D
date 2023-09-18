using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EscenaSiguiente()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Reinicio()
    {
        SceneManager.LoadSceneAsync(0);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
