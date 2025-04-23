using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_8 : MonoBehaviour
{
    //Creo 2 variabili pubbliche intere di nome "a" e "b"
    public int a = 1;
    public int b = 2;

    // Start is called before the first frame update
    void Start()
    {
        //richiamo la funzione creata
        MaggioreTra2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //creo la funzione "MaggioreTra2"per calcolare con una condizione quale è il numero più grande
    void MaggioreTra2()
    {
        if (a >= b)
        {
            Debug.Log("La variabile con il valore più alto è a!");
        }
        else
        {
            Debug.Log("La variabile con il valore più alto è b!");
        }
    }
}
