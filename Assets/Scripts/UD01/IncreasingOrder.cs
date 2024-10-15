using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    // Introduce 3 números y que el programa detecte si están introducidos en orden ascendiente


    // Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {
        IsAscendingNumber(NumberOne, NumberTwo, NumberThree); // Paso por parámetro
    }




    private void IsAscendingNumber(int a, int b, int c) 
    {
        if (a < b && b < c) 
        {
            Debug.Log("Los números " + a + ", " + b + ", " + c + " están en orden ascendiente.");
        }
        else
        {
            Debug.Log("Los números " + a + ", " + b + ", " + c + " NO están en orden ascendiente");
        }
    }



}
