using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_5 : MonoBehaviour
{
    public int n = 31;
        
    // Start is called before the first frame update
    void Start()
    {
        if (n%2 == 0)
        {
            Debug.Log("n � un numero PARI");
        }
        else if (n>10)
        {
            Debug.Log("n � MAGGIORE DI 10");
        }
        else
        {
            Debug.Log("n � un numero DISPARI");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
