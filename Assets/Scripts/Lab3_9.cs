using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_9 : MonoBehaviour
{
    //Creo 2 variabili pubbliche intere di nome "a" e "b"
    public int a = 1;
    public int b = 2;

    // Start is called before the first frame update
    void Start()
    {
        //richiamo la funzione creata
        MinoreTra2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //creo la funzione "MinoreTra2"per calcolare con una condizione quale � il numero pi� piccolo
    void MinoreTra2()
    {
        if (a <= b)
        {
            Debug.Log("La variabile con il valore pi� basso � a!");
        }
        else
        {
            Debug.Log("La variabile con il valore pi� basso � b!");
        }
    }
}
