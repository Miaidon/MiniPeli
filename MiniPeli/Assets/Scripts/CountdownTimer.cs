using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{


   public float currentTime = 20;
   

   public Text countdownText;
   private bool timerIsActive = true;
   public static float score = 0;
   public static float seconds;

 void Start() {
       
       countdownText= GetComponentInChildren<Text>();
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
     if (GameObject.FindWithTag("Kysymys") == null) {
            timerIsActive=false;
            updateScore();
            SceneManager.LoadScene("GameOver"); 
        }
}

 void updateScore(){  //Laskee ajan ja pisteet yhteen 
    seconds+=score;
    print(seconds + " Pistettä");
}
}
}
