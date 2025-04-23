using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_7 : MonoBehaviour
{
    //Creo la variabile pubblica intera di nome "partenza"
    public int partenza = 0;

    // Start is called before the first frame update
    void Start()
    {
        //richiamo la funzione creata
        Stampa2Precedenti();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Creo la funzione "Stampa2Precedenti" per calcolare i 2 numeri precedenti a quello inserito
    void Stampa2Precedenti()
    {
        Debug.Log("Il valore di partenza è " + partenza + ". I 2 numeri precedenti sono " + (partenza - 1) + " e " + (partenza - 2));
    }
}
