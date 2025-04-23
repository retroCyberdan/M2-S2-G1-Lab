using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_6_Stampa2Successivi : MonoBehaviour
{
    //Creo la variabile pubblica intera di nome "partenza"
    public int partenza = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Il valore di partenza è " + partenza + ". I 2 numeri successivi sono " + (partenza + 1) + " e " + (partenza + 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
