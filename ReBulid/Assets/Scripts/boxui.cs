using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxui : MonoBehaviour
{
    public GameObject bui;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bui.SetActive(true);
        StartCoroutine(disable());
    }

    IEnumerator disable()
    {
        yield return new WaitForSeconds(1f);
        bui.SetActive(false);
    }
}
