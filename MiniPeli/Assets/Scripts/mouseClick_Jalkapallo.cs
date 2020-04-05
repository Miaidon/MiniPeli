using UnityEngine;

public class mouseClick_Jalkapallo : MonoBehaviour
{
    public GameObject kyssäIkkuna_Jalkapallo;

    private void OnMouseDown()
    {
        kyssäIkkuna_Jalkapallo.SetActive(true);
        transform.localScale *= 2;
        Destroy(gameObject, 2);
    }
}
