using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    private Vector3 trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = transform.position;
    } 

    // Update is called once per frame
    void Update()
    {
        transform.position =  trans + new Vector3(Mathf.Sin(Time.time), 0, 0);
      
    }

}
