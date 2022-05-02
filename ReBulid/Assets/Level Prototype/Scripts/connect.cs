using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connect : MonoBehaviour
{
    AudioSource audio;
    public AudioClip clip;
    public GameObject anothertrap;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "ali")
        {
            audio.PlayOneShot(clip);
            Debug.Log("yes");
            Destroy(anothertrap);
        }
    }
}
