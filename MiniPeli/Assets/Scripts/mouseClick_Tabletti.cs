using UnityEngine;

public class mouseClick_Tabletti : MonoBehaviour
{
    public GameObject kyssäIkkuna_Tabletti;

    private void OnMouseDown()
    {
        kyssäIkkuna_Tabletti.SetActive(true);
        transform.localScale *= 2;
        Destroy(gameObject, 2);
    }
}
