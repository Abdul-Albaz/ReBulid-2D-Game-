using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManger : MonoBehaviour
{
    public TextMeshProUGUI TextDisply;
    public string[] sentence;
    private int index;
    public float typingSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(type());
    }

    // Update is called once per frame
    IEnumerator type()
    {
        foreach (char later in sentence[index].ToCharArray())
        {
            TextDisply.text += later;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
