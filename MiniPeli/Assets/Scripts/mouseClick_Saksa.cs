using UnityEngine;

public class mouseClick_Saksa : MonoBehaviour
{
    public GameObject kyssäIkkuna_Saksa;

    private void OnMouseDown()

    {
        kyssäIkkuna_Saksa.SetActive(true);
        transform.localScale *= 2;
        Destroy(gameObject, 2);
    }
}

