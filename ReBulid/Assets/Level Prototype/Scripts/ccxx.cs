using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccxx : MonoBehaviour
{
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Circle4")
        {
            rigid.AddForce(transform.up * 30f, ForceMode2D.Impulse);
        }
    }
}
