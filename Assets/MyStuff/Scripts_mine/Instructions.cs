using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{

public float time; 
     void Start()
    {
        Invoke("Go", time) ;

    }

    private void Go()

    {
        SceneManager.LoadScene("office_v5_lights");

    }

}
