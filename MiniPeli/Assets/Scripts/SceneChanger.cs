using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public GameObject infoIkkuna;


   public void JuusanHuone(){
       SceneManager.LoadScene("JuusanHuone");
   }

   public void NikonHuone(){
       SceneManager.LoadScene("NikonHuone");
   }

   public void StartScene(){
       SceneManager.LoadScene("StartScene");
   }
    
    public void avaaInfo() { 
        infoIkkuna.SetActive(true);
    }

    public void suljeInfo() {
        infoIkkuna.SetActive(false);
    }

}
