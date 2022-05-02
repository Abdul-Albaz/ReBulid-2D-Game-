using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speek : MonoBehaviour
{
    public GameObject Dilog;
    public GameObject text;
    public GameObject Panel;
    // Start is called before the first frame update
    public Animator anim1, anim2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            FindObjectOfType<AudioManger>().Play("god");
            anim1.SetBool("Speek", true);

            StartCoroutine(Resert());

            Dilog.SetActive(true);
            Panel.SetActive(true);
        }
    }
   

    IEnumerator Resert()
    {
        yield return new WaitForSeconds(30f);

       
        anim1.SetBool("Speek", false);
        anim2.SetBool("FinshSpeek", true);
        FindObjectOfType<AudioManger>().Play("open");
        text.SetActive(false);
        Panel.SetActive(false);


    }
}
