using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  è possibile esporre una VARIABILE MEMBRO nell'INSPECTOR adoperando i c.d. "MODIFICATORI DI ACCESSO", 
        //  ovvero delle PAROLE-CHIAVE da anteporre al TIPO di VARIABILE MEMBRO quando la si DICHIARA per poter 
        //  essere vista all'esterno. Due esempi possono essere:
        //
        //      - la parola "public", che porterà Unity a mostrare quela variabile nell'INSPECTOR;
        //
        //          la sintassi sarà dunque: public int (nome) = (valore);
        //
        //      - la parola "[SerializeField]" (o la sua variante "[SerializeField] private"), spesso
        //        migliore rispetto alla prima;
        //
        //          la sintassi sarà dunque: [SerializeField] int (nome) = (valore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
