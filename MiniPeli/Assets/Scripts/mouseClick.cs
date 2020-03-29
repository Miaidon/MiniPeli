using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public GameObject kyssäIkkuna;

    private void OnMouseDown()
    {
        kyssäIkkuna.SetActive(true);
        transform.localScale *= 2;
    }
}

