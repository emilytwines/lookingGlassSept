using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ShredderEm : MonoBehaviour
{
    public GameObject textToDisplayShredder;
    public bool text; 

    public GameObject[] items;
    public int lastitem; 
    public float width = 0.0f;
    void Awake()
    {
     textToDisplayShredder.SetActive(false);
    }
 
    void Start()
    {
       // var paperSprite = GameObject.Find("paper");
    }

    void OnTriggerEnter(Collider other)
    {
        
        textToDisplayShredder.SetActive(true); 
        text = true; 
        Debug.Log(text);
                      
    }

    void OnTriggerExit(Collider other)
    {
        textToDisplayShredder.SetActive(false); 
        text = false; 
    }
//Inventory inventory = new Inventory();
/*
    void Update()
    {
       if(text == true)
       {
        //if (GameObject.Find("paper") != null)
        //{
        if (Input.GetKeyDown(KeyCode.Backspace))
            {   
                Destroy(GameObject.Find("paper"));
               // works: 
                //Debug.Log("key pressed");
                //Inventory inventory = new Inventory(); 
                //inventory.RemoveItem(Inventory.mItems[0]);
                //Debug.Log("removed from count");
                
               // Destroy(transform.Find("ItemImage").GetComponent<Image>());
               //WORKS: Destroy(GameObject.FindWithTag("inventory").transform.GetComponent<Image>());
               //GameObject.FindWithTag("inventory").AddComponent<Image>();
                
                 //GameObject[] items = GameObject.FindGameObjectsWithTag("inventory");
                 //Debug.Log(lastitem = items.Length - 1);
                
                //foreach (GameObject item in items)
                //{
                //    Destroy(item.GetComponent<Image>());
                //    Debug.Log("Destroyed");
                   
/*
                }
                /*
                GameObject[] itemsA2 = GameObject.FindGameObjectsWithTag("inventory");
                foreach (GameObject items2 in itemsA2)
                {
                        //this line is broken below
                        if(items2.GetComponent<Image>() == null)
                            {
                                Debug.Log("item component is null");

                                items2.AddComponent<Image>();
                            }
                }
        
        
               /*
               foreach (GameObject item in items)
                {
                Destroy(item.transform.GetComponent<Image>());

                Debug.Log("Destroyed");
                }

               

                
                //gameObject.transform.Find("InventoryPanel").transform.GetChild(0).GetChild(0).gameObject.AddComponent<Image>();


                //public Image image = new Image(); 
                //InventoryImageTransform.MatchOther(rt, other); 

                
                //Destroy(slot.GetChild(0).GetComponent<Image>().gameObject);
                //}
              //  GameObject.FindWithTag("inventory").GetComponent<SpriteRenderer>().size = new Vector2(0.0f, 0.0f);
       
            }
        }
             //if (GameObject.Find("paper") == Resources.Load<Sprite>("paperStack"))
 //                 {inventory.RemoveItem(paper);

                //if (GameObject.Find("paper") != null)
                //{
                  //  if (GameObject.Find("paper") == Resources.Load<Sprite>("paperStack"))
                    
                        //Inventory.RemoveItem();
/*
                foreach (var item in items) // for each ItemImage in the array of ItemImages
                {
                Debug.Log("foreach loop");

                    if(item.GetComponent<Image>() == null)
                        {
                            Debug.Log("item component is null");

                            item.AddComponent<Image>();
                        }
                }        
       */
       }
    
   
    




                    
    


