using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownBox : MonoBehaviour
{
    public GameObject boxPrefab;
    public Transform[] locationSpown;

    private float curSpawnTime;
    private float spawnTime = .6f;

    // Start is called before the first frame update
    void Start()
    {
        curSpawnTime = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        curSpawnTime -= 1 * Time.deltaTime;

        if (curSpawnTime <= 0)
        {
            spowing();

            curSpawnTime = spawnTime;
        } 
           
    }


    void spowing()
    {
        int i = Random.Range(0, 4);
        Instantiate(boxPrefab, locationSpown[i].transform.position, Quaternion.identity);

        Instantiate(boxPrefab, locationSpown[5].transform.position, Quaternion.identity);
        Instantiate(boxPrefab, locationSpown[6].transform.position, Quaternion.identity);
    }
  
}
