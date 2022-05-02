using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGamte : MonoBehaviour
{
    public Animator anim1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            
            anim1.SetBool("Open", true); 
            FindObjectOfType<AudioManger>().Play("open");
            Destroy(gameObject,1f);


        }
    }


  
}
