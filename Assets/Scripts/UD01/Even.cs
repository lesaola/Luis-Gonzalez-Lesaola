using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Muestra los números pares entre el 0 y el 100.

    // Valores Globales (Tampoco harían falta en este ejercicio)

    // Start is called before the first frame update
    void Start()
    {
       GetEvenNumbers();
    }

    private void GetEvenNumbers() 
    {

        int i = 0;

        while (i < 100) 
        {
            if (i % 2 == 0) 
            {
                Debug.Log(i); // O bien "for (int i = 0; i < 100; i++) {if (i % 2 == 0) {Debug.Log(i);} }"
            }
        
            i++;
        }
        
        

    }



}
