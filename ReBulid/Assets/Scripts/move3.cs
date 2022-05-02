using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3 : MonoBehaviour
{
    public GameObject table;
    public GameObject textbuttontopres;
    

  //  public AudioClip puch;
    // Start is called before the first frame update
    void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.T) || Input.GetButton("Fire2"))
            {
                table.transform.Translate(new Vector2(3f * Time.deltaTime, 0f));
              
                
            }

            

            if (Input.GetKey(KeyCode.R) || Input.GetButton("Fire3"))
            {
                table.transform.Translate(new Vector2(-3f * Time.deltaTime, 0f));
            
            }
                
            else
           // FindObjectOfType<AudioManger>().stop("Push");


            textbuttontopres.SetActive(true);
            
        }

        


    }

   
    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(type());
        
    }

    IEnumerator type()
    {
        yield return new WaitForSeconds(0.5f);
        textbuttontopres.SetActive(false);

    }
}
