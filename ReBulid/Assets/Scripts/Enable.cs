using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable : MonoBehaviour
{
    private bool Repar = false;
    // Start is called before the first frame update
    public Animator anim1,anim2;
    public string NameOfParameter;
    public GameObject textpressbutoon;

    private void Start()
    {
       
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            anim2.SetBool("banshed", true);
            if (Input.GetKey(KeyCode.Q) || Input.GetButton("Submit"))
            {
                anim1.SetBool("Destroy", false);
                anim1.SetTrigger(NameOfParameter);
                
                StartCoroutine(Resert());
                FindObjectOfType<AudioManger>().Play("Build");
            }

            textpressbutoon.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(type());
    }

    IEnumerator Resert()
    {
        yield return new WaitForSeconds(15f);
        anim1.SetBool("Destroy", true);    
    }

    IEnumerator type()
    {
        yield return new WaitForSeconds(0.5f);
        textpressbutoon.SetActive(false);

    }

}
