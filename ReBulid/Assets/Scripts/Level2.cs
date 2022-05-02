using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public GameObject textlevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            textlevel.SetActive(true);

            if (Input.GetKey(KeyCode.E) || Input.GetButton("Submit"))
            {
                SceneManager.LoadScene(4);
            }


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(enterlevel());
    }

    IEnumerator enterlevel()
    {
        yield return new WaitForSeconds(1f);
        textlevel.SetActive(false);
    }

   
}
