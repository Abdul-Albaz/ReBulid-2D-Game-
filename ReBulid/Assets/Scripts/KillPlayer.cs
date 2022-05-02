using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public Animator animator;
    public Transform player;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(3.83f, 4.09f, -2.96f);
            animator.SetBool("deth", true);
            StartCoroutine("dethloop");
            FindObjectOfType<AudioManger>().Play("hurt");

        }
    }
   

    IEnumerator dethloop()
    {

        yield return new WaitForSeconds(0.2f);
        animator.SetBool("deth", false);
        
    }
}
