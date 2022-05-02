using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelmanger : MonoBehaviour
{
   
    
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene(3);
        }
       
    }

    public void StartPlay()
    {
        SceneManager.LoadScene(3);
    }
}
