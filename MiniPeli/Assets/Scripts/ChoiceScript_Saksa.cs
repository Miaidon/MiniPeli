using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChoiceScript_Saksa : MonoBehaviour {
    
 
    public GameObject TextBox;
    public GameObject choice01;
    public GameObject choice02;
    public GameObject choice03;
    public int ChoiceMade;

    public void ChoiceOption1(){
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Correct";
        ChoiceMade = 1;
        
    }

    public void ChoiceOption2(){
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Wrong";
        ChoiceMade = 2;
        CountdownTimer.seconds -=10f * Time.deltaTime;
        
         
    }

    public void ChoiceOption3(){
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Almost";
        ChoiceMade = 3;
    }

    void Update() {
        if(ChoiceMade >=1) {
            choice01.SetActive(false);
            choice02.SetActive(false);
            choice03.SetActive(false);
        }
    }
}
