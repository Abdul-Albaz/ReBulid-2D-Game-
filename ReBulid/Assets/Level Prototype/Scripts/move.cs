 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private CharacterController character;
    private float speed = 4f;
    public AudioSource audio;
    public Transform body;
    Rigidbody2D rigid;
    public GameObject activate;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        



        transform.position += new Vector3(x * Time.deltaTime * speed , 0, 0);

        if (!Mathf.Approximately(0,x))
        {
            transform.rotation = x > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
                }
      
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Circle")
        {
            audio.Play();
            body.position =  new Vector3(0f, Mathf.Sin(Time.time), 0.0f);
        }
        if (other.gameObject.name == "Circle3")
        {
            Destroy(other.gameObject);
            activate.SetActive(true);

        }
        if (other.gameObject.name == "Circle4")
        {
            rigid.AddForce(transform.up * 30f, ForceMode2D.Impulse);
        }

    }

}
