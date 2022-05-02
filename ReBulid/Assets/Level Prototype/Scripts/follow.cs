using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    public float OfsetX;
    public float OfsetY;
    public float OfsetZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + OfsetX, player.position.y + OfsetY, 0f + OfsetZ);
    }
}
