using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevelfinal : MonoBehaviour
{
    public Animator anim,anim2;

    void Start()
    {
        anim.SetBool("banshed", true);
        anim2.SetBool("banshed", true);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Starte());
    }
    // Update is called once per frame
    

    
    IEnumerator Starte()
    {
        anim.SetBool("banshed", false);
        anim2.SetBool("banshed", false);
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene(5);
    }
}
