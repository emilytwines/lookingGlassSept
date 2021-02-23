using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.Characters.FirstPerson;


public class FinalManager : MonoBehaviour
{
    public GameObject player; 

    // Start is called before the first frame update
    void Awake()
    {
        player.GetComponent<ThirdPersonUserControl>().enabled = false; 
        player.GetComponent<ThirdPersonCharacter>().enabled = false; 
 
        player.GetComponent<Animator>().enabled = false;
        player.GetComponent<Animation>().enabled = false;
        player.GetComponent<CapsuleCollider>().enabled = false;

        //BlueSuit: 
        player.transform.GetChild(0).gameObject.SetActive(false);
        
        //followcamera:
        player.transform.GetChild(4).gameObject.SetActive(true);
        
        //GameObject.Find("FollowCamera").SetActive(true); 


    }

    void Start()
    {
        GameObject.Find("CameraMain").SetActive(false); 
        player.GetComponent<FirstPersonController>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
