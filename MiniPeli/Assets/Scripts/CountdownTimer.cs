using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CountdownTimer : MonoBehaviour
{


   public float currentTime = 300;
   

   public Text countdownText;
    public Text pisteet;
   private bool timerIsActive = true;
   public static float score = 0;
   public static float seconds;

 void Start() {
       
       countdownText= GetComponentInChildren<Text>();
       pisteet = GetComponentInChildren<Text>();
}

void Update()
{

    if(timerIsActive){
        currentTime -= Time.deltaTime; //vähentää aikaa joka sekuntti
        seconds = (int)(currentTime);
        countdownText.text = "Aika: " + seconds; //aika joka näkyy näytöllä
       
        if(currentTime<=0){  //Pysäyttää kellon kun aika on 0
            currentTime=0;
            
            timerIsActive=false;
            updateScore();
            SceneManager.LoadScene("GameOver");
            }
     if (GameObject.FindWithTag("Kysymys") == null) {       //Lopettaa pelin kun kaikki assetit on tuhottu
            timerIsActive=false;
            updateScore();
            StartCoroutine(waitSecond()); 
        }
        }

     IEnumerator waitSecond()
     {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("GameOver");
        }

        void updateScore(){  //Laskee ajan ja pisteet yhteen 
    seconds+=score;
        }
    
    }


}
