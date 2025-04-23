using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_11 : MonoBehaviour
{
    //inserisco l'attributo "Range" (NB: gli attributi NON necessitano di ; a fine riga)
    //tale attributo verrà visualizzato nell'Inspector sottoforma di Slider
    [Range(0, 10)]
    public float voto = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //if (voto >= 10)
        //{
        //    Debug.Log("A+");
        //}
        //else if(voto >= 9)
        //{
        //    Debug.Log("A");
        //}
        //else if (voto >= 7 && voto <= 8)
        //{
        //    Debug.Log("B");
        //}
        //else if (voto >= 6)
        //{
        //    Debug.Log("C");
        //}
        //else if (voto >= 5)
        //{
        //    Debug.Log("E");
        //}
        //else if (voto >= 0 && voto <= 4)
        //{
        //    Debug.Log("F");
        //}

        switch (voto)
        {
            case >= 10:
                {
                    Debug.Log("A+");
                }
                break;
            case >= 9:
                {
                    Debug.Log("A");
                }
                break;
            case >= 8:
                {
                    Debug.Log("B");
                }
                break;
            case >= 7:
                {
                    Debug.Log("B");
                }
                break;
            case >= 6:
                {
                    Debug.Log("C");
                }
                break;
            case >= 5:
                {
                    Debug.Log("E");
                }
                break;
            case <= 4:
                {
                    Debug.Log("F");
                }
                break;
            case >= 0:
                {
                    Debug.Log("F");
                }
                break;
            default:
                Debug.Log("Voto non disponibile");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
