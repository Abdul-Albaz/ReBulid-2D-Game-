using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigeerHideenDoor : MonoBehaviour
{
  
    // Start is called before the first frame update
    public Animator anim1, anim2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            FindObjectOfType<AudioManger>().Play("god");
            anim1.SetBool("Speek", true);
            anim2.SetBool("Open", true);
            FindObjectOfType<AudioManger>().Play("open");
            StartCoroutine(Resert());

            
        }
    }
   

    IEnumerator Resert()
    {
        yield return new WaitForSeconds(5f);

       
        anim1.SetBool("Speek", false);
        
        


    }
}
