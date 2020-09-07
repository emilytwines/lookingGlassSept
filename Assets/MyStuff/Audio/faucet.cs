using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
public class faucet : MonoBehaviour
{

    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();

    
        Invoke("playAudio", 2.0f);

        void playAudio()
        {
            myAudio.Play();
            delayLoop();

            void delayLoop()
            {

                Task.Delay(2000);
                myAudio.Pause();
                Task.Delay(2000);
                myAudio.UnPause();
            }
        }

        

    }


    
}






/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class faucet : MonoBehaviour
{

    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
       myAudio = GetComponent<AudioSource>();

        Invoke("playAudio", 2.0f);
    }


    public void playAudio()
    {
        myAudio.Play(2);
        //Task.Delay(2000);
        //myAudio.Pause(2);
    }
}
*/
 
