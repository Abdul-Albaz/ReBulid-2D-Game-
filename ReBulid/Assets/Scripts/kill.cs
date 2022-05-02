using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{


  public Animator animator;
 public Transform player;


private void OnCollisionEnter2D(Collision2D collision)
{

    if (collision.gameObject.tag == "Player")
    {
        player.transform.position = new Vector3(-12.4f, 0.51f, -2.96f);
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