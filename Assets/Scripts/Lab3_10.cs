using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_10 : MonoBehaviour
{
    //Dichiaro la vriabile "time" di tipo float
    float time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dichiaro il "DeltaTime" per calcolare lo scorrere del tempo frame dopo frame
        time += Time.deltaTime;

        //creo la condizione per mandare in Console un determinato messaggio ogn tot secondi trascorsi
        if (time <30)
        {
            Debug.Log("Sono trascorsi meno di 30 secondi");
        }
        else if (time > 60)
        {
            Debug.Log("E' trascorso più di 1 minuto");
        }
        else if (time > 45)
        {
            Debug.Log("Sono trascorsi più di 45 secondi");
        }
        else if (time > 30)
        {
            Debug.Log("Sono trascorsi più di 30 secondi");
        }

        //dopo aver calcolato il tempo, manda in Console il valore di "time"
        Debug.Log("Il Tempo è: " + time);
    }
}
