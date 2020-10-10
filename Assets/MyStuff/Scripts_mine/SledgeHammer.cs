using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.ThirdPerson
{


public class SledgeHammer : InventoryItemBase
{

   public static SledgeHammer Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }

        
    }
    public GameObject txtToDisplaySH;
    //private bool playerInZoneSH = false; 
    //public static bool onUse = false;
    public GameObject player;

    //public int delay;
    //public int delay2 = 114;
    public override string Name
    {
        get
        {
            return "sledgeHammer";
        }
    }


    public override void OnUse()
    {
        base.OnUse();
        //onUse = true; 

    }

void Start()
{
        GameObject.Find("CanvasA").gameObject.transform.GetChild(0).GetChild(10).gameObject.SetActive(false);
        SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().isTrigger = false;
        SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        SledgeHammer.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false;       

}


/*
    public virtual void OnUse()
    {
        transform.localPosition = PickPosition;
        transform.localEulerAngles = PickRotation;
        
    }

*/ //commented in 10/2
   

    public static void IsTrigger()
        {
          SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().enabled = true;

          SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().isTrigger = true;
        
          SledgeHammer.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true;       
          
          Debug.Log("IsTrigger");
        }



    public void OnTriggerEnter(Collider dataFromCollision)
  {
          if (dataFromCollision.gameObject.name == "ThirdPersonController")
        {       
            Debug.Log("hit the collider");
            GameObject.Find("CanvasA").gameObject.transform.GetChild(0).GetChild(10).gameObject.SetActive(true);
        
        }

  }
/*
    private void OnTriggerEnter(Collider other)
        {
            txtToDisplaySH.SetActive(true);
    
            txtToDisplaySH.GetComponent<Text>().text = "You picked up the SLEDGEHAMMER! \n Click the Icon. Press 'Enter' to Attack. \n Try Hard";

        }
        */


    }
}





