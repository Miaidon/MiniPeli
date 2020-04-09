using UnityEngine;

public class mouseClick_Karttapallo : MonoBehaviour
{
    public GameObject kyssäIkkuna_Karttapallo;

    private void OnMouseDown() //metodi, jossa tapahtuu painauksella tapahtuvat asiat
    {
        transform.localScale *= 2; //esineen koko kasvaa kaksinkertaiseksi
        Invoke("kyssaIkkuna",1); //kutsuu metodin "kyssaIkkuna" yhden sekunnin viiveellä
    }

    private void kyssaIkkuna()
    {
        kyssäIkkuna_Karttapallo.SetActive(true); //avaa kyseisen esineen kysymysikkunan 
        Destroy(gameObject,2); //tuhoaa esineen kahden sekunnin viiveellä
    }
}
