using UnityEngine;

public class mouseClick_Energiajuoma: MonoBehaviour
{
    public GameObject kyssäIkkuna_Energiajuoma;

    private void OnMouseDown()
    {
        kyssäIkkuna_Energiajuoma.SetActive(true);
        transform.localScale *= 2;
        Destroy(gameObject, 2);
    }
}
