﻿using UnityEngine;

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
        Destroy(gameObject,3); //tuhoaa esineen kahden sekunnin viiveellä
    }

    public void sulje() //kun painaa "Sulje"-nappia, ikkuna sulkeutuu
    {
        kyssäIkkuna_Karttapallo.SetActive(false);
    }
}
