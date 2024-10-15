using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    // Introduce 3 números y que aparezcan de mayor a menor.

    // Variables Globales
    public int NumberOne,
               NumberTwo,
               NumberThree;


    // Start is called before the first frame update
    void Start()
    {

        GetLargeToSmall(NumberOne, NumberTwo, NumberThree); // Paso por parámetro

    }

    private void GetLargeToSmall(int a, int b, int c)
    {



        if (a >= b && a >= c) // Si 'a' es el mayor de todos
        {
            if (b >= c)
            {
                Debug.Log("El orden descendente es " + a + "," + b + "," + c);
            }
            else
            {
                Debug.Log("El orden descendente es " + a + "," + c + "," + b);
            }
        }



        else if (b >= a && b >= c) // Si 'b' es el mayor de todos
        {
            if (a <= c)
            {
                Debug.Log("El orden descendente es " + b + "," + a + "," + c);
            }
            else
            {
                Debug.Log("El orden descendente es " + b + "," + c + "," + a);
            }

        }



        else if (c >= a && c >= b) // Si 'c' es el mayor de todos
        {

            if (b >= a)
            {
                Debug.Log("El orden descendente es " + c + "," + b + "," + a);
            }
            else
            {
                Debug.Log("El orden descendente es " + c + "," + a + "," + b);
            }
        }

    }

}
