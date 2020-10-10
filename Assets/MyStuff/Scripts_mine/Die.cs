﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{

public class Die : MonoBehaviour
{
    public static int i = 0; 

    void Update()
    {
        if(ThirdPersonControllerSingleton.Instance.gameObject.GetComponent<ThirdPersonCharacter>().Health == 0)
        {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        i++;

        }    
    }
}
}


