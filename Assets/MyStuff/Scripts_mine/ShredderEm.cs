using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredderEm : MonoBehaviour
{
    public GameObject textToDisplayShredder;
    // Start is called before the first frame update
    void Start()
    {
        textToDisplayShredder.SetActive(false); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
       textToDisplayShredder.SetActive(true); 
       Debug.Log("working");
        
    }
}
