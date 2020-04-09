using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneJuusanHuone : MonoBehaviour
{

    void Start()
    {
        Invoke("Siirtyma",2); //kutsuu metodin "Siirtyma" kahden sekunnin viiveellä
    }

    void Siirtyma()
    {
        SceneManager.LoadScene("JuusanHuone"); //vaihtaa scenen Juusan huoneeseen
    }
}

