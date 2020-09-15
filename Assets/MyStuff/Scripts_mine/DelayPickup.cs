using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DelayPickup : MonoBehaviour
{
    public int delay = 214; 

    void Start()
    {
        Collider sledgeHammer = GameObject.FindWithTag("sledgeHammer").GetComponent<Collider>();
        sledgeHammer.isTrigger = false;

        Invoke("IsTrigger", delay);
    
        //114
    }
   /*
    void Start()
    {
        Collider sledgeHammer = gameObject.GetComponent<Collider>();
        sledgeHammer.isTrigger = false;

        Invoke("IsTrigger", delay);
        //114
    }
    */

    void IsTrigger()
    {
        Collider sledgeHammer = GameObject.FindWithTag("sledgeHammer").GetComponent<Collider>();
        sledgeHammer.isTrigger = true;
        //Outputto console the GameObject’s trigger state
      //  Debug.Log("Trigger On : " + sledgeHammer.isTrigger);
    }

    

}



      