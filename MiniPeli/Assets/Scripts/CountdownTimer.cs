using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{


   public float currentTime = 20;
   

   public Text countdownText;
   private bool timerIsActive = true;
   public static int score = 0;
   public static int seconds;

 void Start() {
       
       countdownText= GetComponentInChildren<Text>();
}

void Update()
{

    if(timerIsActive){
        currentTime -= Time.deltaTime; //vähentää aikaa joka sekuntti
        seconds = (int)(currentTime);
        countdownText.text = "Aika: " + CountdownTimer.seconds; //aika joka näkyy näytöllä
       
        if(currentTime<=0){  //Pysäyttää kellon kun aika on 0
            currentTime=0;
            
            timerIsActive=false;
            updateScore();
        }
    }
}

 public void updateScore(){  //Laskee ajan ja pisteet yhteen 
    currentTime+=score;
    print(currentTime + " Pistettä");
}
}
