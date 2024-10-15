using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    // Introduce 3 números y que el programa detecte si están introducidos en orden descendiente


    // Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        
        IsDescendingNumber (NumberOne, NumberTwo, NumberThree); // Paso por parámetro

    }

    private void IsDescendingNumber(int a, int b, int c) 
    {

        if (a >= b && b >= c)
        {
            Debug.Log("Los números " + a + ", " + b + ", " + c + " están en orden descendiente.");
        }
        else 
        {
            Debug.Log("Los números " + a + ", " + b + ", " + c + " NO están en orden descendiente.");
        }
    }

    
}
