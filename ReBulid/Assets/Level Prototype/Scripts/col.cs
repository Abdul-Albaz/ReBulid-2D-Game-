using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;

    // Start is called before the first frame update
    void Start()
    {
        animator1.enabled = false;
        animator2.enabled = false;
        animator3.enabled = false;
        animator4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ali")
        {
            Debug.Log("okay");
            Destroy(gameObject);
            animator1.enabled = true;
            animator2.enabled = true;
            animator3.enabled = true;
            animator4.enabled = true;
        }
    }
}
