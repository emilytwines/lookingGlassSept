using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson

{
public class TriggerHammer : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public int delay = 219;
    //public int delay2 = 114;

    //void Start()
    //{
     /*   
        if (Die.i == 0)
            {
            SledgeHammer.Invoke("IsTrigger", delay);
            }
        else 
        {
            SledgeHammer.Invoke("IsTrigger", delay2); 
        }
        */
    //}

     IEnumerator IsTrigger2()
    {
        // suspend execution for 219 seconds
  
            yield return new WaitForSeconds(219);

    }

     IEnumerator IsTrigger3()
    {
        // suspend execution for 114 seconds
            yield return new WaitForSeconds(114);
    }

    IEnumerator Start()
    {
        if (Die.i == 0)
        {
        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("IsTrigger3");
        SledgeHammer.IsTrigger(); 
        Debug.Log("IsTrigger3");
        }

        else if (Die.i > 0)
        {
        yield return StartCoroutine("IsTrigger3");
        SledgeHammer.IsTrigger();  
        Debug.Log("IsTrigger3");

        }
    }

}
}
