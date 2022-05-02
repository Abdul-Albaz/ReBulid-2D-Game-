using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccy : MonoBehaviour
{
    Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        vector = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vector + new Vector3(0f, Mathf.Sin(Time.time), 0f);
    }
}
