using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public GameObject table;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.T) || Input.GetButton("Fire2"))
                table.transform.Translate(new Vector2(0f,2f * Time.deltaTime));

            if (Input.GetKey(KeyCode.R) || Input.GetButton("Fire3") )
                table.transform.Translate(new Vector2(0f ,- 2f * Time.deltaTime));
        }
    }
}
