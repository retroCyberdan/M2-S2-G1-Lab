using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_4 : MonoBehaviour
{
    public int a = 2;
    public int b = 4;
    public int c = 6;
    public int d = 8;

    private int somma = 0;
    private int prodotto = 0;
    private int media = 0;

    // Start is called before the first frame update
    void Start()
    {
        somma = a + b + c + d;
        prodotto = a * b * c * d;
        media = (a + b + c + d) / 4;
        Debug.Log("La Somma �: " + somma);
        Debug.Log("Il Prodotto �: " + prodotto);
        Debug.Log("La Media �: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
