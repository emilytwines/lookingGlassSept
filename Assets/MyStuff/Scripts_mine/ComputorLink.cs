using UnityEngine;
using UnityEngine.EventSystems;
using System;
//using UnityEngine.Events;
using System.Runtime.InteropServices;


public class ComputorLink : MonoBehaviour//, IPointerDownHandler
 {
	//[Serializable]
	//public class ButtonPressEvent : UnityEvent { } 

	//public ButtonPressEvent OnPress = new ButtonPressEvent();

public bool textBool;
public GameObject text; 


public void Awake()
{
    //text = GameObject.Find("CanvasOffice").transform.GetChild(0).GetChild(2).gameObject;
    text.SetActive(false);

    

}

//void Start()
//{
  //  text.SetActive(false); 
    //textBool = false; 
//}
/*
    private void OnTriggerEnter(Collider other)
    {  
       textBool = true;

       text.SetActive(true);
    }
      
    void Update()
    {
        if(textBool == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                {
                    Debug.Log("key recognized");
                    openWindow();
                    //OpenLinkJSPlugin();       
                            
                }
        }
    }

    [DllImport("__Internal")]
	private static extern void openWindow();
    

   private void OnTriggerExit()
   {
     text.SetActive(false);
     textBool = false; 

   }
}

  */
void OnTriggerEnter(Collider other)
  {
      text.SetActive(true); 
      textBool = true; 
      Debug.Log(textBool);
  }

   void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        textBool = false; 
    }

   void Update()
    {
        if(textBool == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                {
                    Debug.Log("key recognized");
                    openWindow();
                    //OpenLinkJSPlugin();       
                            
                }
        }
    }

    [DllImport("__Internal")]
	private static extern void openWindow();
    

  // private void OnTriggerExit()
  // {
  //   text.SetActive(false);
  // }
}
