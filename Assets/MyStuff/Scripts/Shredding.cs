using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;

public class Shredding : MonoBehaviour
{
    public int stackGenInterval = 15;

    public bool printLightStatus = false;
    public bool paperStackVisible = false;

    public GameObject paperStack;
    public GameObject printerSpot;


    // Start is called before the first frame update
    void Start()
    {
        paperStack.gameObject.SetActive(paperStackVisible);
        printerSpot.gameObject.SetActive(printLightStatus);
        StartCoroutine(InitailStackPrint());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InitailStackPrint()
    {
        yield return new WaitForSeconds(stackGenInterval);
        printLightStatus = true;
        paperStackVisible = true;
        printerSpot.gameObject.SetActive(printLightStatus);
        paperStack.SetActive(paperStackVisible);
    }
}
