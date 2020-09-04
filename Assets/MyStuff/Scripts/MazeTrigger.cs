using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTrigger : MonoBehaviour
{
    public GameObject mediaPlayer7; 



    
        public void OnTriggerEnter(Collider other)
        {       
            Destroy(mediaPlayer7);
            Destroy(GameObject.Find("screen7"));
            Destroy(GameObject.Find("DL7"));
        }
    
}
