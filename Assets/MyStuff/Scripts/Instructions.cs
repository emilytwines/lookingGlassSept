using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{


     void Start()
    {
        Invoke("Go", 5f) ;

    }

    private void Go()

    {
        SceneManager.LoadScene("office_v5_lights");

    }

}
