using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedORBlue : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject.Find("CanvasFinal").SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("screenFinal") == null)
        {
            GameObject.Find("CanvasFinal").SetActive(true); 

        }
    }
}
