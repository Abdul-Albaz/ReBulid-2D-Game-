using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPaper : MonoBehaviour
{

    public GameObject Ui;
    public GameObject pressToRead;

    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pressToRead.SetActive(true);

            if (Input.GetKey(KeyCode.E) || Input.GetButton("Submit"))
            {
                Ui.SetActive(true);
                
              
            }
           

        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressToRead.SetActive(false);
    }



    
}
