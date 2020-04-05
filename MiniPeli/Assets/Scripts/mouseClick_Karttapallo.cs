using UnityEngine;

public class mouseClick_Karttapallo : MonoBehaviour
{
    public GameObject kyssäIkkuna_Karttapallo;

    private void OnMouseDown()
    {
        kyssäIkkuna_Karttapallo.SetActive(true);
        transform.localScale *= 2;
        Destroy(gameObject, 2);
    }
}
