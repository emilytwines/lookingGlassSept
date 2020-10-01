using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;
 /*
public class Shredding : MonoBehaviour
{
   private float startDelay = 15f;
    private float spawnInterval = 30f;
    public Vector3 spawnPos = new Vector3(1.09f, 1f, 0.665f);

    public int stackCount = 0; 

    //to do: add second, third, etc. spawning positions, add to y coordinate


    public bool stackPickedUp = false;
    public bool printLightStatus = false;
    public bool stackOnPrinter = false;

    public GameObject[] stackPrefabs;
    public GameObject paperStack;
    public GameObject printerSpot;

    // public int stackGenInterval = 15;
    // public bool paperStackVisible = false;


    // Start is called before the first frame update
    void Start()
    {
        if (!stackOnPrinter)
        {
            IEnumerator
        }
       // InvokeRepeating("PaperStackSpawn", startDelay, spawnInterval);

        // paperStack.gameObject.SetActive(paperStackVisible);

        printerSpot.gameObject.SetActive(printLightStatus);

        // StartCoroutine(InitailStackPrint());
    }

    

    // Update is called once per frame
    void Update()
    {
        if (!stackOnPrinter)
        {
            printLightStatus = false;
        }
    }

    /* IEnumerator InitailStackPrint()
    {
        yield return new WaitForSeconds(stackGenInterval);
        printLightStatus = true;
        paperStackVisible = true;
        printerSpot.gameObject.SetActive(printLightStatus);
        paperStack.SetActive(paperStackVisible);
    }
    

    void PaperStackSpawn()
    {
        // int stackIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(paperStack,spawnPos,paperStack.transform.rotation);
        printLightStatus = true;
        stackOnPrinter = true;
        printerSpot.gameObject.SetActive(printLightStatus);
        stackCount ++;

        if(stackOnPrinter == true);
    }

}

/*

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2f;
    private float spawnInterval = 2.2f;


    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
*/