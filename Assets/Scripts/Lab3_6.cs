using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_6 : MonoBehaviour
{
    //Creo la variabile pubblica intera di nome "partenza"
    public int partenza = 0;

    // Start is called before the first frame update
    void Start()
    {
        //richiamo la funzione creata
        Stampa2Successivi();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Creo la funzione "Stampa2Successivi" per calcolare i 2 numeri successivi a quello inserito
    void Stampa2Successivi()
    {
        Debug.Log("Il valore di partenza è " + partenza + ". I 2 numeri successivi sono " + (partenza + 1) + " e " + (partenza + 2));
    }
}
