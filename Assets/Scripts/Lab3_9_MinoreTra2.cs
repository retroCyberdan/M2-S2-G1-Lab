using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_9_MinoreTra2 : MonoBehaviour
{
    //Creo 2 variabili pubbliche intere di nome "a" e "b"
    public int a = 1;
    public int b = 2;

    // Start is called before the first frame update
    void Start()
    {
        if (a <= b)
        {
            Debug.Log("La variabile con il valore più basso è a!");
        }
        else
        {
            Debug.Log("La variabile con il valore più basso è b!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
