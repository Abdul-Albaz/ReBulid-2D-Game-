using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mangerbatoon : MonoBehaviour
{
    public GameObject uigarden;

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {

        uigarden.SetActive(false);
        }
    }
    public void DisablePaperGarden()
    {

        uigarden.SetActive(false);
    }
}
