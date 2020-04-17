using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ChoiceScript_Energiajuoma : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject choice01;
    public GameObject choice02;
    public GameObject choice03;
    public int ChoiceMade;

    public void ChoiceOption1() //Vaihtoehto a)
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Correct";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()//Vaihtoehto b)
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Wrong";
        ChoiceMade = 2;
    }

    public void ChoiceOption3()//Vaihtoehto c)
    {
        TextBox.GetComponent<TMPro.TextMeshProUGUI>().text = "Wrong";
        ChoiceMade = 3;
    }

    void Update()
    {
        if (ChoiceMade >= 1) //asettaa valitun "choicen" aktiiviseksi
        {
            choice01.SetActive(false);
            choice02.SetActive(false);
            choice03.SetActive(false);
        }
    }
}
