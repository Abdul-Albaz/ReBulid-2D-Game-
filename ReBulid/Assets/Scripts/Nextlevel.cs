using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButton("Submit"))
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetButton("Fire2"))
        {
            Application.Quit();
        }

        if (Input.GetButton("Fire3"))
        {
            SceneManager.LoadScene(5);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void AboutUs()
    {
        SceneManager.LoadScene(5);
    }
}
