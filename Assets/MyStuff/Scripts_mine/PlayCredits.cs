using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

namespace UnityStandardAssets.Utility
{
    public class PlayCredits : MonoBehaviour
    {
        //public float timeToStop = 200.5f;
        public int timeToStop = 5; 

        public MediaPlayer mediaPlayerFinal;
        public MediaPlayer mediaPlayerInterviews1;
        public MediaPlayer mediaPlayerInterviews2;
        public MediaPlayer mediaPlayerInterviews3;
        public MediaPlayer mediaPlayerInterviews4;

        public MediaPlayer mediaPlayerInterviewsCredits;


        private void Awake()
        {
            HUDSingleton.Instance.gameObject.SetActive(false);


            Inventory.Instance.gameObject.SetActive(false);

            GameObject.Find("tempMainCameraFinal").SetActive(true);
            

            CameraMain.Instance.gameObject.SetActive(false);
        }



        IEnumerator Credits()
        {
            // suspend execution for 5 seconds
            yield return new WaitForSeconds(timeToStop);
        }

        IEnumerator Start()
        {
            yield return StartCoroutine("Credits");
            Destroy(mediaPlayerFinal);
            Destroy(GameObject.Find("screenFinal"));
            Destroy(GameObject.Find("Destroy1"));
            Destroy(GameObject.Find("Destroy2"));
            Destroy(GameObject.Find("Destroy3"));
            Destroy(GameObject.Find("Destroy4"));

            HUDSingleton.Instance.gameObject.SetActive(true);
            Inventory.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCameraFinal").SetActive(false);  
            GameObject.FindWithTag("GamePlayer").gameObject.transform.GetChild(4).gameObject.SetActive(true);   

            mediaPlayerInterviews1.Play();             
            mediaPlayerInterviews3.Play();             
            mediaPlayerInterviews4.Play();             
            mediaPlayerInterviews2.Play();             
            mediaPlayerInterviewsCredits.Play();             


        }

       
    }
}


/*
    private void Start()
    {
        Destroy(mediaPlayerFinal, timeToStop);

        Destroy(GameObject.Find("screenFinal"), timeToStop);
       // Destroy(GameObject.Find("DLFinal"), timeToStop);
        


    }

    private void Update()
    {
        if (mediaPlayerFinal == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            //CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCameraFinal").SetActive(false);
           
            GameObject.FindWithTag("GamePlayer").gameObject.transform.GetChild(4).gameObject.SetActive(true);   
            }

    }
*/

