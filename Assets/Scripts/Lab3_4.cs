using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_4 : MonoBehaviour
{
    public int a = 2;
    public int b = 4;
    public int c = 6;
    public int d = 8;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La Somma è:");
        Debug.Log(a + b + c + d);
        Debug.Log("Il Prodotto è:");
        Debug.Log(a * b * c * d);
        Debug.Log("La Media è:");
        Debug.Log((a + b + c + d) / 4);

        //string s1 = "La Somma è " + (a + b + c + d);
        //string s2 = "Il Prodotto è " + (a * b * c * d);
        //string s3 = "La Media è " + ((a + b + c + d) / 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
