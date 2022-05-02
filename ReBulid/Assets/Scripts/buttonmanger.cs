using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmanger : MonoBehaviour
{

    public GameObject adabaPaperUi;
    public GameObject URPaperUi;
    public GameObject URGardenUi;

    public void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            adabaPaperUi.SetActive(false);
            URPaperUi.SetActive(false);
            URGardenUi.SetActive(false);
        }
       
    }

    public void DisablePaperAdaba()
    {
        adabaPaperUi.SetActive(false);
        
    }

    public void DisablePaperUR()
    {
        
        URPaperUi.SetActive(false);
    }

    public void DisablePaperGarden()
    {

        URGardenUi.SetActive(false);
    }
}
