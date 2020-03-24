using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public GameObject kyssäIkkuna;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        kyssäIkkuna.SetActive(true);
    }
}
