using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetButton("Submit"))
        {
        SceneManager.LoadScene(1);

        }

        if (Input.GetButton("Fire3"))
        {
            SceneManager.LoadScene(5);

        }


    }
    public void finshed(int Nume)
    {
        SceneManager.LoadScene(Nume);
    }
}
